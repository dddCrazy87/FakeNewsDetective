using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    [SerializeField] private GameObject monitorCanvas;
    [SerializeField] private GameObject[] monitorImgs;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            monitorCanvas.SetActive(true);
        }
    }

    private void FixedUpdate() {
        if(dialogScript.lv1Finished) {
            instructionAndMission.finshedMission[2] = true;
            if(instructionAndMission.instructionID == 2) {
                instructionAndMission.instructionID = 3;
            }
            instructionAndMission.gameLvId = 2;
        }
    }

    private int picID = 0;
    public void nextBtn() {
        picID++;
        if(picID >= monitorImgs.Length) {
            picID = 0;
            monitorCanvas.SetActive(false);
            dialog.nowNPC = "MainSelf";
            dialogScript.ShowDialog();
        }
        for(int i = 0; i < monitorImgs.Length; i ++) {
            if(i == picID) {
                monitorImgs[i].SetActive(true);
            }
            else {
                monitorImgs[i].SetActive(false);
            }
        }
    }

    public void prevBtn() {
        picID--;
        if(picID < 0) {
            picID = 0;
            return;
        }
        for(int i = 0; i < monitorImgs.Length; i ++) {
            if(i == picID) {
                monitorImgs[i].SetActive(true);
            }
            else {
                monitorImgs[i].SetActive(false);
            }
        }
    }
}
