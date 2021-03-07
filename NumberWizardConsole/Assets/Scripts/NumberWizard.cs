using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int maxGuess = 1000;
    private int minGuess = 1;
    private int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
		{
            //Debug.Log("Up Arrow key was pressed.");
            minGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //Debug.Log("Down Arrow key was pressed.");
            maxGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("Return (Enter) key was pressed.");
            Debug.Log("Your number is " + guess);
            StartGame();
        }
    }

    void StartGame()
	{
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;

        Debug.Log("Welcome to Aritma, the Number Wizard's, tower!");
        Debug.Log("She bekons that you pick a number so that she may guess at it.");

        Debug.Log("The highest number is: " + maxGuess);
        Debug.Log("The lowest number is: " + minGuess);
        Debug.Log("My Guess is " + guess);

        Debug.Log("Is you number higher or lower than my guess?");
        Debug.Log("Push Up for Higher, Push Down for Lower, Push Enter for Equal.");
        if (maxGuess % 2 == 0)
        {
            maxGuess += 1;
        }
    }

    private void NextGuess()
	{
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("My Guess is " + guess);
        Debug.Log("Is you number higher or lower than my guess?");
    }
}
