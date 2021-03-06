﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDamage : MonoBehaviour {

    [SerializeField] int hitPoints = 10;
    [SerializeField] ParticleSystem hitParticlesPrefab;
    [SerializeField] ParticleSystem deathParticlePrefab;
    [SerializeField] Collider collisionMesh;
    [SerializeField] AudioClip enemyDamageSFX;
    [SerializeField] AudioClip enemyDeathSFX;

    AudioSource myAudioSource; // use like this if using multiple audio clips

    // Use this for initialization
    void Start ()
    {
        myAudioSource = GetComponent<AudioSource>(); // use like this if using multiple audio clips
    }

    

    void OnParticleCollision(GameObject other)
    {

        ProcessHit();
        if (hitPoints <= 0)
        {
            KillEnemy();
        }
    }

    
    private void ProcessHit()
    {
        hitPoints = hitPoints - 1;
        myAudioSource.PlayOneShot(enemyDamageSFX);
        hitParticlesPrefab.Play();
    }

    private void KillEnemy()
    {
        // important to instantiate before object destroyed
        var vfx = Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);
        vfx.Play();
        Destroy(vfx.gameObject, vfx.main.duration);
        AudioSource.PlayClipAtPoint(enemyDeathSFX, Camera.main.transform.position); // using this so sound isn't destroyed with game object
        Destroy(gameObject); // the enemy
    }
}
