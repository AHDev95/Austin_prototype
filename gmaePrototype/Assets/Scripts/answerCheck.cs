using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Linq;

public class answerCheck : MonoBehaviour
{
    guessManager answer;
    randSpawnManager answerKey;
    GameObject score;
  
       

    private void Start()
    {
       answer = GameObject.Find("guesslog").GetComponent<guessManager>();
       answerKey = GameObject.Find("SpawnerRandom").GetComponent<randSpawnManager>();

    }
    // Update is called once per frame
    public void GradeAnswer()
    {
        

       if (answer.count == 3) //when you have click 3 objects it will run the for loop
        {
           
                    if (answer.guess[0].tag == answerKey.recipe[0].tag)//the tag of item 0 of the guess array is == the tag of item 0 of the recipe arrray
                    {
                        Debug.Log(" 000 correct answer");
                       Destroy(answerKey.recipe[0]);
                   
                            answer.guess[0] = null;
                     
                    }
                  else
                  {
                      Debug.Log(" 000 wrong answer");
                        answer.guess[0] = null;
                        answer.guess[1] = null;
                        answer.guess[2] = null;
                        answer.count = 0;
                        Destroy(answerKey.recipe[0]);
                        Destroy(answerKey.recipe[1]);
                        Destroy(answerKey.recipe[2]);
                        answerKey.spawnIn();
                        return;
                    }
                  
                    //checking array item 1
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


                     //checking array item 2
                     if (answer.guess[2].tag == answerKey.recipe[2].tag)//the tag of item 2 of the guess array is == the tag of item 2 of  the recipe arrray 
                    {
                         Debug.Log(" 002 correct answer");
                        Destroy(answerKey.recipe[2]);
                        
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
