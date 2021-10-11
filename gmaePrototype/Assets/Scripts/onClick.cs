using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    
    guessManager GuessScript;
    answerCheck answer;
   

    private void Start()
    {                   // calling the scripts used for the OnMouseDown method
         GuessScript = GameObject.Find("guesslog").GetComponent<guessManager>();
        answer = GameObject.Find("checkAnswer").GetComponent<answerCheck>();
       
       

    }



    


    void OnMouseDown()
    {

       
        GuessScript.guess[GuessScript.count] = gameObject;
        GuessScript.count++;//adding to recorded number of objects in the guess script
        answer.GradeAnswer();// calling the GradeAnswer method in the answercheck script
       

    }
}
