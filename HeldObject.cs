using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is added to everything you want to be holdable

[RequireComponent(typeof(Rigidbody))]
public class HeldObject : MonoBehaviour {

    // Tells the held object which input device it is being held by (ie which controller)
    [HideInInspector]
    public Controller parent;
}
