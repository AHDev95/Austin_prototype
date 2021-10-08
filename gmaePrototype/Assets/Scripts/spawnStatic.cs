using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnStatic : MonoBehaviour
{
    public GameObject prefab;    // This works
    // Start is called before the first frame update
    void Start()
    {

        spawnStat();
        

    }

    public void spawnStat()
    {

      Instantiate(prefab, transform);

    }
}
