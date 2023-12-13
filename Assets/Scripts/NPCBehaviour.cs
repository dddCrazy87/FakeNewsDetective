using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject GameManager;
    [SerializeField] private string[] Dialog;
    [SerializeField] private GameObject DialogNoteIcon;
    [SerializeField] private GameObject DialogNote;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") {
            GameManager.GetComponent<GameManager>().LoadNpcDialog(Dialog);
            GameManager.GetComponent<GameManager>().OpenDialogBox();
            GameManager.GetComponent<GameManager>().AddGottenItem(DialogNoteIcon);
        }
    }

    public void OpenDialogNote() {
        DialogNote.SetActive(true);
    }

    public void CloseDialogNote() {
        DialogNote.SetActive(false);
    }
}
