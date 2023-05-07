using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using TMPro;

public class checkCode : MonoBehaviour
{
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
        if(Audio.Instance.currentlyPlaying != "Background Music Track 2")
        {
            Audio.Instance.PlayMusic("Background Music Track 2");
        }
        //Start Tile
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileA);
    }

    public void OpenDoor()
    {
        //Play Sound
        if (nextLevel.active == false)
        {
            Audio.Instance.PlaySFX("Door Open");
        }
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileB);
        nextLevel.SetActive(true);
    }

    public void CloseDoor()
    {
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileA);
        nextLevel.SetActive(false);
    }

    public void CheckInputs()
    {
        for(int i = 0; i < textFields.Count; i++)
        {
            //Code is the same door condition not satisfied
            if(textFields[0].text == textFields[1].text)
            {
                Debug.Log("First");
                CloseDoor();
            }
            //Set door locked to false (default answer)
            else if(textFields[0].text == "false" && textFields[1].text == "true")
            {
                Debug.Log("Second");
                OpenDoor();
                Achievements.Instance.SetAchievementsLevel1("unlockDoor", true);
            }
            //Swap if statement (unique answer)
            else if(textFields[0].text == "true" && textFields[1].text == "false")
            {
                Debug.Log("Third");
                OpenDoor();
                Achievements.Instance.SetAchievementsLevel1("changeBool", true);

            }
            //Invalid inputs
            else
            {
                Debug.Log("Fourth");
                CloseDoor();
            }
        }
    }
}
