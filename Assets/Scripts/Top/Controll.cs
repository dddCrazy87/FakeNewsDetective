using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controll : MonoBehaviour
{
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private Backpack backpack;

    private void Start() {
        instructionAndMission.instructionID = 0;
        instructionAndMission.missionLV = 0;
        instructionAndMission.gameLvId = 1;
        instructionAndMission.finshedMission[0] = false;
        instructionAndMission.finshedMission[1] = false;
        instructionAndMission.finshedMission[2] = false;
        backpack.isHavingDeadBodyPieces = false;
        backpack.isHavingDeadBody = false;
    }

    public void ToStart() {
        SceneManager.LoadScene("Home");
    }

    public void ToEnd() {
        Application.Quit();
    }
}
