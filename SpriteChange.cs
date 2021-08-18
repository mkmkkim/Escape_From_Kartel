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
    public void Toilet()
    {
        before[0].sprite = GameManager.Instance.changeImage[0];
        before[0].GetComponent<RectTransform>().sizeDelta = new Vector2(700, 700);
        before[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(159, 40, 0);
    }
    public void Sink()
    {
        before[1].sprite = GameManager.Instance.changeImage[1];
        before[1].GetComponent<RectTransform>().sizeDelta = new Vector2(700, 500);
        before[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(-66, 0, 0);
    }
}
