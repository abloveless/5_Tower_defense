using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] int playerHealth = 5;
    [SerializeField] Text healthText;

    private void Start()
    {
        healthText.text = playerHealth.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        playerHealth = playerHealth - 1;
        healthText.text = playerHealth.ToString();
    }
}
