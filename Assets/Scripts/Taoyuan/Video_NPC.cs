using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video_NPC : MonoBehaviour
{
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;
    [SerializeField] private InstructionAndMission instructionAndMission;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            if(instructionAndMission.instructionID == 4) {
                dialog.nowNPC = "VideoProfesser1";
            }
            else if(instructionAndMission.instructionID >= 6) {
                dialog.nowNPC = "VideoProfesser2";
            }
            else {
                return;
            }
            dialogScript.ShowDialog();
        }
    }
}
