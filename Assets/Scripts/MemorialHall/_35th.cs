using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _35th : MonoBehaviour
{
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;
    [SerializeField] private GameObject DeadBodyPieces;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            if(instructionAndMission.instructionID == 12) {
                dialog.nowNPC = "MainSelf6";
                dialogScript.ShowDialog();
            }
        }
    }

    private void FixedUpdate() {
        if(instructionAndMission.instructionID == 13) {
            DeadBodyPieces.SetActive(true);
        }
    }
}
