using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthylAlchoholColliderController : MonoBehaviour {

    // Use this for initialization
    void OnCollisionStay(Collision col)
    {
        Debug.Log("OnCollisionEnter:" + col.collider.name + " | " + col.gameObject.name);
        if (col.gameObject.name == "First Glass")
        {
            //Debug.LogError("OnCollisionEnter");
            ActionManager.Bool_4 = true;
            ActionManager.contents[4].image = ActionManager.Instance.BoxTextureCompleted;
        }
    }
}
