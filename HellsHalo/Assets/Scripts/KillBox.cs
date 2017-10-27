using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour {

    void onTriggerExit (Collider other) {
        Destroy(other.gameObject.transform.parent.gameObject);
    }


}
