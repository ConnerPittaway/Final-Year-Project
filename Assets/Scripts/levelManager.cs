using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    public static levelManager Instance;
    public List<bool> unlockedLevels;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        unlockedLevels = new List<bool> { true, false, false, false, false };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
