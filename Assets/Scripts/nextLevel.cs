using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision");
        if(collision.gameObject.CompareTag("Player"))
        {
            if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("FirstLevel"))
            {
                SceneManager.LoadScene("SecondLevel");
            }
            else if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SecondLevel"))
            {
                SceneManager.LoadScene("ThirdLevel");
            }
            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("ThirdLevel"))
            {
                SceneManager.LoadScene("FourthLevel");
            }
            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("FourthLevel"))
            {
                SceneManager.LoadScene("FifthLevel");
            }
            else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("FifthLevel"))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
