using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteChange : MonoBehaviour
{
    public Image[] before;
    public GameObject handle;
    public void Door5F()
    {
        handle.SetActive(false);
        before[0].sprite=GameManager.Instance.changeImage[0];
        before[0].GetComponent<RectTransform>().sizeDelta = new Vector2(255,275);
        before[0].GetComponent<RectTransform>().anchoredPosition =  new Vector3(51, -49,0);

    }
}
