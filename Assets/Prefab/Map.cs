using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    [SerializeField] private GameObject[] placeBtns;
    [SerializeField] private Player player;

    private bool isMapOpen = false;
    public void OpenMap() {
        isMapOpen = !isMapOpen;
        if(isMapOpen) {
            foreach(GameObject go in placeBtns) {
                go.SetActive(true);
            }
            player.isMove = false;
        }
        else {
            foreach(GameObject go in placeBtns) {
                go.SetActive(false);
            }
            player.isMove = true;
        }
    }

    public void loadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
