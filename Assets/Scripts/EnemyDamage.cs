using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

    [SerializeField] int hitPoints = 10;
    [SerializeField] GameObject bulletFX;
    [SerializeField] Collider collisionMesh;

    // Use this for initialization
    void Start () {
	}

    

    void OnParticleCollision(GameObject other)
    {
        print("Bullets hit something");
        ProcessHit();
        if (hitPoints <= 0)
        {
            KillEnemy();
        }
    }

    
    private void ProcessHit()
    {
        Instantiate(bulletFX, transform.position, Quaternion.identity);
        hitPoints = hitPoints - 1;
        // todo consider hit FX
    }

    private void KillEnemy()
    {
        print("Enemy dead");
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
