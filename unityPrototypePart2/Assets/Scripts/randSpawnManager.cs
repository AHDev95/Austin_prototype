using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randSpawnManager : MonoBehaviour
{
     GameObject[] spawnPoints;
    [SerializeField]
    GameObject[] objectPreFab;
   public GameObject[] recipe; 

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoints");
        foreach (GameObject spawn in spawnPoints)
        {
            GameObject spawnObj = Instantiate (objectPreFab[UnityEngine.Random.Range(0,6)], spawn.transform, false);
            
            for (int i = 0; i>=3; i = i++)
            {
                recipe[i] = spawnObj;
                
            }
            print(recipe);


                
        }
    }

   
}
