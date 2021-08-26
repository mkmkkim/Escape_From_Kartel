using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemButton : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;
    public Image itemIcon;
    public int itemNo;
    public int count;
    public bool isDoorOpen;

    void Awake()
    {
        button = GetComponent<Button>();
        itemIcon = transform.GetChild(0).GetComponent<Image>();
    }
    public void ItemButtonOn(int iconNo)
    {
        Debug.Log("ItemButtonON확인");
        button.interactable = true;
        itemNo = iconNo;
        itemIcon.sprite = GameManager.Instance.itemSprite[iconNo];
    }
    public void ItemButtonClick()
    {
        count += 1;
        if (count % 2 == 1) { 
            GameManager.Instance.isItemSelected = true;
            Debug.Log("ItmeButtonClick확인" + gameObject.name);
            GameManager.Instance.currentItemNo = itemNo;
            button.GetComponent<Image>().color = GameManager.Instance.colors[1];
            Debug.Log("ColorChange뒤");
        }
        else
        {
            GameManager.Instance.currentItemNo = 0;
            GameManager.Instance.isItemSelected = false;
            button.GetComponent<Image>().color = Color.white;
        }
    }
    public void ItemButtonInit()
    {
        button.interactable = false;
        itemNo = 0;
        itemIcon.sprite = GameManager.Instance.itemSprite[0];
    }
    void Start()
    {
        button = GetComponent<Button>();
        itemIcon = transform.GetChild(0).GetComponent<Image>();
    }
}