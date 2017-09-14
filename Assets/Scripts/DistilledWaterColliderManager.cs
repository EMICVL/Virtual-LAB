using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistilledWaterColliderManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("OnCollisionEnter:" + col.collider.name + " | " + col.gameObject.name);
        if (col.gameObject.name== "First Flask")
        {
            Debug.LogError("OnCollisionEnter");
        }

    }
}
