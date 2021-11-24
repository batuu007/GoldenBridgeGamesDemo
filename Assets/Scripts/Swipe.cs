using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    public static Swipe Instance { set; get; }

    [HideInInspector]
    public bool tap, swipeLeft, swipeRight;
    [HideInInspector]
    public Vector2 swipeDelta, startTouch;
    private const float deadZone = 125;
    private bool isDraging = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        // reset all controls
        tap = swipeLeft = swipeRight = false;

        //Input

        #region Pc Control
        if (Input.GetMouseButtonDown(0))
        {
            isDraging = true;
            tap = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDraging = false;
            startTouch = swipeDelta = Vector2.zero;
        }

        #endregion

        #region Mobil Control
        if (Input.touches.Length != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                startTouch = Input.mousePosition;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                startTouch = swipeDelta = Vector2.zero;
            }

        }

        #endregion
        // we calculate the distance 

        swipeDelta = Vector2.zero;
        if (isDraging)
        {
            // For Mobil
            if (Input.touches.Length != 0)
            {
                swipeDelta = Input.touches[0].position - startTouch;
            }
            // For Pc
            else if (Input.GetMouseButton(0))
            {
                swipeDelta = (Vector2)Input.mousePosition - startTouch;

            }
        }

        //  Have we passed the deadzone? 
        if (swipeDelta.magnitude > deadZone)
        {
            // we passed 
            float x = swipeDelta.x;
            float y = swipeDelta.y;

            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                //left or right 
                if (x < 0)
                {
                    // left
                    swipeLeft = true;
                }
                else
                {
                    // right
                    swipeRight = true;
                }
            }
            startTouch = swipeDelta = Vector2.zero;
            isDraging = false;
        }
    }
}
