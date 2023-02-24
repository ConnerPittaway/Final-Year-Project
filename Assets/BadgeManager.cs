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
        /*List
         *badges[0] - unlockDoor
         *badges[1] - changeBool
        */
        Achievements.Instance.achievements["unlockDoor"] = false;
        if (!Achievements.Instance.achievements["unlockDoor"])
        {
            AlterAlpha(false, badges[0]);
            Debug.Log("Here");
        }
        else
        {
            AlterAlpha(true, badges[0]);
        }
    }

    // Update is called once per frame
    void Update()
    {

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
            half.a = 0.5f;
            imageToChange.color = half;
        }
    }
}
