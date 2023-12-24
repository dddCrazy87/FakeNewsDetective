using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story2 : MonoBehaviour
{
    [SerializeField] private GameObject[] story2_go;
    [SerializeField] private story story2_scripts;
    [SerializeField] private InstructionAndMission instructionAndMission;
    [SerializeField] private Player player;
    [SerializeField] private BgmController bgmController;
    private AudioSource storyAudio;

    private void Start() {
        storyAudio = GetComponent<AudioSource>();
    }

    public bool isMusicPlaying = false;
    private void FixedUpdate() {
        if(instructionAndMission.gameLvId == 3 && !isMusicPlaying) {
            isMusicPlaying = true;
            storyAudio.Play();
            bgmController.toPuaseBgm = true;
            player.isMove = false;
            foreach(GameObject go in story2_go) {
                go.SetActive(true);
            }
            if(!story2_scripts.isAnimated) story2_scripts.isAnimating = true;
        }
    }

    public void okBtn() {
        Invoke("delay", 0.2f);
    }

    private void delay() {
        SceneManager.LoadScene("Top");
    }

}
