using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int playerHealth = 1;
    public static Player instance;
    CountDownTimer timer;
    Level level;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        timer = FindObjectOfType<CountDownTimer>();
        level = FindObjectOfType<Level>();
    }
    private void Update()
    {
        Win();
    }

    private void Win()
    {
        if (timer.countDown <= 0)
        {
            level.LoadGameWin();
        }
    }

    public void LimoCrash()
    {
        if (playerHealth > 0)
        {
            playerHealth--;
        }
        else
        {
            this.gameObject.SetActive(false);
            level.LoadGameLoss();
        }
    }
    public int GetHealth()
    {
        return playerHealth;
    }
}
