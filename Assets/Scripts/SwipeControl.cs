using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControl : MonoBehaviour
{
    public Swipe swipecontrols;
    public Transform player;
    private Vector3 desiredPos;
    public float speedOfDelay;
    private float locking = 9f;
    void Update()
    {
        Movement();   
    }
    private void Movement()
    {
        if (swipecontrols.swipeLeft)
        {
            desiredPos += Vector3.left;
        }
        if (swipecontrols.swipeRight)
        {
            desiredPos += Vector3.right;
        }

        player.transform.position =Vector3.ClampMagnitude( Vector3.MoveTowards(player.transform.position, desiredPos, speedOfDelay * Time.deltaTime),locking);
    }
}
