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
                if (answer.guess[i].name == answerKey.recipe[i].name)  // == is checking if they are the same object in space
                {        
                    
                    if (answer.guess[2].name == answerKey.recipe[2].name) 
                    {
                         Debug.Log("correct answer");
                         answerKey.spawnIn();
                        
                    //answer.clearArray();
                   /* for ( int a = 0; a < answer.guess.Length; a++ )
                    {
                             
                            answer.guess[a] = null;
                            answer.count = 0;
                    }*/


                    }
                  }   
                  
                  else
                  {
                      Debug.Log("wrong answer");

                  }      
            }
        }

    }
}
