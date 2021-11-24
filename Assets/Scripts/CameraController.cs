using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Animator animator;
    CountDownTimer timer;
    RoadController roadController;

    void Start()
    {
        animator = GetComponent<Animator>();
        timer = FindObjectOfType<CountDownTimer>();
        roadController = FindObjectOfType<RoadController>();
    }

    void Update()
    {
        if (timer.countDown < 30)
        {
            animator.Play("Main2Cam");
            roadController.roadSpeed = 15f;
        }
    }
}
