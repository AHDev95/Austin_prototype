using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Linq;

public class answerCheck : MonoBehaviour
{
    guessManager answer;
    randSpawnManager answerKey;
    

    scoreBoard Score;  

    private void Start()
    {
       answer = GameObject.Find("guesslog").GetComponent<guessManager>();   // calling all the required scripts for the GradeAnswer method
       answerKey = GameObject.Find("SpawnerRandom").GetComponent<randSpawnManager>();
        Score = GameObject.Find("score").GetComponent<scoreBoard>(); 

       
    }
    // Update is called once per frame
    public void GradeAnswer()
    {
        

       if (answer.count == 3) //when you have clicked 3 objects it will run the for loop
        {
           
                    if (answer.guess[0].tag == answerKey.recipe[0].tag)//the tag of item 0 of the guess array is == the tag of item 0 of the recipe arrray
                    {
                        Debug.Log(" 000 correct answer");
                       Destroy(answerKey.recipe[0]); // destroys the object in the 0 posion of the recipe array
                   
                            answer.guess[0] = null; //clears the 0 posion of the guess array
                     
                    }
                  else //if first objects dont match 
                  {
                      Debug.Log(" 000 wrong answer");
                        answer.guess[0] = null;
                        answer.guess[1] = null; //clear the guess array
                        answer.guess[2] = null;
                        answer.count = 0;   //reset the number of objects in the guess array
                        Destroy(answerKey.recipe[0]);
                        Destroy(answerKey.recipe[1]);//destroy the random objects, and spawn in new ones to try again
                        Destroy(answerKey.recipe[2]);
                        answerKey.spawnIn();
                        return; //start all over again
                    }
                  
                    //checking array item 1        does the same as the first if else loop just moving further down the arrays
                     if (answer.guess[1].tag == answerKey.recipe[1].tag)//the tag of item 1 of the guess array is == the tag of item 1 of  the recipe arrray 
                    {
                         Debug.Log(" 001 correct answer");
                        Destroy(answerKey.recipe[1]);
                      
                            answer.guess[1] = null;
                       

                     }
                     else
                     {
                         Debug.Log(" 001 wrong answer");
                         answer.guess[0] = null;
                        answer.guess[1] = null;
                        answer.guess[2] = null;
                        answer.count = 0;
                        
                        Destroy(answerKey.recipe[1]);
                        Destroy(answerKey.recipe[2]);
                        answerKey.spawnIn();
                        return;
                    }


            //checking array item 2      does the same as the first if else loop just moving further down the arrays
                     if (answer.guess[2].tag == answerKey.recipe[2].tag)//the tag of item 2 of the guess array is == the tag of item 2 of  the recipe arrray 
                    {
                         Debug.Log(" 002 correct answer");
                        Destroy(answerKey.recipe[2]);
                        Score.ScoreBoard(); //calls the scoreboard method to add to the score

                       
                        answerKey.spawnIn();
                         
                            answer.guess[2] = null;
                              answer.count = 0;

                            return;

                        

                     }
                     else
                     {
                         Debug.Log("002 wrong answer");
                         answer.guess[0] = null;
                        answer.guess[1] = null;
                        answer.guess[2] = null;
                        answer.count = 0;
                       
                        Destroy(answerKey.recipe[2]);
                        answerKey.spawnIn();
                        return;
                    }   /**/

                    
           
       
        
        
        
        }
                          

              
                          
    }


}
