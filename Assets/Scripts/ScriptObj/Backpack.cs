using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Backpack", menuName = "ScriptableObj/Backpack")]
public class Backpack : ScriptableObject {
    public List<GameObject> items = new();
    public void AddItems(GameObject go) {
        items.Add(go);
        float x = -135f, y = 135f; int cnt = 0;
        foreach (GameObject item in items) {
            item.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);
            item.gameObject.SetActive(true);
            cnt ++;
            if(cnt == 6) { x = -135f; y -= 54f; cnt = 0; }
            else         { x += 54f; }
        }
    }
}
