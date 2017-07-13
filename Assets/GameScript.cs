using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour {

    int max = 0;
    int min = 0;
    int guess = 0;
    int startingmax = 10000;
    int startingmin = 1;

    public Text guesstext;
    public LevelManager levelManager;

    private void Start()
    {
        levelManager = GetComponent<LevelManager>();
        AskAgain(1);
    }

    void AskAgain(int restart)
    {
        if (restart == 1)
        {
            max = 10000;
            min = 1;
        }
        guess = Random.Range(min, max);
        guesstext.text = "So... My guess is... Ham... " + guess;
    }

    public void CheckGuess(int type)
    {
        //type = 1 (lower); type = 2 (higher); type = 3 (equals)
        if (type == 1)
        {
            max = guess - 1;
        }
        else if (type == 2)
        {
            min = guess + 1;
        }
        else if (type == 3)
        {
            ComputerWins(0);
        }
        CheckForErrors();
        AskAgain(0);
    }

    void ComputerWins(int type)
    {
        PlayerPrefs.SetInt("guess", guess);
        PlayerPrefs.Save();
        if (type == 1)
        {
            levelManager.LoadScene("Error");
        }
        else levelManager.LoadScene("Win");
    }

    void CheckForErrors()
    {
        Debug.Log("DEBUG: min:" + min + " max:" + max + " guess:" + guess);
        if (guess < startingmin)
        {
            Debug.Log("ERROR: guess < min...");
            guess = startingmin;
        }
        else if (guess > startingmax)
        {
            Debug.Log("ERROR: guess > max...");
            guess = startingmax;
        }
        else if (min == max || (min == guess && max == min - 1) || (max == guess && min == max + 1))
        {
            Debug.Log("ERROR: Out of range");
            ComputerWins(1);
        }
    }
}
