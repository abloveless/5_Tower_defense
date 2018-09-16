using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

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
        //ProcessHit();
        //if (hits <= 0)
        //{
        //    KillEnemy();
        //}
    }

    // Update is called once per frame
    void Update () {
		
	}
}
