using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1Behaviour : MonoBehaviour
{
    [SerializeField] private GameObject pic;

    public void ShowPic() {
        pic.SetActive(true);
    }

    public void ClosePic() {
        pic.SetActive(false);
    }
}
