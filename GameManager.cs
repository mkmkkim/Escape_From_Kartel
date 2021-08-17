using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static GameManager instance = null;
    public int currentSpaceNo;
    public bool isGameStart;
    public Image getItemIamge;
    public GameObject[] space; // 공간을 배열로 저장함 특이하게0을 페이드인/아웃으로 설정하려 함
    public Sprite[] itemSprite;// 아이템 이미지 모음
    public int[] space1GetItem;// 얻어야할 아이템
    public List<int> space1GetedItemList;// 얻어낸 아이템 리스트
    public GameObject dial;

    //<UGUI> - Text 창
    public TalkingGUI talkGUI; // 메시지가 나가는 곳
    public bool isTexting;
    //<UGUI> - 아이템 창
    string dialog_Nor;// 아이템 획득 전
    string dialog_GetItem;// 아이템 획득 시
    string dialog_GetedItem;//아이템 획득 후

    public ItemButton[] itemButton;//고정되는 방식으로 n개가 들어감

    public Sprite[] changeImage;
    public static GameManager Instance//실제 접근
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    void Start()
    {
        if (null == instance)
        {
            instance = this;
        }
        currentSpaceNo = Mathf.Max(1, PlayerPrefs.GetInt("CurretSpaceNo"));//최소 스테이지 번호는 1이다.
        for (int i = 0; i < itemButton.Length; i++)
        {
            itemButton[i].ItemButtonInit();
            itemButton[i].space1 = GameManager.Instance.space1GetedItemList;
        }
    }
    private void Update()
    {
        dialcheck();
    }

    int getItemCount;
    public void TouchCheck(int spaceNo, int itemNo, string normal, string getItem, string getedItem)
    {
        Debug.Log("1버튼입력확인");

        getItemCount = 0;
        Debug.Log("2버튼입력확인");
        if (isTexting) return;
        Debug.Log("3버튼입력확인");
        if (itemNo == 0)
        {
            dialog_Nor = normal;
            getItemIamge.gameObject.SetActive(false);
            Debug.Log("4버튼입력확인");
            TalkTexting(normal);
        }
        else
        {
            if (spaceNo == currentSpaceNo)
            {
                Debug.Log("5버튼입력확인");
                switch (spaceNo)
                {
                    case 1:
                        if (space1GetedItemList.Count != 0)
                        {
                            for (int i = 0; i < space1GetedItemList.Count; i++)
                            {
                                if (space1GetedItemList[i] == itemNo)
                                {
                                    getItemCount++;
                                }
                            }

                            Debug.Log("6버튼입력확인" + getItemCount);
                            if (getItemCount == 0)// 중복된 것이 없으니 등록
                            {
                                space1GetedItemList.Add(itemNo);
                                getItemIamge.sprite = itemSprite[itemNo];
                                getItemIamge.gameObject.SetActive(true);
                                int crNo = space1GetedItemList.Count - 1;
                                Debug.Log("crNo" + crNo);
                                GameManager.Instance.itemButton[crNo].ItemButtonOn(space1GetedItemList[crNo]);
                                Debug.Log("7버튼입력확인");
                                TalkTexting(getItem);
                            }
                            else
                            {
                                TalkTexting(getedItem);
                                getItemIamge.gameObject.SetActive(false);
                            }
                            break;
                        }
                        else
                        {
                            getItemIamge.sprite = itemSprite[itemNo];
                            getItemIamge.gameObject.SetActive(true);
                            space1GetedItemList.Add(itemNo);
                            int crNo = space1GetedItemList.Count - 1;
                            Debug.Log("crNo" + crNo);
                            GameManager.Instance.itemButton[crNo].ItemButtonOn(space1GetedItemList[crNo]);
                            TalkTexting(getItem);
                        }
                        break;
                }
            }
        }
    }



    public void TalkTexting(string dial)
    {
        talkGUI.TalkText(dial);
        talkGUI.gameObject.SetActive(true);
        isTexting = true;
        Invoke("TalkGUIOff", 5f);
    }

    void TalkGUIOff()
    {
        isTexting = false;
        getItemIamge.gameObject.SetActive(false);
        talkGUI.gameObject.SetActive(false);
    }


    void ItemButtonOn()
    {

    }
    public int buttoncnt1;
    public int buttoncnt2;
    public int buttoncnt3;
    public int buttoncnt4;
    void dialcheck()
    {
        if (buttoncnt1 % 24 == 5)
        {
            if (buttoncnt2 % 12 == 2)
            {
                if (buttoncnt3 % 8 == 7)
                {
                    if (buttoncnt4 % 6 == 4)
                    {
                        dial.SetActive(false);
                    }
                }
            }
        }
    }
    public int[] space2GetItem;// 얻어야할 아이템
    public int[] space3GetItem;// 얻어야할 아이템
    public int[] space4GetItem;// 얻어야할 아이템
    public int[] space5GetItem;// 얻어야할 아이템

}