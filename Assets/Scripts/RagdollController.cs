using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour {
    public List<Rigidbody> ragdollElements;
    private void Start() {
        DisablePhysics();
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            EnablePhysics();
    }

    public void EnablePhysics() {
        for (int i = 0; i < ragdollElements.Count; i++) {
            ragdollElements[i].isKinematic = false;
        }
    }

    public void DisablePhysics() {
        for (int i = 0; i < ragdollElements.Count; i++) {
            ragdollElements[i].isKinematic = true;
        }
    }
}