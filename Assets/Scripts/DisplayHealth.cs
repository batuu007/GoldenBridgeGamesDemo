using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    Text healthText;
    private void Start()
    {
        healthText = GetComponent<Text>();
    }
    private void Update()
    {
        healthText.text = Player.instance.GetHealth().ToString();
    }
}
