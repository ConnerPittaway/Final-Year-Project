using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using TMPro;

public class checkCode5 : MonoBehaviour
{
    public GameObject questionScreen;
    public GameObject nextLevel;
    public Tile tile;
    public Tilemap tilemap;
    public TileBase tileA;
    public TileBase tileB;
    public List<TMP_InputField> inputs;
    public List<TMP_Text> textFields;
    public Sprite[] doorSprites;
    // Start is called before the first frame update
    void Start()
    {
        //Start Tile
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileA);
    }

    // Update is called once per frame
    void Update()
    {
        //Check For Death
        if(inputs[0].text == "true")
        {
            Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
            tilemap.SetTile(tilePos, tileB);
            nextLevel.SetActive(true);
        }
    }

    Tile getTile(Tilemap tileMap, Vector3 pos)
    {
        Vector3Int tilePos = tileMap.WorldToCell(pos);
        Tile tile = tilemap.GetTile<Tile>(tilePos);

        return tile;
    }

    public void CheckInputs()
    {
        // Input Fields
        /* [0] - quizFinished
         * [1] - quizStarted
         * [2] - currentHealth
        */
        //Quiz Start
        if(inputs[1].text == "false")
        {
            inputs[1].text = "true";
            questionScreen.SetActive(true);
        }
    }
}
