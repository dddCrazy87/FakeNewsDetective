using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBodyPieces : MonoBehaviour
{
    [SerializeField] private Backpack backpack;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            transform.parent = other.transform;
            backpack.isHavingDeadBodyPieces = true;
        }
    }
}
