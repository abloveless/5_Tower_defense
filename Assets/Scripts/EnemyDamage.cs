using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

    [SerializeField] int hits = 10;
    [SerializeField] GameObject bulletFX;
    [SerializeField] Collider collisionMesh;

    // Use this for initialization
    void Start () {
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
        Instantiate(bulletFX, transform.position, Quaternion.identity);
        hits = hits - 1;
        // todo consider hit FX
    }

    // Update is called once per frame
    void Update () {
		
	}
}
