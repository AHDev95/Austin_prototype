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
        

       if (answer.count == 3) 
        {
            for (int i = 0; i < answer.guess.Length; i++) {
                // Debug.Log("count is three");
                if (answer.guess[i].tag == answerKey.recipe[i].tag)  // == is checking if they are the same object in space
                {

                    if (answer.guess[2].tag == answerKey.recipe[2].tag)
                    {
                        Debug.Log("correct answer");
                        answerKey.recipe[i] = null;
                        //WaitForSeconds(2);
                        answerKey.spawnIn();
                        for (int a = 0; a < answer.guess.Length; a++)
                        {

                            answer.guess[a] = null;
                            answer.count = 0;


                             return;

                        }

                    }


                     else
                  {
                      Debug.Log("wrong answer");
                        answer.guess[0] = null;
                        answer.guess[1] = null;
                        answer.guess[2] = null;
                        answer.count = 0;

                        return;
                    }   





                   
                }   
                  
                    
            }
       
        
        
        
        }
                          

              
                           /*  */

    }

    

   //public void RollOver()
   // {
        
   // }








}
