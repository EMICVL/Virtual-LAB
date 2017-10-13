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
    void OnCollisionStay(Collision col)
    {
        Debug.Log("OnCollisionEnter:" + col.collider.name + " | " + col.gameObject.name);
        if (col.gameObject.name== "First Flask")
        {
            //Debug.LogError("OnCollisionEnter");
            ActionManager.Bool_0 = true;
            ActionManager.contents[0].image = ActionManager.Instance.BoxTextureCompleted;
        }

    }
}
