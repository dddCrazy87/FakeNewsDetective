using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class Monitor : MonoBehaviour
{
    [SerializeField] private GameObject monitorCanvas;
    [SerializeField] private GameObject[] monitorImgs;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Dialog dialog;
    [SerializeField] private Player player;
    
    private bool isMonitorOpen = false;
    private AudioSource missionOkAudio;

    private void Start() {
        missionOkAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            monitorCanvas.SetActive(true);
            player.isMove = false;
            isMonitorOpen = true;
        }
    }

    private void FixedUpdate() {
        if(dialogScript.lv1Finished) {
            if(instructionAndMission.instructionID == 2) {
                instructionAndMission.finshedMission[2] = true;
                missionOkAudio.Play();
                instructionAndMission.instructionID = 3;
            }
        }
    }

    private void Update() {
        if(isMonitorOpen) {
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) prevBtn();
            if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) nextBtn();
        }
    }

    private int picID = 0;
    public void nextBtn() {
        picID++;
        if(picID >= monitorImgs.Length) {
            picID = 0;
            player.isMove = true;
            isMonitorOpen = false;
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
