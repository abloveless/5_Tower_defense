using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EnemyDamage : MonoBehaviour {

    [SerializeField] int hitPoints = 10;
    [SerializeField] ParticleSystem bulletFX;
    [SerializeField] Collider collisionMesh;
    // [SerializeField] public AudioClip projectileImpactSFX;

    // AudioSource audioSource;
   
    // Use this for initialization
    void Start ()
    {
       // audioSource = GetComponent<AudioSource>();
    }

    

    void OnParticleCollision(GameObject other)
    {
       // audioSource.Stop();
       // audioSource.PlayOneShot(projectileImpactSFX);
        ProcessHit();
        if (hitPoints <= 0)
        {
            KillEnemy();
        }
    }

    
    private void ProcessHit()
    {
        hitPoints = hitPoints - 1;
        bulletFX.Play();
        
        // todo consider hit FX
    }

    private void KillEnemy()
    {
        print("Destroying");
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
