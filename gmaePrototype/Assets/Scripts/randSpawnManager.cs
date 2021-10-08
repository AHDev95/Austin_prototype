using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randSpawnManager : MonoBehaviour
{
    GameObject[] spawnPoints;
    [SerializeField]
    GameObject[] objectPreFab;
    public GameObject[] recipe;
    //public int identity;
    // Start is called before the first frame update
    void Start()
    {
        spawnIn();

      }       


    public void spawnIn()
    {

        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoints");
        for (int a = 0; a < spawnPoints.Length; a++)
        {
            GameObject spawnObj = Instantiate(objectPreFab[UnityEngine.Random.Range(0, 6)], spawnPoints[a].transform, false);

            recipe[a] = spawnObj;
        }








    }

    
}
