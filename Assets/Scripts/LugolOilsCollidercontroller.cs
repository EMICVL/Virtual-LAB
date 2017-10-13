using UnityEngine;

public class LugolOilsCollidercontroller : MonoBehaviour {

    // Use this for initialization
    void OnCollisionStay(Collision col)
    {
        Debug.Log("OnCollisionEnter:" + col.collider.name + " | " + col.gameObject.name);
        if (col.gameObject.name == "First Glass")
        {
            //Debug.LogError("OnCollisionEnter");
            ActionManager.Bool_3 = true;
            ActionManager.contents[3].image = ActionManager.Instance.BoxTextureCompleted;
        }
    }
}
