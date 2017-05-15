using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour {

    // Use this for initialization 
    public GameObject explosion;
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
        }
	
	// Update is called once per frame
	void Update () {
		
	}
}
