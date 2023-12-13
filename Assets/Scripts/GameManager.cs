using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private void Awake()
    {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    [SerializeField] private GameObject[] DialogBox;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Backpack;
    [SerializeField] private Text DialogText;
    private string[] dialogContent;
    private int dialogContentID;
    private List<GameObject> gottenItems = new List<GameObject>();
    private void Start() {
        dialogContentID = 0;
    }

    public void LoadNpcDialog(string[] str) {
        dialogContent = str;
    }

    private void SetDialogContext() {
        DialogText.text = dialogContent[dialogContentID];
    }

    public void OpenDialogBox() {
        Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        Player.GetComponent<Rigidbody2D>().freezeRotation = true;
        dialogContentID = 0;
        SetDialogContext();
        foreach (GameObject go in DialogBox) {
            go.SetActive(true);
        }
    }

    public void CloseDialogBox() {
        Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        Player.GetComponent<Rigidbody2D>().freezeRotation = true;
        foreach (GameObject go in DialogBox) {
            go.SetActive(false);
        }
    }

    public void NextDialogContent() {
        dialogContentID += 1;
        if (dialogContentID >= dialogContent.Length) {
            CloseDialogBox();
            return;
        }
        SetDialogContext();
    }

    public void AddGottenItem(GameObject item) {
        gottenItems.Add(item);
    }

    public void OpenBackpack() {
        Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        Player.GetComponent<Rigidbody2D>().freezeRotation = true;
        Backpack.SetActive(true);
        float x = -135f, y = 135f; int cnt = 0;
        foreach (GameObject go in gottenItems) {
            go.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
            go.gameObject.SetActive(true);
            cnt ++;
            if(cnt == 6) { x = -135f; y -= 54f; cnt = 0; }
            else         { x += 54f; }
        }
    }

    public void CloseBackpack() {
        Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        Player.GetComponent<Rigidbody2D>().freezeRotation = true;
        Backpack.SetActive(false);
        foreach (GameObject go in gottenItems) {
            go.gameObject.SetActive(false);
        }
    }

    public void switchScene() {
         SceneManager.LoadScene("MemorialHall");
    }
}
