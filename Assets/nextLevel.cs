using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
        }
    }
}
