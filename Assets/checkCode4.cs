using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using TMPro;

public class checkCode4 : MonoBehaviour
{
    public Tile tile;
    public Tilemap tilemap;
    public TileBase tileA;
    public TileBase tileB;
    public List<TMP_InputField> inputs;
    public List<TMP_Text> textFields;
    public Sprite[] doorSprites;

    public bool spawnPlayer2 = false;

    public GameObject player1Dupe, player2;
    /* [0] - spawnPlayer
     * [1] - newPlayer
     * [2] - player2Opacity
     * [3] - player2CanActivate
     */
    // Start is called before the first frame update
    void Start()
    {
        inputs[0].characterLimit = 3;
        //Start Tile
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileA);
    }

    // Update is called once per frame
    void Update()
    {

    }

    Tile getTile(Tilemap tileMap, Vector3 pos)
    {
        Vector3Int tilePos = tileMap.WorldToCell(pos);
        Tile tile = tilemap.GetTile<Tile>(tilePos);

        return tile;
    }

    // Text Fields
    /* [0] - spawnPlayer
     * [1] - newPlayer
     * [2] - canActivate
    */  
    // Input Fields
    /* [0] - player2Opacity
    */

    public void CheckInputs()
    {
        if (textFields[0].text == "true")
        {
            spawnPlayer2 = true;
        }
        else
        {
            spawnPlayer2 = false;
        }

        string newPlayer = textFields[1].text;
        if(spawnPlayer2 && newPlayer == "Player1")
        {
            Debug.Log("Player1");
            player1Dupe.SetActive(true);
            player2.SetActive(false);
        }
        else if(spawnPlayer2 && newPlayer == "Player2")
        {
            Debug.Log("Player2");
            player1Dupe.SetActive(false);
            player2.SetActive(true);
        }
        else
        {
            player1Dupe.SetActive(false);
            player2.SetActive(false);
        }

        float value = Mathf.Clamp(float.Parse(inputs[0].text), 0.0f, 100.0f);
        inputs[0].text = value.ToString();
        Color currentColor = player2.GetComponent<SpriteRenderer>().color;
        currentColor.a =  float.Parse(inputs[0].text)/100.0f;
        Debug.Log(currentColor.a);
        player2.GetComponent<SpriteRenderer>().color = currentColor;
    }

}
