using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    private CapsuleCollider capsuleCollider;

    GameObject[] guess;
    //public int identity;
    private void Awake()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
    }
/*
    void OnMouseDown()
    {
        foreach (GameObject)
        {
         
        }
       // capsuleCollider.CompareTag();

    }

      // Update when mouse hovers over
      void OnMouseOver()
      {
          if (Input.GetMouseButtonDown(0))
          {
            
          }
      }*/
}
