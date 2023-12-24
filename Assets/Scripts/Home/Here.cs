using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Here : MonoBehaviour
{
    [SerializeField] private GameObject DeadBody, DeadBodyPieces;
    [SerializeField] private Backpack backpack;
    private void FixedUpdate() {
        if(backpack.isHavingDeadBodyPieces) {
            DeadBodyPieces.SetActive(true);
        }
        else {
            DeadBodyPieces.SetActive(false);
        }
        if(backpack.isHavingDeadBody) {
            DeadBody.SetActive(true);
        }
        else {
            DeadBody.SetActive(false);
        }
    }
}
