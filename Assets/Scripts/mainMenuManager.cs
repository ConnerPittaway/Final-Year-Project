using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenuManager : MonoBehaviour
{
    //UI
    public GameObject mainMenuButtons, LevelButtons;

    //Badges
    public BadgeManager badgeManager;
    public GameObject badgesScreen;

    //Buttons
    public List<Button> levels;

    //Main Menu
    public void MainMenuOpen()
    {
        Audio.Instance.PlaySFX("Click");
        mainMenuButtons.SetActive(true);
        LevelButtons.SetActive(false);
    }

    public void Start()
    {
        Audio.Instance.PlayMusic("Background Music Track 1");
    }

    //Levels
    public void LevelsOpen()
    {
        Audio.Instance.PlaySFX("Click");

        int i = 0;
        //Update Buttons
        foreach(Button button in levels)
        {
            if(levelManager.Instance.unlockedLevels[i])
            {
                button.interactable = true;
            }
            else
            {
                button.interactable = false;
            }
            i++;
        }

        mainMenuButtons.SetActive(false);
        LevelButtons.SetActive(true);
    }

    //Badges
    public void BadgesScreenOpen()
    {
        Audio.Instance.PlaySFX("Click");
        badgeManager.UpdateBadgeState();
        badgesScreen.SetActive(true);
        mainMenuButtons.SetActive(false);
    }

    public void BadgesScreenClose()
    {
        Audio.Instance.PlaySFX("Click");
        badgesScreen.SetActive(false);
        mainMenuButtons.SetActive(true);
    }
}
