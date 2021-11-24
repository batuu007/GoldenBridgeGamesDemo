using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public float scorePerSecond=5f;
    public float countDown;
    public Text timer;

    private void Start()
    {
        timer.text = "" + (int)countDown;
    }
    private void Update()
    {
        countDown -= Time.deltaTime;
        timer.text = "" + (int)countDown;
    }
}
