using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] int playerHealth = 5;

    private void OnTriggerEnter(Collider other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        playerHealth = playerHealth - 1;
    }
}
