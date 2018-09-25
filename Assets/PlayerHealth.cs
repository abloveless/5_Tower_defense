using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField] int playerHealth = 5;
    [SerializeField] Text healthText;
    [SerializeField] AudioClip baseDamageSFX;

    private void Start()
    {
        healthText.text = playerHealth.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(baseDamageSFX);
        ProcessHit();
    }

    private void ProcessHit()
    {
        playerHealth = playerHealth - 1;
        healthText.text = playerHealth.ToString();
    }
}
