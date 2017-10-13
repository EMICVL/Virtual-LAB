using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstFlaskColliderManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        //Debug.Log("OnCollisionEnter:"+collision.gameObject.name);
        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    Debug.DrawRay(contact.point, contact.normal, Color.red);
        //}
    }
    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
    }
}
