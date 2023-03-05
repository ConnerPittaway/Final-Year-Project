using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("SecondLevel");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("ThirdLevel");
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene("FourthLevel");
    }

    public void LoadScene5()
    {
        SceneManager.LoadScene("FifthLevel");
    }

    public void LoadScene0()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
