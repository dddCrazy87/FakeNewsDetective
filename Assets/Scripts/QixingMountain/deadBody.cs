using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadBody : MonoBehaviour
{
    [SerializeField] private Backpack backpack;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player") {
            transform.parent = other.transform;
            backpack.isHavingDeadBody = true;
        }
    }
}
