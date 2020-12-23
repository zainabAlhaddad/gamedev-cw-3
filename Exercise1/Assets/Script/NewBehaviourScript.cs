using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int level;
    string CurrentScreen = "Main Menu";

    void Start()
    {
        showMainMenu("let's Start");
    }

    void showMainMenu(string greeting)
    {
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Press 1 for Firs level");
        Terminal.WriteLine("Press 2 for Second level");
    }

    void setLevel( String selectedLevel)
    {
        if (selectedLevel == "1")
        {
            level = 1;
        }
        if else (selectedLevel == "2"){
            level = 2;

        }

    }

    void OnUsereInput(string input)
    {
        if (CurrentScreen=="Main Menu ")
        {
            setLevel(input);
        }


    }
}
