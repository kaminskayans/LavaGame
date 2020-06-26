using UnityEngine;
using UnityEngine.UI;

public class BulletMenu : MonoBehaviour {
    [SerializeField]
    private Text bulletName;
    [SerializeField]
    private Image icon;
    [SerializeField]
    private Text attackDamage;
    [SerializeField]
    BulletController bulletController;
    [SerializeField]
    GameObject enemy;
    GameObject nowEnemy;

    public void UpdateDisplayUI(BulletData bulletData) {
        bulletName.text = bulletData.BulletName;
        icon.sprite = bulletData.Icon;
        attackDamage.text = bulletData.AttackDamage.ToString();
        bulletController.attackForce = bulletData.AttackDamage;
    }

    private void Start() {
        StartGame();

    }
    public void RestartGame() {
        Destroy(nowEnemy);
        StartGame();

    }
    void StartGame() {
        nowEnemy = GameObject.Instantiate(enemy);
        bulletController.enemy = nowEnemy.GetComponent<RagdollController>();
        Time.timeScale = 1;
    }
}