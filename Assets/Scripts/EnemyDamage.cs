using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EnemyDamage : MonoBehaviour {

    [SerializeField] int hitPoints = 10;
    [SerializeField] ParticleSystem hitParticlesPrefab;
    [SerializeField] ParticleSystem deathParticlePrefab;
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
        hitParticlesPrefab.Play();
        
        // todo consider hit FX
    }

    private void KillEnemy()
    {
        // important to instantiate before object destroyed
        var vfx = Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);
        vfx.Play();


        Destroy(vfx.gameObject, vfx.main.duration);
        Destroy(gameObject); // the enemy
    }


    // Update is called once per frame
    void Update () {
		
	}
}
