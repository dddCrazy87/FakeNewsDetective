using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    [SerializeField] private GameObject news1Canvas, news2Canvas, QueenDataCanvas;
    [SerializeField] private GameObject[] news1, news2;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            if(instructionAndMission.instructionID == 5 || instructionAndMission.instructionID == 6) {
                QueenDataCanvas.SetActive(true);
                dialog.nowNPC = "MainSelf1";
                dialogScript.ShowDialog();
            }
            else if(instructionAndMission.gameLvId == 1) {
                news1Canvas.SetActive(true);
            }
            else if(instructionAndMission.gameLvId == 2) {
                news2Canvas.SetActive(true);
            }
        }
    }

    private void FixedUpdate() {
        if(dialogScript.toCloseQueenData) {
            QueenDataCanvas.SetActive(false);
        }
        else if(!dialogScript.toCloseQueenData) {
            QueenDataCanvas.SetActive(true);
        }
    }

    private int picID = 0;
    public void nextBtn() {
        picID++;
        if(instructionAndMission.gameLvId == 1) {
            if(picID >= news1.Length) {
                news1Canvas.SetActive(false);
                instructionAndMission.missionLV = 1;
                if(instructionAndMission.instructionID == 0) {
                    instructionAndMission.instructionID = 1;
                }
                picID = 0;
            }
            for(int i = 0; i < news1.Length; i ++) {
                if(i == picID) {
                    news1[i].SetActive(true);
                }
                else {
                    news1[i].SetActive(false);
                }
            }
        }
        if(instructionAndMission.gameLvId == 2) {
            if(picID >= news2.Length) {
                if(instructionAndMission.instructionID == 3) {
                    instructionAndMission.instructionID = 4;
                    instructionAndMission.finshedMission[0] = false;
                    instructionAndMission.finshedMission[1] = false;
                    instructionAndMission.finshedMission[2] = false;
                    instructionAndMission.missionLV = 2;
                }
                news2Canvas.SetActive(false);
                picID = 0;
            }
            for(int i = 0; i < news2.Length; i ++) {
                if(i == picID) {
                    news2[i].SetActive(true);
                }
                else {
                    news2[i].SetActive(false);
                }
            }
        }
    }

    public void prevBtn() {
        picID--;
        if(instructionAndMission.gameLvId == 1) {
            if(picID < 0) {
                picID = 0;
                return;
            }
            for(int i = 0; i < news1.Length; i ++) {
                if(i == picID) {
                    news1[i].SetActive(true);
                }
                else {
                    news1[i].SetActive(false);
                }
            }
        }
        if(instructionAndMission.gameLvId == 2) {
            if(picID < 0) {
                picID = 0;
                return;
            }
            for(int i = 0; i < news2.Length; i ++) {
                if(i == picID) {
                    news2[i].SetActive(true);
                }
                else {
                    news2[i].SetActive(false);
                }
            }
        }
    }
}
