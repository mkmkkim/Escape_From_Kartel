using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemButton : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;
    public Button cardtag;
    public Button door5F;
    Image itemIcon;
    public List<int> space1;
    public int itemNo;
    public int count;
    
    
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

    public void ItemButtonInit()
    {
        button.interactable = false;
        itemNo = 0;
        itemIcon.sprite = GameManager.Instance.itemSprite[0];
    }
    //void Start()
    //{
    //    button = GetComponent<Button>();
    //    itemIcon = transform.GetChild(0).GetComponent<Image>();
    //}

    public void CardUse()
    {
        button.GetComponent<Image>().color = Color.cyan;
            /*GameManager.Instance.colors[1];*/
  /*      itemIcon.GetComponent<Image>().color = Color.cyan;*/
        count += 1;
        button.interactable = true;
        /*        List<int> space1 = GameManager.Instance.space1GetedItemList;*/
        Debug.Log("CardUse확인");
        if (itemNo == 1)
        {
            if (count %2== 1) { 
                Debug.Log("CardUseloop확인");
                cardtag.interactable = true;
            }
            else
            {
                count = 0;
                button.GetComponent<Image>().color = Color.white;
                itemIcon.GetComponent<Image>().color = Color.white;
                cardtag.interactable = false;
            }
        }
    }

    public void DoorUse5()
    {
        door5F.interactable = true;
    }
}