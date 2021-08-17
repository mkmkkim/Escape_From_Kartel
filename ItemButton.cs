using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemButton : MonoBehaviour
{
    // Start is called before the first frame update

    public Button button;
    public Button door5F;
    Image itemIcon;
   public List<int> space1;
    public int itemNo;

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

    public void DoorUse()
    {
        Debug.Log("DoorUse확인");
        button.interactable = true;
/*        List<int> space1 = GameManager.Instance.space1GetedItemList;*/
        if (itemNo == 1)
        {
            Debug.Log("dooruseloof확인");
            door5F.interactable = true;
        }
    }
}