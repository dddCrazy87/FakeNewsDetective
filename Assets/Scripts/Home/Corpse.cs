using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corpse : MonoBehaviour
{
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private Dialog dialog;
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private GameObject DeadBody, DeadBodyPieces;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            if(instructionAndMission.instructionID == 11) {
                dialog.nowNPC = "MainSelf5";
                dialogScript.ShowDialog();
            }
            if(instructionAndMission.instructionID == 13) {
                dialog.nowNPC = "MainSelf7";
                dialogScript.ShowDialog();
            }
        }
    }

    private void Update() {
        if(dialogScript.showDeadBody) {
            DeadBody.SetActive(true);
        }
        if(dialogScript.showDeadBodyPieces) {
            DeadBodyPieces.SetActive(true);
        }
    }
}
