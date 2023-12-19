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
    }
}
