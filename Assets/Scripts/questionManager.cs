using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class questionManager : MonoBehaviour
{
    public GameObject q1, q2, q3, q4, q5, q6, q7, q8, q9, q10;
    public List<TMP_Text> textFields;
    public List<TMP_InputField> inputs;
    public Button q10SubmitButton;
    public GameObject victoryScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Control Submit Colour
        if (textFields[0].text == "bool" &&
            textFields[1].text == "int" &&
            textFields[2].text == "string" &&
            textFields[3].text == "char" &&
            textFields[4].text == "float")
        {
            ColorBlock cb = q10SubmitButton.colors;
            cb.pressedColor = Color.green;
            cb.selectedColor = Color.green;
            q10SubmitButton.colors = cb;
        }
        else
        {
            ColorBlock cb = q10SubmitButton.colors;
            cb.pressedColor = Color.red;
            cb.selectedColor = Color.red;
            q10SubmitButton.colors = cb;
        }
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

    public void Question10Check()
    {
        // Text Fields
        /* [0] - isOpen
         * [1] - currentHealth
         * [2] - name 
         * [3] - letter
         * [4] - currentOpacity
        */

        //Input Fields
        /* [0] - quizFinished
        */
        if(textFields[0].text == "bool" &&
            textFields[1].text == "int" &&
            textFields[2].text == "string" &&
            textFields[3].text == "char" &&
            textFields[4].text == "float")
        {
            this.gameObject.SetActive(false);
            inputs[0].text = "true";
            victoryScreen.SetActive(true);
        }
        else
        {
            //Take Damage
        }
    }
    public void wrongAnswer()
    {
        //Minus health
    }
}
