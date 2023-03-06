using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using TMPro;

public class checkCode2 : MonoBehaviour
{
    public GameObject nextLevel;
    public Tile tile;
    public Tilemap tilemap;
    public TileBase tileA;
    public TileBase tileB;
    public coinCollision coinCollider;
    public List<TMP_InputField> inputs;
    public List<TMP_Text> textFields;
    public Sprite[] doorSprites;
    public int currentPlayerGold = 0;

    private int originalSwordPrice = 10, originalCoinValue = 1;

    public bool hasSword;
    // Start is called before the first frame update
    void Start()
    {
        if (Audio.Instance.currentlyPlaying != "Background Music Track 2")
        {
            Audio.Instance.PlayMusic("Background Music Track 2");
        }
        levelManager.Instance.unlockedLevels[1] = true;
        //Start Tile
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileA);

        inputs[0].onEndEdit.AddListener(delegate { currentGoldChanged(); });
        inputs[2].onEndEdit.AddListener(delegate { coinValueChanged(); });
        inputs[3].onEndEdit.AddListener(delegate { swordValueChanged(); });

        hasSword = false;
    }

    // Update is called once per frame
    void Update()
    {
        int currentGold = int.Parse(inputs[0].text);
        int coinValue = int.Parse(inputs[2].text);
        int swordPrice = int.Parse(inputs[3].text);
        coinCollider.coinValue = coinValue;
        if ((currentGold >= swordPrice) && !hasSword)
        {
            OpenDoor();
            hasSword = true;
            currentGold -= swordPrice;
            inputs[0].text = currentGold.ToString();
            inputs[4].text = "true";
        }
    }

    public void OpenDoor()
    {
        //Play Sound
        if (nextLevel.active == false)
        {
            //Audio.Instance.PlaySFX("Door Open");
        }
        Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
        tilemap.SetTile(tilePos, tileB);
        nextLevel.SetActive(true);
    }

    /* [0] - currentGold
     * [1] - currentHealth
     * [2] - coinValue
     * [3] - swordPrice
     * [4] - hasSword
     */
    public void CheckInputs()
    {
        int currentGold = int.Parse(inputs[0].text);
        int coinValue = int.Parse(inputs[2].text);
        int swordPrice = int.Parse(inputs[3].text);

        coinCollider.coinValue = coinValue;

        Debug.Log("Current Gold is " + currentGold);
        Debug.Log("Sword price is " + swordPrice);
        //Results
        if(currentGold >= swordPrice && !hasSword)
        {
            OpenDoor();
            hasSword = true;
            currentGold -= swordPrice;
            inputs[0].text = currentGold.ToString();
            inputs[4].text = "true";
        }
    }

    public void currentGoldChanged()
    {
        if (currentPlayerGold == int.Parse(inputs[0].text))
        {
            Debug.Log("No Change");
        }
        else
        {
            Debug.Log("Value Changed");
            Achievements.Instance.SetAchievementsLevel2("changeCurrentGold", true);
        }   
    }

    public void coinValueChanged()
    {
        if (originalCoinValue == int.Parse(inputs[2].text))
        {
            Debug.Log("No Change");
        }
        else
        {
            Debug.Log("Value Changed");
            Achievements.Instance.SetAchievementsLevel2("changeCoinValue", true);
        }
    }

    public void swordValueChanged()
    {
        if (originalSwordPrice == int.Parse(inputs[3].text))
        {
            Debug.Log("No Change");
        }
        else
        {
            Debug.Log("Value Changed");
            Achievements.Instance.SetAchievementsLevel2("changeSwordPrice", true);
        }
    }
}
