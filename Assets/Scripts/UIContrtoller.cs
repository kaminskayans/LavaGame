using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIContrtoller : MonoBehaviour {
    [SerializeField] GameObject enemy;
    GameObject nowEnemy;
    [SerializeField] BulletController bulletController;

    private void Start() {
        StartGame();

    }
    public void RestartGame() {
        Destroy(nowEnemy);
        StartGame();
    }
    public void StartGame() {
        nowEnemy = GameObject.Instantiate(enemy);
        bulletController.enemy = nowEnemy.GetComponent<RagdollController>();
    }

    public void SetForce(int a) {
        bulletController.attackForce = a;
    }
}
