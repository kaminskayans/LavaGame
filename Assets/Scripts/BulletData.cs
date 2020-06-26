using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BulletData", menuName = "Bullet Data", order = 51)]
public class BulletData : ScriptableObject {
    [SerializeField]
    private string bulletName;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int attackDamage;

    public string BulletName {
        get {
            return bulletName;
        }
    }

    public Sprite Icon {
        get {
            return icon;
        }
    }

    public int AttackDamage {
        get {
            return attackDamage;
        }
    }
}
