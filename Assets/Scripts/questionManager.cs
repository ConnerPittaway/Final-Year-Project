using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionManager : MonoBehaviour
{
    public GameObject q1, q2, q3, q4, q5, q6, q7, q8, q9, q10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Question1Correct()
    {
        q1.SetActive(false);
        q2.SetActive(true);
    }

    public void Question2Correct()
    {
        q2.SetActive(false);
        q3.SetActive(true);
    }

    public void Question3Correct()
    {
        q3.SetActive(false);
        q4.SetActive(true);
    }

    public void Question4Correct()
    {
        q4.SetActive(false);
        q5.SetActive(true);
    }

    public void Question5Correct()
    {
        q5.SetActive(false);
        q6.SetActive(true);
    }

    public void Question6Correct()
    {
        q6.SetActive(false);
        q7.SetActive(true);
    }

    public void Question7Correct()
    {
        q7.SetActive(false);
        q8.SetActive(true);
    }

    public void Question8Correct()
    {
        q8.SetActive(false);
        q9.SetActive(true);
    }

    public void Question9Correct()
    {
        q9.SetActive(false);
        q10.SetActive(true);
    }

    public void Question10Correct()
    {
        q10.SetActive(false);
        //q10.SetActive(true);
    }
    public void wrongAnswer()
    {
        //Minus health
    }
}
