using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteChange : MonoBehaviour
{
    public Image[] before;
    public void Pipe()
    {
        before[0].sprite = GameManager.Instance.changeImage[3];
        before[0].GetComponent<RectTransform>().sizeDelta = new Vector2(160, 200);
        before[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(-11, 75, 0);
        before[1].sprite = GameManager.Instance.changeImage[3];
        before[1].GetComponent<RectTransform>().sizeDelta = new Vector2(160, 200);
        before[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(-13, 78, 0);
    }
    public void Dial()
    {
        before[2].sprite = GameManager.Instance.changeImage[2];
        before[2].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0 , 0);
        before[2].GetComponent<RectTransform>().sizeDelta = new Vector2(150, 150);
        before[3].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        before[3].GetComponent<RectTransform>().sizeDelta = new Vector2(275,275);
        before[4].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        before[4].GetComponent<RectTransform>().sizeDelta = new Vector2(400,400);
        before[5].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        before[5].GetComponent<RectTransform>().sizeDelta = new Vector2(520, 520);
        before[6].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 0, 0);
        before[6].GetComponent<RectTransform>().sizeDelta = new Vector2(650, 650);
    }
}
