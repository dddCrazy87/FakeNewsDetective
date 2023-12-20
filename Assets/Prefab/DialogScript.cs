using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogScript : MonoBehaviour
{
    [SerializeField] private Dialog dialog;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private GameObject dialogCanvas;
    [SerializeField] private GameObject[] dialogIcons;
    [SerializeField] private int mainCh = 0, KPCh = 1, videoProfesserCh = 2;
    [SerializeField] private Text dialogText;
    private List<KeyValuePair<int, string>> dialogContent = new();
    
    public bool isDialogSetted;
    private int dialogContentId = 0;
    public bool lv1Finished = false;
    public bool toCloseQueenData = true;
    public bool showDeadBody = false, showDeadBodyPieces = false;

    public void ShowDialog() {
        dialogCanvas.SetActive(true);
        dialogContent = dialog.SetDialogContent();
        isDialogSetted = true;
        dialogContentId = -1;
        if(dialog.nowNPC == "MainSelf1") {
            toCloseQueenData = false;
        }
        NextDialog();
    }

    public void NextDialog() {
        
        if(!isDialogSetted) {
            return;
        }
        dialogContentId ++;
        if(dialogContentId >= dialogContent.Count) {
            if(dialog.nowNPC == "KP") {
                if(instructionAndMission.instructionID == 1) {
                    instructionAndMission.instructionID = 2;
                }
            }
            if(dialog.nowNPC == "MainSelf") {
                lv1Finished = true;
            }
            if(dialog.nowNPC == "VideoProfesser1") {
                if(instructionAndMission.instructionID == 4) {
                    instructionAndMission.instructionID = 5;
                }
            }
            if(dialog.nowNPC == "MainSelf1") {
                if(instructionAndMission.instructionID == 5) {
                    instructionAndMission.instructionID = 6;
                }
                toCloseQueenData = true;
                instructionAndMission.missionLV = 3;
            }
            if(dialog.nowNPC == "VideoProfesser2") {
                if(instructionAndMission.instructionID == 6) {
                    instructionAndMission.instructionID = 7;
                }
            }
            if(dialog.nowNPC == "Soldier1") {
                if(instructionAndMission.instructionID == 7) {
                    instructionAndMission.instructionID = 8;
                }
            }
            if(dialog.nowNPC == "MainSelf2") {
                if(instructionAndMission.instructionID == 8) {
                    instructionAndMission.instructionID = 9;
                }
            }
            if(dialog.nowNPC == "MainSelf3") {
                if(instructionAndMission.instructionID == 9) {
                    instructionAndMission.instructionID = 10;
                }
            }
            if(dialog.nowNPC == "MainSelf4") {
                if(instructionAndMission.instructionID == 10) {
                    instructionAndMission.instructionID = 11;
                }
            }
            if(dialog.nowNPC == "MainSelf5") {
                if(instructionAndMission.instructionID == 11) {
                    instructionAndMission.instructionID = 12;
                }
            }
            if(dialog.nowNPC == "MainSelf6") {
                if(instructionAndMission.instructionID == 12) {
                    instructionAndMission.instructionID = 13;
                }
            }
            if(dialog.nowNPC == "MainSelf7") {
                if(instructionAndMission.instructionID == 13) {
                    instructionAndMission.finshedMission[2] = true;
                    instructionAndMission.gameLvId = 3;
                }
            }
            dialogCanvas.SetActive(false);
            isDialogSetted = false;
            dialogContentId = 0;
            return;
        }
        foreach(GameObject go in dialogIcons) {
            go.SetActive(false);
        }
        if(dialogContent[dialogContentId].Key == 1) {
            dialogIcons[mainCh].SetActive(true);
        }
        else if(dialogContent[dialogContentId].Key == 2) {
            if(dialog.nowNPC == "KP") {
                dialogIcons[KPCh].SetActive(true);
            }
            else if(dialog.nowNPC == "VideoProfesser1" || dialog.nowNPC == "VideoProfesser2") {
                dialogIcons[videoProfesserCh].SetActive(true);
            }
        }
        dialogText.text = dialogContent[dialogContentId].Value;

        // missions
        if(dialog.nowNPC == "KP" && dialogContentId == 8) {
            instructionAndMission.finshedMission[0] = true;
        }
        if(dialog.nowNPC == "KP" && dialogContentId == 19) {
            instructionAndMission.finshedMission[1] = true;
        }
        if(dialog.nowNPC == "VideoProfesser2" && dialogContentId == 5) {
            instructionAndMission.finshedMission[0] = true;
        }
        if(dialog.nowNPC == "MainSelf4" && dialogContentId == 2) {
            showDeadBody = true;
        }
        if(dialog.nowNPC == "MainSelf5" && dialogContentId == 1) {
            showDeadBody = true;
        }
        if(dialog.nowNPC == "MainSelf5" && dialogContentId == 12) {
            instructionAndMission.finshedMission[1] = true;
        }
        if(dialog.nowNPC == "MainSelf7" && dialogContentId == 1) {
            showDeadBodyPieces = true;
        }
    }
}
