using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_KP : MonoBehaviour
{
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            dialog.nowNPC = "KP";
            dialogScript.ShowDialog();
        }
    }
}
