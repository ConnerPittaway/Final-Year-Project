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

    public void UpdateBadgeState()
    {
        /*List
            *badges[0] - unlockDoor
            *badges[1] - changeBool
            *badges[2] - changeCurrentGold
            *badges[3] - changeCoinValue
            *badges[4] - changeSwordPrice
            *badges[5] - buffPlayer
            *badges[6] - nerfDragon
            *badges[7] - spawnDupe
            *badges[8] - turnIntoGhost
            *badges[9] - codeChampion
            *badges[10] - codeDeity
            *badges[11] - level1AllAchievements
            *badges[12] - level2AllAchievements
            *badges[13] - level3AllAchievements
            *badges[14] - level4AllAchievements
            *badges[15] - allAchievements
        */

        //Unlock Door
        if (!Achievements.Instance.achievements["unlockDoor"])
        {
            AlterAlpha(false, badges[0]);
            Debug.Log("unlockDoor");
        }
        else
        {
            AlterAlpha(true, badges[0]);
        }

        //If Statement
        if (!Achievements.Instance.achievements["changeBool"])
        {
            AlterAlpha(false, badges[1]);
            Debug.Log("changeBool");
        }
        else
        {
            AlterAlpha(true, badges[1]);
        }

        //Level 1 Achievements
        if (Achievements.Instance.achievements["level1AllAchievements"])
        {
            //Achievements.Instance.achievements["level1AllAchievements"] = true;
            AlterAlpha(true, badges[11]);
        }
        else
        {
            AlterAlpha(false, badges[11]);
            Debug.Log("level1AllAchievements");
        }

        //Player Gold
        if (!Achievements.Instance.achievements["changeCurrentGold"])
        {
            AlterAlpha(false, badges[2]);
            Debug.Log("changeCurrentGold");
        }
        else
        {
            AlterAlpha(true, badges[2]);
        }

        //Coin Value
        if (!Achievements.Instance.achievements["changeCoinValue"])
        {
            AlterAlpha(false, badges[3]);
            Debug.Log("changeCoinValue");
        }
        else
        {
            AlterAlpha(true, badges[3]);
        }

        //Sword Price
        if (!Achievements.Instance.achievements["changeSwordPrice"])
        {
            AlterAlpha(false, badges[4]);
            Debug.Log("changeSwordPrice");
        }
        else
        {
            AlterAlpha(true, badges[4]);
        }

        //Level 2 Achievements
        if (Achievements.Instance.achievements["level2AllAchievements"])
        {
            AlterAlpha(true, badges[12]);
        }
        else
        {
            AlterAlpha(false, badges[12]);
            Debug.Log("level2AllAchievements");
        }

        //Buff Player
        if (!Achievements.Instance.achievements["buffPlayer"])
        {
            AlterAlpha(false, badges[5]);
            Debug.Log("buffPlayer");
        }
        else
        {
            AlterAlpha(true, badges[5]);
        }

        //Nerf Dragon
        if (!Achievements.Instance.achievements["nerfDragon"])
        {
            AlterAlpha(false, badges[6]);
            Debug.Log("nerfDragon");
        }
        else
        {
            AlterAlpha(true, badges[6]);
        }

        //Level 3 Achievements
        if (Achievements.Instance.achievements["level3AllAchievements"])
        {
            AlterAlpha(true, badges[13]);
        }
        else
        {
            AlterAlpha(false, badges[13]);
            Debug.Log("level3AllAchievements");
        }

        //Spawn Dupe
        if (!Achievements.Instance.achievements["spawnDupe"])
        {
            AlterAlpha(false, badges[7]);
            Debug.Log("spawnDupe");
        }
        else
        {
            AlterAlpha(true, badges[7]);
        }

        //Turn Into Ghost
        if (!Achievements.Instance.achievements["turnIntoGhost"])
        {
            AlterAlpha(false, badges[8]);
            Debug.Log("turnIntoGhost");
        }
        else
        {
            AlterAlpha(true, badges[8]);
        }

        //Level 4 Achievements
        if (Achievements.Instance.achievements["level4AllAchievements"])
        {
            AlterAlpha(true, badges[14]);
        }
        else
        {
            AlterAlpha(false, badges[14]);
            Debug.Log("level4AllAchievements");
        }

        //Code Champion
        if (!Achievements.Instance.achievements["codeChampion"])
        {
            AlterAlpha(false, badges[9]);
            Debug.Log("codeChampion");
        }
        else
        {
            AlterAlpha(true, badges[9]);
        }

        //Code Deity
        if (!Achievements.Instance.achievements["codeDeity"])
        {
            AlterAlpha(false, badges[10]);
            Debug.Log("codeDeity");
        }
        else
        {
            AlterAlpha(true, badges[10]);
        }

        //All achievements
        if (Achievements.Instance.achievements["allAchievements"])
        {
            AlterAlpha(true, badges[15]);
        }
        else
        {
            AlterAlpha(false, badges[15]);
            Debug.Log("allAchievements");
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
