using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    private CapsuleCollider capsuleCollider;

    GameObject[] guess;
    GameObject[] selected;
    //public int identity;
    private void Awake()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    void OnMouseDown()
    {
        guess = GameObject.FindGameObjectsWithTag("staticSpawn");
        for (int i = 0; i < guess.Length; i++)
        {
            //GameObject clicked = get
           // selected[i] = 
        }
       // capsuleCollider.CompareTag();

    }

    /*  // Update when mouse hovers over
      void OnMouseOver()
      {
          if (Input.GetMouseButtonDown(0))
          {
            
          }
      }*/
}
