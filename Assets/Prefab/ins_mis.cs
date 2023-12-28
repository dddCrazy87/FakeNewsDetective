using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ins_mis : MonoBehaviour
{
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private string instruction;
    [SerializeField] private Text instructionText;
    [SerializeField] private string[] missions;
    [SerializeField] private Text[] missionsText;
    [SerializeField] private bool[] finishedID;
    [SerializeField] private GameObject[] finishedIcon;
    [SerializeField] private GameObject bg1, bg2, bg3;

    private void FixedUpdate() {
        instruction = instructionAndMission.SetInstruction();
        instructionText.text = instruction;
        missions = instructionAndMission.SetMission();
        for(int i = 0; i < missionsText.Length; i ++) {
            if(i >= missions.Length) {
                missionsText[i].text = "";
            }
            else {
                missionsText[i].text = missions[i];
            }
        }
        finishedID = instructionAndMission.finshedMission;
        for(int i = 0; i < finishedID.Length; i++) {
            if(finishedID[i]) {
                finishedIcon[i].SetActive(true);
            }
            else {
                finishedIcon[i].SetActive(false);
            }
        }
        if(instructionAndMission.missionLV == 0) {
            bg1.SetActive(false);
            bg2.SetActive(false);
            bg3.SetActive(false);
        }
        if(instructionAndMission.missionLV == 1) {
            bg1.SetActive(true);
            bg2.SetActive(false);
            bg3.SetActive(false);
        }
        if(instructionAndMission.missionLV == 2) {
            bg1.SetActive(false);
            bg2.SetActive(true);
            bg3.SetActive(false);
        }
        if(instructionAndMission.missionLV == 3) {
            bg1.SetActive(false);
            bg2.SetActive(false);
            bg3.SetActive(true);
        }
    }
}
