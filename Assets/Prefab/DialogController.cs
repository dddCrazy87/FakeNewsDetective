using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Player player;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Return)||
            Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow)) {
            dialogScript.NextDialog();
        }

        if (Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)) {
            dialogScript.PrevDialog();
        }
    }

    private void FixedUpdate() {
        if(dialogScript.isDialogSetted) {
            player.isMove = false;
        }
    }
}
