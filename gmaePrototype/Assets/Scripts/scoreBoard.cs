using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreBoard : MonoBehaviour
{
    public Text score; //mane of the Ui text used for the score display
    
    public int scoreCount = 0;// int use to count the score
   
    void Start()
    {
        

        

        
    }

    public void ScoreBoard()
     {
         scoreCount++;//adding 1 to the score
        score.text = scoreCount.ToString("0");//printing the score to the Ui

        Debug.Log("score increased");
    }/**/
}