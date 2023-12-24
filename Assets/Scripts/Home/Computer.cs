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
    [SerializeField] private Player player;
    private bool isNewsOpen = false;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            if(instructionAndMission.instructionID == 5 || instructionAndMission.instructionID == 6) {
                QueenDataCanvas.SetActive(true);
                dialog.nowNPC = "MainSelf1";
                dialogScript.ShowDialog();
            }
            else if(instructionAndMission.gameLvId == 1) {
                news1Canvas.SetActive(true);
                player.isMove = false;
                isNewsOpen = true;
            }
            else if(instructionAndMission.gameLvId == 2) {
                news2Canvas.SetActive(true);
                player.isMove = false;
                isNewsOpen = true;
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

    private void Update() {
        if(isNewsOpen) {
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) prevBtn();
            if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) nextBtn();
        }
    }

    private int picID = 0;
    public void nextBtn() {
        picID++;
        if(instructionAndMission.gameLvId == 1) {
            if(picID >= news1.Length) {
                news1Canvas.SetActive(false);
                picID = 0;
                player.isMove = true;
                isNewsOpen = false;
                dialog.nowNPC = "News1";
                dialogScript.ShowDialog();
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
                news2Canvas.SetActive(false);
                picID = 0;
                player.isMove = true;
                isNewsOpen = false;
                dialog.nowNPC = "News2";
                dialogScript.ShowDialog();
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
