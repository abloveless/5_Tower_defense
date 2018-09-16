using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] int hits = 10;
    [SerializeField] GameObject bulletFX;

    // Use this for initialization
    void Start () {
        AddBoxCollider();
	}

    private void AddBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>(); // generate Box Collider
        boxCollider.isTrigger = false; // set box collider trigger to false
    }

    void OnParticleCollision(GameObject other)
    {
        print("Bullets hit something");
        ProcessHit();
        if (hits <= 0)
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        print("Enemy dead");
        Destroy(gameObject);
    }

    private void ProcessHit()
    {
        hits = hits - 1;
        // todo consider hit FX
    }

    // Update is called once per frame
    void Update () {
		
	}
}
