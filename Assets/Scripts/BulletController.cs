using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    public RagdollController enemy;
    [SerializeField] Transform bullet;
    RaycastHit hit;
    bool isShoot;
    public int attackForce=5000;
    GameObject placeShoot;

    void Update() {
        if (Input.GetMouseButtonDown(0) &&
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit)) {

            if (hit.collider.CompareTag("Enemy")) {
                isShoot = true;
                placeShoot = hit.collider.gameObject;

                Vector3 shootDirection = bullet.position - hit.point;
                shootDirection.Normalize();

                enemy.EnablePhysics();
                placeShoot.GetComponent<Rigidbody>().AddForce(shootDirection * -attackForce);
            }
        }
    }
}

