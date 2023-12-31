using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tombstone : MonoBehaviour
{
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;
    [SerializeField] GameObject deadBody;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            if(instructionAndMission.instructionID == 9) {
                dialog.nowNPC = "MainSelf3";
                dialogScript.ShowDialog();
            }
            else if(instructionAndMission.instructionID == 10) {
                dialog.nowNPC = "MainSelf4";
                dialogScript.ShowDialog();
            }
        }
    }

    private void FixedUpdate() {
        if(dialogScript.showDeadBody) {
            deadBody.SetActive(true);
        }
    }
}
