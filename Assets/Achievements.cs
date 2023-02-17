using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    //Instance
    public static Achievements Instance = null;
    
    //Achievement Dictionary
    public SortedDictionary<string, bool> achievements;

    //Test
    //Level 1
    public bool unlockDoorAchievement, changeIfStatementAchievement;
    //Level 2
    public bool changeGoldAchievement, changeCoinAchievement, changeSwordPriceAchievement;
    //Level 3
    public bool buffPlayer, nerfDragon;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        unlockDoorAchievement = false;
        changeIfStatementAchievement = false;
        achievements = new SortedDictionary<string, bool> {
            {"unlockDoor", false }, {"changeBool", false },
            {"changeCurrentGold", false }, {"changeCoinValue", false}, {"changeSwordPrice", false},
            {"buffPlayer", false }, {"nerfDragon", false}
        };
    }

    public void SetAchievementsLevel1 (string achievementName, bool status)
    {
        if(achievements.ContainsKey(achievementName))
        {
            achievements[achievementName] = status;
            if(achievementName == "unlockDoor")
            {
                unlockDoorAchievement = true;
            }
            else if(achievementName == "changeBool")
            {
                changeIfStatementAchievement = true;
            }
        }
    }

    public void SetAchievementsLevel2(string achievementName, bool status)
    {
        if (achievements.ContainsKey(achievementName))
        {
            achievements[achievementName] = status;
            if (achievementName == "changeCurrentGold")
            {
                changeGoldAchievement = true;
            }
            else if (achievementName == "changeCoinValue")
            {
                changeCoinAchievement = true;
            }
            else if (achievementName == "changeSwordPrice")
            {
                changeSwordPriceAchievement = true;
            }
        }
    }

    public void SetAchievementsLevel3(string achievementName, bool status)
    {
        if (achievements.ContainsKey(achievementName))
        {
            achievements[achievementName] = status;
            if (achievementName == "buffPlayer")
            {
                buffPlayer = true;
            }
            else if (achievementName == "nerfDragon")
            {
                nerfDragon = true;
            }
        }
    }

    public bool GetAchievementStatus(string achievementName)
    {
        if (achievements.ContainsKey(achievementName))
        {
            return achievements[achievementName];
        }
        else
        {
            Debug.Log("Achievement: " + achievementName + " Not Found");
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
