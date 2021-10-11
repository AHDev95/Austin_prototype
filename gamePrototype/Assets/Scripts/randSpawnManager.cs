using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randSpawnManager : MonoBehaviour
{
    GameObject[] spawnPoints; // array of the spawn points for the random objects
    [SerializeField]
    GameObject[] objectPreFab; // array that the random objects are chosen from
    public GameObject[] recipe; // array of the randomly spawned objects
    
    void Start()
    {
        spawnIn(); // calling the spawn method for the random objects at the start of the game

      }       


    public void spawnIn() // random spawn method
    {

        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoints"); // finding the spawn points by their tag
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            GameObject spawnObj = Instantiate(objectPreFab[UnityEngine.Random.Range(0, 6)], spawnPoints[i].transform, false); // instantiating (spawning)the random objects

            recipe[i] = spawnObj; //filling an array with the random objects to be compaired to the select object later
        }


    }

    
}
