using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class uiManager : MonoBehaviour
{
    //Hint Screen
    public GameObject hintScreen, hintScreenButton, victoryScreen;

    //Spellbook
    public GameObject spellBook, spellBookButton;
    public TMP_Text spellDescription;
    private float defaultTextSize = 15.0f;
    private float introTextSize = 25.0f;

    //Badges
    public GameObject badgesScreen, badgesButton;
    public BadgeManager badgeManager;

    //Unlocked Badges
    public TMP_Text unlockedBadges;
    private int unlockedBadgeNumber;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        unlockedBadgeNumber = Achievements.Instance.ReturnUnlockedBadgeNumber();
        unlockedBadges.text = "Unlocked Badges: " + unlockedBadgeNumber.ToString() + "/" + Achievements.Instance.achievements.Count.ToString();
        Debug.Log(unlockedBadgeNumber);
    }

    //Badges
    public void BadgesScreenOpen()
    {
        Audio.Instance.PlaySFX("Click");
        badgeManager.UpdateBadgeState();
        badgesScreen.SetActive(true);
        badgesButton.SetActive(false);
    }

    public void BadgesScreenClose()
    {
        Audio.Instance.PlaySFX("Click");
        badgesScreen.SetActive(false);
        badgesButton.SetActive(true);
    }

    //Hint Screen
    public void HintScreenOpen()
    {
        Audio.Instance.PlaySFX("Click");
        hintScreen.SetActive(true);
        hintScreenButton.SetActive(false);
    }

    public void HintScreenClose()
    {
        Audio.Instance.PlaySFX("Click");
        hintScreen.SetActive(false);
        hintScreenButton.SetActive(true);
    }

    public void VictoryScreenClose()
    {
        Audio.Instance.PlaySFX("Click");
        victoryScreen.SetActive(false);
    }

    //SpellBook
    public void OnIfStatement()
    {
        Audio.Instance.PlaySFX("Click");
        spellDescription.fontSize = defaultTextSize;
        spellDescription.text = "An <color=purple>if</color> statement runs a certain piece of code <b>dependent on <color=purple>if</color> the condition defined within the brackets is true or false</b>. <color=purple>If</color> the condition is true then the code underneath the true statement "
        + "within the parenthesis will be run otherwise <b>more conditions can be checked</b> using an '<color=purple>else if</color>' or in the case where you want to check that all other statements were false you can use an <color=purple>else</color>. An <color=purple>if</color> statement <b>can be used to check one </b>"
        + "<b>condition or multiple conditions.</b>"
        + "\n\nHere is an example of an if statement:\n<color=#000080ff>int</color> i = 1\n<color=#000080ff>string</color> name = \"noName\""
        + "\n<color=purple>if</color> (i == 0) {\n    name = \"Steve\"\n}\n<color=purple>else if</color> (i == 1) {\n    name = \"Bob\"\n}\n<color=purple>else</color> {\n    name = \"Dave\"\n}" +
          "\n\nResult:\nThe name variable will be \"Bob\" since the statement which satisfies the if condition is the second if statement which is checking whether i is equal to 1 which it is.";
    }

    public void OnWhileStatement()
    {
        Audio.Instance.PlaySFX("Click");
        spellDescription.fontSize = defaultTextSize;
        spellDescription.text = "A <color=purple>while</color> loop <b>will continuosly run a piece of code <color=purple>while</color> the defined condition is true.</b> To avoid the loop being infinite there <b>should be a way to meet the condition</b> of the <color=purple>while</color> loop so "
            + "the loop can be exited and other code can execute afterwards.\n\nHere is an example of a while loop:\n"
            + "<color=#000080ff>int</color> i = 0\n<color=purple>while</color> (i < 4) {\n    i += 1\n}" +
            "\n\nResult:\ni will be equal to 4 since the condition inside of the while loop will only run when i is less than 4, and 4 is of course not less than 4.";
    }

    public void OnForStatement()
    {
        Audio.Instance.PlaySFX("Click");
        spellDescription.fontSize = defaultTextSize;
        spellDescription.text = "A <color=purple>for</color> loop <b>will run a piece of code <color=purple>for</color> a certain amount of times</b> defined in the loop condition hence the name <color=purple>for</color> loop. <color=purple>For</color> loops <b>can be used to iterate <color=purple>for</color> the number of elements</b> in a storage location or <color=purple>for</color> a set number of times"
            + "\n\nHere is an example of a for loop:\n<color=purple>for</color> (int i = 0; i < 4; i++) {\n    print(i)\n}" +
            "\n\nResult:\nThe for statement prints to the console the value of i per loop. The first loop will print 0, the second loop will print 1, the third loop will print 2 and the fourth loop will print 3, since i will be equal to 4 in the next iteration of the loop no value will be printed" +
            "since the code inside the for loop will only run when i is equal to 4. If the value of i were to be stored outside of the for loop and increased the value at the end of the for loop would be 4.";
    }

    public void OnVariableStatement()
    {
        Audio.Instance.PlaySFX("Click");
        spellDescription.fontSize = defaultTextSize;
        spellDescription.text = "A variable is <b>a storage container in memory for a specific type of data</b> defined by the user or assigned during runtime of a script. There are several types of variables but most languages have the following: \n" +
            "<color=#000080ff>int</color>: Stores whole numbers with no decimal points\n" +
            "<color=#000080ff>double</color> or <color=#000080ff>float</color> : Stores numbers with decimals\n" +
            "<color=#000080ff>char</color> : Stores a single character using quotation marks\n" +
            "<color=#000080ff>string</color> : Stores several characters or sentences using speech marks\n" +
            "<color=#000080ff>bool</color> : Stores a single bit (1 or 0) relating to the states true or false" +
            "\n\nHere are some examples of the mentioned variables:\n" +
            "<color=#000080ff>int</color> i = 0\n" +
            "<color=#000080ff>double</color> d = 0.0\n" +
            "<color=#000080ff>float</color> f = 0.0\n" +
            "<color=#000080ff>char</color> c = 'A'\n" +
            "<color=#000080ff>string</color> s = \"Hello World\" \n" +
            "<color=#000080ff>bool</color> b = false"
            + "\n\nThe (-=) symbol means that the value on right will be subtracted from the variable on the left and then the result will replace the value of the variable: so i -= 1 is the same as i = i - 1.The same is true for +=, /= and *=.";
    }

    public void OnFunctionStatement()
    {
        Audio.Instance.PlaySFX("Click");
        spellDescription.fontSize = defaultTextSize;
        spellDescription.text = "A <color=yellow>function</color> is <b>a pre-defined block of code that performs a certain task</b> based on the code inside of it. Functions <b>can also allow for values to be passed into them</b> which are called <b>parameters</b> or they can be left blank.\n\nFunctions <b>can </b>"
            + "<b>also return values</b> if specified or just simply run some lines of code. Functions <b>can be called by writing the name of the <color=yellow>function</color> and whilst passing in parameters</b> if they have been defined. Several functions are used in the game but their definitions "
            + "are hidden.\n\nHere is an example of a function: \n" 
            + "<color=#000080ff>void</color> <color=yellow>unlockDoor</color>(<color=#000080ff>Door</color> <color=grey>doorToUnlock</color>) {\n"
            + "    <color=grey>doorToUnlock</color>.locked = false\n"
            + "}" +
            "\n\nResult:\nThe function takes in a door class and then unlocks the door by changing its locked value to false.";
    }

    public void OnClassStatement()
    {
        Audio.Instance.PlaySFX("Click");
        spellDescription.fontSize = 13.0f;
        spellDescription.text = "A <color=#000080ff>class</color> is a user defined data type, it is used as a container for <b>attributes</b> (variables) and <b>methods</b> (functions) that belong to it. Objects can be <b>created/instantiated</b> from a <color=#000080ff>class</color> and can also be referred to as instances, the process of <b>creating new objects is called instantiation.</b>"
            + " <b>Changes to variables on a specific object usually only change the values for that specific object and not the other objects created from the same class.</b>"
            + " Attributes and methods can be declared as <b>public</b> meaning they are visible outside of the <color=#000080ff>class</color> or <b>private</b> meaning they can only be accessed within the <color=#000080ff>class</color> - for simplicity <b>all classes in the game are public</b> by default but these are usually private unless declared as public."
            + " <b>Classes are a corner stone of Object Orientated Programming</b>." +
            "\n\nObject Orientation Programming is made up of several key concepts:\n" +
            "<b>Abstraction</b>: Showing only important attributes and methods whilst hiding unnecessary ones using public, private and protected keywords.\n" +
            "<b>Encapsulation</b>: The process of bundling attributes and methods into a singular container (a class).\n" +
            "<b>Polymorphism</b>: Allows for multiple forms of the same object with similar yet independent attributes and methods.\n" +
            "<b>Inheritance</b>: Allows for child classes to be derived from parent classes to share attributes and methods from the parent class whilst implementing new ones in the child class.\n" +
            "\nHere is an example of a class:\n<color=#000080ff>class</color> Player {\n<color=#000080ff>    int</color> health = 10\n}";

       // , more information on OOP can be found at: https://www.geeksforgeeks.org/introduction-of-object-oriented-programming/";
    }

    public void OnReset()
    {
        spellDescription.fontSize = introTextSize;
        spellDescription.text = "<u>Choose a spell to learn more about it!</u>";
    }

    public void SpellBookClose()
    {
        Audio.Instance.PlaySFX("Click");
        spellBook.SetActive(false);
        spellBookButton.SetActive(true);
        OnReset();
    }

    public void SpellBookOpen()
    {
        Audio.Instance.PlaySFX("Click");
        spellBook.SetActive(true);
        spellBookButton.SetActive(false);
    }
}
