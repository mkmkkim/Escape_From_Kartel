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
        before[0].GetComponent<RectTransform>().sizeDelta = new Vector2(150, 195);
        before[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(-12, 77, 0);
        before[1].sprite = GameManager.Instance.changeImage[3];
        before[1].GetComponent<RectTransform>().sizeDelta = new Vector2(155, 197);
        before[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(-13, 78, 0);
    }
    public void Switch()
    {
        before[2].sprite = GameManager.Instance.changeImage[6];
        before[2].GetComponent<RectTransform>().sizeDelta = new Vector2(9, 30);
        before[2].GetComponent<RectTransform>().anchoredPosition = new Vector3(-48, 13, 0);
    }
    public void Door4F()
    {
        before[3].sprite = GameManager.Instance.changeImage[7];
        before[3].GetComponent<RectTransform>().sizeDelta = new Vector2(220, 220);
        before[3].GetComponent<RectTransform>().anchoredPosition = new Vector3(-3, -76,0);
    }
    public void coffer()
    {
        before[4].sprite = GameManager.Instance.changeImage[5];
        before[4].GetComponent<RectTransform>().sizeDelta = new Vector2(555, 345);
        before[4].GetComponent<RectTransform>().anchoredPosition = new Vector3(125, 18,0);
        before[5].sprite = GameManager.Instance.changeImage[5];
        before[5].GetComponent<RectTransform>().sizeDelta = new Vector2(555, 345);
        before[5].GetComponent<RectTransform>().anchoredPosition = new Vector3(121, 22, 0);
    }
}
