using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadgeManager : MonoBehaviour
{
    public List<Image> badges;
    // Start is called before the first frame update
    void Start()
    {
        //Set Default States
        UpdateBadgeState();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateBadgeState()
    {
        /*List
            *badges[0] - unlockDoor
            *badges[1] - changeBool
            *badges[2] - changeCurrentGold
            *badges[3] - changeCoinValue
            *badges[4] - changeSwordPrice
            *badges[5] - buffPlayer
            *badges[6] - nerfDragon
        */

        //Unlock Door
        Achievements.Instance.achievements["unlockDoor"] = true;
        if (!Achievements.Instance.achievements["unlockDoor"])
        {
            AlterAlpha(false, badges[0]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[0]);
        }

        //If Statement
        if (!Achievements.Instance.achievements["changeBool"])
        {
            AlterAlpha(false, badges[1]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[1]);
        }

        //Player Gold
        if (!Achievements.Instance.achievements["changeCurrentGold"])
        {
            AlterAlpha(false, badges[2]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[2]);
        }

        //Coin Value
        if (!Achievements.Instance.achievements["changeCoinValue"])
        {
            AlterAlpha(false, badges[3]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[3]);
        }

        //Sword Price
        if (!Achievements.Instance.achievements["changeSwordPrice"])
        {
            AlterAlpha(false, badges[4]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[4]);
        }

        //Buff Player
        if (!Achievements.Instance.achievements["buffPlayer"])
        {
            AlterAlpha(false, badges[5]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[5]);
        }

        //Nerf Dragon
        if (!Achievements.Instance.achievements["nerfDragon"])
        {
            AlterAlpha(false, badges[6]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[6]);
        }
    }

    void AlterAlpha(bool active, Image imageToChange)
    {
        if(active)
        {
            Color full = imageToChange.color;
            full.a = 1;
            imageToChange.color = full;
        }
        else
        {
            Color half = imageToChange.color;
            half.a = 0.25f;
            imageToChange.color = half;
        }
    }
}
