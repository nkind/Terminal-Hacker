using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game config data
    string[] _easy = { "java", "mocha", "latte", "coffee", "beans" };
    string[] _medium = { "grade", "teach", "learn", "finals", "educate" };
    string[] _hard = { "arrivals", "delay", "take-off", "security", "landing" };


    // Game state
    int _level;
    enum Screen { MainMenu, Password, Win};
    Screen _currentScreen;
    string _password;
 


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
        bool isValidLevel = (input == "1" || input == "2");
        if (isValidLevel)
        {
            _level = int.Parse(input);
            StartGame();
        }
        else if (input == "beans") // easter egg
        {
            Terminal.WriteLine("How dare you...");
        }
        else
        {
            Terminal.WriteLine("Invalid input!");
        }
    }

    void StartGame()
    {
        _currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch (_level)
        {
            case 1:
                _password = _easy[Random.Range(0, _easy.Length)];
                break;
            case 2:
                _password = _medium[Random.Range(0, _medium.Length)];
                break;
            case 3:
                _password = _hard[Random.Range(0, _hard.Length)];
                break;
            default:
                Debug.LogError("Invalid input");
                break;
        }
        Terminal.WriteLine("Enter your password: ");
    }

    void RunGame(string input)
    {
        
        if (input == _password)
        {
            WinScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong password! Step it up!");
        }
    }

    void WinScreen()
    {
        _currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (_level)
        {
            case 1:
                Terminal.WriteLine("mmm... digital coffee");
                Terminal.WriteLine(@"
       ))
      ((
    c[__]
"
                );
                break;
            case 2:
                Terminal.WriteLine("You hacked your way to a degree!");
                Terminal.WriteLine(@"
    __________
   / ------- /
  / ------- /
 / ------- /
/_________/
"
                );
                break;
            default:
                Debug.LogError("Invalid State");
                break;
        }
    }
}
