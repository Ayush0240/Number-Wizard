using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numwiz : MonoBehaviour
{
    int min, max, guess;
    // Start is called before the first frame update
    private void Start()
    {

        reStart();
    }
    void reStart()
    {
        min = 1;
        max = 1000;
        guess = 500;
        Debug.Log("Welcome to the game, Yoooaa");
        Debug.Log("The maximum number you can choose is : " + max);
        Debug.Log("The minimum number you can choose is : " + min);
        Debug.Log("Press the Up arrow if your number is greater than the guess and down arrow is smaller. Press enter when the correct answer is displayed");
        Debug.Log("Is Your guess smaller or bigger than : " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is smaller.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }



        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Your number is bigger.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("YO, got the right answer");
            reStart();

        }
     

    }
}
