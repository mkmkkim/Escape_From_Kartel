using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemButton : MonoBehaviour
{
    // Start is called before the first frame update
    List<int> space1 = EscapeGM.Instance.space1GetedItemList;
    public Button door1;
    public Button door2;
    Button button;
    Image itemIcon;
    int itemNo;

    void Awake()
    {
        button = GetComponent<Button>();
        itemIcon = transform.GetChild(0).GetComponent<Image>();
    }
    public void ItemButtonOn(int iconNo)
    {
        button.interactable = true;
        itemNo = iconNo;
        itemIcon.sprite = EscapeGM.Instance.itemSprite[iconNo];
    }

    public void ItemButtonInit()
    {
        button.interactable = false;
        itemNo = 0;
        itemIcon.sprite = EscapeGM.Instance.itemSprite[0];
    }
    //void Start()
    //{
    //    button = GetComponent<Button>();
    //    itemIcon = transform.GetChild(0).GetComponent<Image>();
    //}
    
    public void UseItem()
    {
        button.interactable = true;
        foreach(int itemNo in space1)
        {
            if (space1.Contains(1))
            {
                door1.interactable = true;
            }
            else if (space1.Contains(2))
            {
                door2.interactable = true;
            }
        }
    }
}
