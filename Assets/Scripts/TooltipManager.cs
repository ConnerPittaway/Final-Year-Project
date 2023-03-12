using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{
    public static TooltipManager Instance;
    public Tooltip tooltip;

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

    public static void Show(string contentText, string headerText)
    {
        Instance.tooltip.SetToolTipText(contentText, headerText);
        Instance.tooltip.gameObject.SetActive(true);
    }

    public static void Hide()
    {
        Instance.tooltip.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
