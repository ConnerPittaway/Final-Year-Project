using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class uiManager : MonoBehaviour
{
    public TMP_Text spellDescription;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnIfStatement()
    {
     //   spellDescription.enableAutoSizing = true;
        spellDescription.text = "An <color=purple>if</color> statement runs a certain piece of code dependent on <color=purple>if</color> the condition defined within the brackets is true or false. <color=purple>If</color> the condition is true then the code underneath the true statement "
        + "within the parenthesis will be run otherwise more conditions can be checked using an '<color=purple>else if</color>' or in the case where you want to check that all other statements were false you can use an <color=purple>else</color>. An <color=purple>if</color> statement can be used to check one "
        + "condition or multiple conditions."
        + "\n\nHere is an example:\n<color=#000080ff>int</color> i = 1\n<color=#000080ff>string</color> name = noName"
        + "\n<color=purple>if</color> (i == 0) {\n    name = Steve\n}\n<color=purple>else if</color> (i == 1) {\n    name = Bob\n}\n<color=purple>else</color> {\n    name = Dave\n}";
    }

    public void OnWhileStatement()
    {
       // spellDescription.enableAutoSizing = true;
        spellDescription.text = "A <color=purple>while</color> loop will continuosly run a piece of code <color=purple>while</color> the defined condition is true. To avoid the loop being infinite there should be a way to meet the condition of the <color=purple>while</color> loop so "
            + "the loop can be exited and other code can execute afterwards.";
    }

    public void OnForStatement()
    {
      //  spellDescription.enableAutoSizing = true;
        spellDescription.text = "A <color=purple>for</color> loop will run a piece of code <color=purple>for</color> a certain amount of times defined in the loop condition hence the name <color=purple>for</color> loop. <color=purple>For</color> loops can be used to iterate <color=purple>for</color> the number of elements in a storage location or <color=purple>for</color> a set number of times";
    }

    public void OnVariableStatement()
    {
     //  spellDescription.enableAutoSizing = true;
        spellDescription.text = "A variable is a container for data values defined by the user or assigned during runtime of a script. There are several types of variables but most languages have the following: \n" +
            "<color=#000080ff>int</color>: Stores whole numbers with no decimal points\n" +
            "<color=#000080ff>double</color> or <color=#000080ff>float</color> : Stores numbers with decimals\n" +
            "<color=#000080ff>char</color> : Stores a single character such as 'a', 'b' or 'c'\n" +
            "<color=#000080ff>string</color> : Stores several characters or sentences such as 'Hello World'\n" +
            "<color=#000080ff>bool</color> : Stores a single bit (1 or 0) relating to the states true or false";

    }

    public void OnFunctionStatement()
    {
       // spellDescription.enableAutoSizing = true;
        spellDescription.text = "A <color=yellow>function</color> is a pre-defined block of code that performs a certain task based on the code inside of it. Functions can also allow for values to be passed into them which are called parameters or they can be left blank. Functions can "
            + "also return values if specified or just simply run some lines of code. Functions can be called by writing the name of the <color=yellow>function</color> and whilst passing in parameters if they have been defined. Several functions are used in the game but their definitions "
            + "are hidden.\n\nHere is an example: \n" 
            + "<color=#000080ff>void</color> <color=yellow>unlockDoor</color>(<color=grey>doorToUnlock</color>) {\n"
            + "    <color=grey>doorToUnlock</color>.locked = false\n"
            + "}";
    }

    public void OnClassStatement()
    {
        // spellDescription.enableAutoSizing = true;
        spellDescription.text = "A <color=#000080ff>class</color> is a user defined data type, it is used as a container for attributes (variables) and methods (functions) that belong to it. Objects can be created from <color=#000080ff>class</color> and can also be referred to as instances. Attributes and methods "
            + "can be publically declared meaning they are visible outside of the <color=#000080ff>class</color> or private meaning they can only be accessed within the <color=#000080ff>class</color> - for simplicity all classes in the game are public by default but these are usually private unless declared as public."
            + " Classes are a corner stone of Object Orientated Programming.\n\nHere is an example:\n<color=#000080ff>class</color> Player {\n<color=#000080ff>    int</color> health = 10\n}";

       // , more information on OOP can be found at: https://www.geeksforgeeks.org/introduction-of-object-oriented-programming/";
    }

    public void OnReset()
    {
        // spellDescription.enableAutoSizing = true;
        spellDescription.text = "Choose a spell to learn more about it!";
    }
}
