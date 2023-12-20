using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private DialogScript dialogScript;
    [SerializeField] private Rigidbody2D player_rb;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Return)) {
            dialogScript.NextDialog();
        }
    }

    private void FixedUpdate() {
        if(dialogScript.isDialogSetted) {
            player_rb.constraints = RigidbodyConstraints2D.FreezePosition;
            player_rb.freezeRotation = true;
        }
        else {
            player_rb.constraints = RigidbodyConstraints2D.None;
            player_rb.freezeRotation = true;
        }
    }
}
