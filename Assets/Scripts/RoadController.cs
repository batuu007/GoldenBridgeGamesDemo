using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    GameObject[] road = new GameObject[6];

    public float roadSpeed=30f;

    // Start is called before the first frame update
    void Start()
    {
        road = GameObject.FindGameObjectsWithTag("Road");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject roads in road)
        {
            roads.transform.Translate(Vector3.back * 1f * roadSpeed * Time.deltaTime);
            if (roads.transform.position.z < -25f)
            {
                roads.transform.Translate(Vector3.forward * 275f);
            }
        }
    }
}
