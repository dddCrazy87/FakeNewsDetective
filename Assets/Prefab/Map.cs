using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    [SerializeField] private GameObject[] placeBtns;

    private bool isMapOpen = false;
    public void OpenMap() {
        isMapOpen = !isMapOpen;
        if(isMapOpen) {
            foreach(GameObject go in placeBtns) {
                go.SetActive(true);
            }
        }
        else {
            foreach(GameObject go in placeBtns) {
                go.SetActive(false);
            }
        }
    }

    public void loadScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
