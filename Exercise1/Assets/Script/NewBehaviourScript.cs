using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int level;
    string CurrentScreen = "MainMenu";
    string password;
    string[] Password1 = { "unity", "covid", "game", "code" };
    string[] Password2 = { "horrible", "vaccine", "communication", "operatint" };
    void Start()
    {
        showMainMenu("let's Start");
    }

    void showMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Press 1 for First level");
        Terminal.WriteLine("Press 2 for Second level");
    }

    void setLevel(string selectedLevel)
    {
        if (selectedLevel == "1")
        {
            level = 1;

            StartGame();
        }
        else if (selectedLevel == "2")
        {
            level = 2;
            StartGame();

        }
        else
            Terminal.WriteLine("inccorect,try again");



    }

    void OnUserInput(string input)
    {
        print("You Wrote " + input);
        if (input == "menu")
        {
            showMainMenu("Welcome again");
            CurrentScreen = "MainMenu";
        }
        else if (CurrentScreen == "MainMenu")
        {
            setLevel(input);
        }
        else if (CurrentScreen == "Password")
        {
            CheckPassword(input);
        }
        

    }

    void CheckPassword(string input)
    {
        if (input == password){
            Terminal.WriteLine("You Win!");
        }
        else
            Terminal.WriteLine("Wrong  , Re-enter again ");
    }

    void StartGame()
    {
       
        CurrentScreen = "Password";
        Terminal.WriteLine("You choose level " + level);
        switch (level)
        {
            case 1:
                password = Password1[Random.Range(0, Password1.Length)];
              
                break;
            case 2:
                password = Password2[Random.Range(0, Password2.Length)];
              
                break;
            default :
                break;
        }
        Terminal.WriteLine(password.Anagram());

    }
    void Update()
    {
        print(CurrentScreen);
    }
}
