using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    private CapsuleCollider capsuleCollider;
    guessManager GuessScript;
    answerCheck answer;
   // randSpawnManager answerKey;
   // GameObject score;

    //public int identity;
    private void Start()
    {
         GuessScript = GameObject.Find("guesslog").GetComponent<guessManager>();
        answer = GameObject.Find("score").GetComponent<answerCheck>();
       
        //answerKey = GameObject.Find("SpawnerRandom").GetComponent<randSpawnManager>();

    }



    


    void OnMouseDown()
    {

       
        GuessScript.guess[GuessScript.count] = gameObject;
        GuessScript.count++;
        answer.GradeAnswer();
       

    }
}
