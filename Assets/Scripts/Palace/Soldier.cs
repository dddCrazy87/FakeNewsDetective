using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour
{
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;
    [SerializeField] private InstructionAndMission instructionAndMission;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            if(instructionAndMission.instructionID == 7) {
                dialog.nowNPC = "Soldier1";
            }
            else{
                dialog.nowNPC = "Soldier2";
            }
            dialogScript.ShowDialog();
        }
    }
}
