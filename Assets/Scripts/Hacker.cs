using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    void Start()
    {
        ShowMainMenu();
        
    }

    void ShowMainMenu()
    {
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
        if (input == "menu")
        {
            Terminal.ClearScreen();
            ShowMainMenu();
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

}
