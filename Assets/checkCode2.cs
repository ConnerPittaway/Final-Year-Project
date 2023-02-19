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
        int swordPrice = int.Parse(inputs[3].text);

        if ((currentGold >= swordPrice) && !hasSword)
        {
            Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
            tilemap.SetTile(tilePos, tileB);
            hasSword = true;
            nextLevel.SetActive(true);
            currentGold -= swordPrice;
            inputs[0].text = currentGold.ToString();
            inputs[4].text = "true";
        }
    }

    Tile getTile(Tilemap tileMap, Vector3 pos)
    {
        Vector3Int tilePos = tileMap.WorldToCell(pos);
        Tile tile = tilemap.GetTile<Tile>(tilePos);

        return tile;
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
        int currentHealth = int.Parse(inputs[1].text);
        int coinValue = int.Parse(inputs[2].text);
        int swordPrice = int.Parse(inputs[3].text);

        coinCollider.coinValue = coinValue;

        Debug.Log("Current Gold is " + currentGold);
        Debug.Log("Sword price is " + swordPrice);
        //Results
        if(currentGold >= swordPrice && !hasSword)
        {
            Vector3Int tilePos = tilemap.WorldToCell(new Vector3(-0.39f, 0.73f, 0));
            tilemap.SetTile(tilePos, tileB);
            hasSword = true;
            nextLevel.SetActive(true);
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
