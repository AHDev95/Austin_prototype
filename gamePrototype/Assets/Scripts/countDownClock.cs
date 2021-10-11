using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class countDownClock : MonoBehaviour
{
    float currentTime = 0f; //as it says this represents the current time in the game
    float startingTime = 30f;//this is how much time you have in the game
    
    [SerializeField] Text countDownText;
    private void Start()
    {
        currentTime = startingTime; // this sets the current time to start at the startingtime value
       
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime; //the current time will count down by seconds instead of by frames
        countDownText.text = currentTime.ToString("0");//printing the count down to the Ui text

        if(currentTime <= 0)
        {
            currentTime = 0;//this if makes the count stop a 0 and not count down into the negative numbers
            
            
        }


        
    }

}
