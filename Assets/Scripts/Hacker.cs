using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int _level;
    enum Screen { MainMenu, Password, Win};
    Screen _currentScreen;
    string _easy = "Java";
    string _medium = "Grades";


    void Start()
    {
        ShowMainMenu();
        
    }

    void ShowMainMenu()
    {
        _currentScreen = Screen.MainMenu;
        Terminal.WriteLine("Totally Accurate Hacking Simulation\n" +
            "---------------------------------------\n" +
            "Pick your poison:\n" +
            "\n1. Coffee Shop\n" +
            "2. School\n" +
            "3. Airport\n" +
            "\nEnter a number \n" +
            "(this is totally how hackers do it): ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // can always go direct to main menu 
        {
            ShowMainMenu();
        }
        else if (_currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (_currentScreen == Screen.Password)
        {
            RunGame(input);
        }

    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            _level = 1;
            _currentScreen = Screen.Password;
            Terminal.WriteLine("Enter Password: ");

        }
        else if (input == "2")
        {
            _level = 2;
            _currentScreen = Screen.Password;
            Terminal.WriteLine("Enter Password: ");
            
        }
        else if (input == "beans")
        {
            Terminal.WriteLine("How dare you...");
        }
        else
        {
            Terminal.WriteLine("Invalid input!");
        }
    }

    void RunGame(String input)
    {
        if (_level == 1)
        {
            if (input == _easy)
            {
                Terminal.WriteLine("You did a hack! The police are on their way...");
            }
            else
            {
                Terminal.WriteLine("Try again.");
            }
        }
        else if (_level == 2)
        {
            if (input == _medium)
            {
                Terminal.WriteLine("You did a hack! The police are on their way...");
            }
            else
            {
                Terminal.WriteLine("Try again.");
            }
        }
    }

   
}
