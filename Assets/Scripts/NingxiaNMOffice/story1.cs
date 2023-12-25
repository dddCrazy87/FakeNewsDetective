using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class story1 : MonoBehaviour
{
    [SerializeField] private GameObject[] story1_go;
    [SerializeField] private story story1_scripts;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private Player player;
    [SerializeField] private BgmController bgmController;

    private AudioSource storyAudio;

    private void Start() {
        storyAudio = GetComponent<AudioSource>();
    }

    public bool isMusicPlaying = false;
    private void FixedUpdate() {
        if(instructionAndMission.instructionID == 3 && instructionAndMission.gameLvId == 1 && !isMusicPlaying) {
            isMusicPlaying = true;
            bgmController.toPuaseBgm = true;
            storyAudio.Play();
            foreach(GameObject go in story1_go) {
                go.SetActive(true);
                if(!story1_scripts.isAnimated) story1_scripts.isAnimating = true;
            }
        }
    }

    public void okBtn() {
        player.isMove = true;
        instructionAndMission.gameLvId = 2;
        bgmController.toPuaseBgm = false;
        Destroy(gameObject);
    }
}
