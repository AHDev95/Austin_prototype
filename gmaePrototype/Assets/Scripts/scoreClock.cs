using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreClock : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countDownText;
    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }

}
