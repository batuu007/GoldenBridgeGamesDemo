using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    private float scorePerSecond;

    private void Start()
    {
        scoreAmount = 0f;
        scorePerSecond = 5f;
    }
    private void Update()
    {
        scoreText.text = "" + (int)scoreAmount;
        scoreAmount += scorePerSecond * Time.deltaTime;
    }
}
