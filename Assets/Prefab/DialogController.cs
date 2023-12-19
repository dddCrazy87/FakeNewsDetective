using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private DialogScript dialogScript;
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.Return)) {
            dialogScript.NextDialog();
        }
    }
}
