using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuManager : MonoBehaviour
{
    //UI
    public GameObject mainMenuButtons, LevelButtons;

    //Badges
    public BadgeManager badgeManager;
    public GameObject badgesScreen;

    //Main Menu
    public void MainMenuOpen()
    {
        Audio.Instance.PlaySFX("Click");
        mainMenuButtons.SetActive(true);
        LevelButtons.SetActive(false);
    }

    //Levels
    public void LevelsOpen()
    {
        Audio.Instance.PlaySFX("Click");
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
