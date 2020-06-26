using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private GameEvent OnSwordSelected; 

    private void OnMouseDown() {
        OnSwordSelected.Raise(); 
    }

}
