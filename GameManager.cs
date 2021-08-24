using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static GameManager instance = null;
    public int currentItemNo;
    public int currentSpaceNo;
    public int currentInteractNo;
    public bool isGameStart;
    public bool isItemSelected;
    public Image getItemIamge;
    public GameObject[] space; // 공간을 배열로 저장함 특이하게0을 페이드인/아웃으로 설정하려 함
    public Sprite[] itemSprite;// 아이템 이미지 모음
    public Image[] before;
    public int[] space1GetItem;// 얻어야할 아이템
    public List<int> space1GotItemList;// 얻어낸 아이템 리스트

    public int[] space2GetItem;// 얻어야할 아이템
    public List<int> space2GotItemList;// 얻어낸 아이템 리스트

    public int[] space3GetItem;// 얻어야할 아이템
    public List<int> space3GotItemList;// 얻어낸 아이템 리스트

    public int[] space4GetItem;// 얻어야할 아이템
    public List<int> space4GotItemList;// 얻어낸 아이템 리스트

    public int[] space5GetItem;// 얻어야할 아이템
    public List<int> space5GotItemList;// 얻어낸 아이템 리스트
    public GameObject dial;
    public Color32[] colors;
    //<UGUI> - Text 창
    public TalkingGUI talkGUI; // 메시지가 나가는 곳
    public bool isTexting;
    //<UGUI> - 아이템 창

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
        }
    }
    private void Update()
    {
        Dialcheck();
    }

    int getItemCount;
    public void TouchCheck(int spaceNo, int itemNo, string getItem)
    {
        getItemCount = 0;
        if (isTexting) return;
        if (itemNo == 0)
        {
            getItemIamge.gameObject.SetActive(false);
        }
        else
        {
            if (spaceNo == currentSpaceNo)
            {
                switch (spaceNo)
                {
                    case 1:
                        if (space1GotItemList.Count != 0)
                        {
                            for (int i = 0; i < space1GotItemList.Count; i++)
                            {
                                if (space1GotItemList[i] == itemNo)
                                {
                                    getItemCount++;
                                }
                            }

                            if (getItemCount == 0)// 중복된 것이 없으니 등록
                            {
                                space1GotItemList.Add(itemNo);
                                getItemIamge.sprite = itemSprite[itemNo];
                                getItemIamge.gameObject.SetActive(true);
                                int crNo = space1GotItemList.Count - 1;
                                GameManager.Instance.itemButton[crNo].ItemButtonOn(space1GotItemList[crNo]);
                                TalkTexting(getItem);
                            }
                            else
                            {
                                getItemIamge.gameObject.SetActive(false);
                            }
                            break;
                        }
                        else
                        {
                            getItemIamge.sprite = itemSprite[itemNo];
                            getItemIamge.gameObject.SetActive(true);
                            space1GotItemList.Add(itemNo);
                            int crNo = space1GotItemList.Count - 1;
                            GameManager.Instance.itemButton[crNo].ItemButtonOn(space1GotItemList[crNo]);
                            TalkTexting(getItem);
                        }
                        break;

                    case 2:
                        if (space2GotItemList.Count != 0)
                        {
                            for (int i = 0; i < space2GotItemList.Count; i++)
                            {
                                if (space2GotItemList[i] == itemNo)
                                {
                                    getItemCount++;
                                }
                            }

                            if (getItemCount == 0)// 중복된 것이 없으니 등록
                            {
                                space2GotItemList.Add(itemNo);
                                getItemIamge.sprite = itemSprite[itemNo];
                                getItemIamge.gameObject.SetActive(true);
                                int crNo = space2GotItemList.Count - 1;
                                GameManager.Instance.itemButton[crNo].ItemButtonOn(space2GotItemList[crNo]);

                                TalkTexting(getItem);
                            }
                            else
                            {
                                getItemIamge.gameObject.SetActive(false);
                            }
                            break;
                        }
                        else
                        {
                            getItemIamge.sprite = itemSprite[itemNo];
                            getItemIamge.gameObject.SetActive(true);
                            space2GotItemList.Add(itemNo);
                            int crNo = space2GotItemList.Count - 1;
                            GameManager.Instance.itemButton[crNo].ItemButtonOn(space2GotItemList[crNo]);
                            TalkTexting(getItem);
                        }
                        break;
                    case 3:
                        if (space3GotItemList.Count != 0)
                        {
                            for (int i = 0; i < space3GotItemList.Count; i++)
                            {
                                if (space3GotItemList[i] == itemNo)
                                {
                                    getItemCount++;
                                }
                            }

                            if (getItemCount == 0)// 중복된 것이 없으니 등록
                            {
                                space3GotItemList.Add(itemNo);
                                getItemIamge.sprite = itemSprite[itemNo];
                                getItemIamge.gameObject.SetActive(true);
                                int crNo = space3GotItemList.Count - 1;
                                GameManager.Instance.itemButton[crNo].ItemButtonOn(space3GotItemList[crNo]);
                                TalkTexting(getItem);
                            }
                            else
                            {
                                getItemIamge.gameObject.SetActive(false);
                            }
                            break;
                        }
                        else
                        {
                            getItemIamge.sprite = itemSprite[itemNo];
                            getItemIamge.gameObject.SetActive(true);
                            space3GotItemList.Add(itemNo);
                            int crNo = space3GotItemList.Count - 1;
                            GameManager.Instance.itemButton[crNo].ItemButtonOn(space3GotItemList[crNo]);
                            TalkTexting(getItem);
                        }
                        break;
                    case 4:
                        if (space4GotItemList.Count != 0)
                        {
                            for (int i = 0; i < space4GotItemList.Count; i++)
                            {
                                if (space4GotItemList[i] == itemNo)
                                {
                                    getItemCount++;
                                }
                            }

                            if (getItemCount == 0)// 중복된 것이 없으니 등록
                            {
                                space4GotItemList.Add(itemNo);
                                getItemIamge.sprite = itemSprite[itemNo];
                                getItemIamge.gameObject.SetActive(true);
                                int crNo = space4GotItemList.Count - 1;
                                GameManager.Instance.itemButton[crNo].ItemButtonOn(space4GotItemList[crNo]);
                                TalkTexting(getItem);
                            }
                            else
                            {
                                getItemIamge.gameObject.SetActive(false);
                            }
                            break;
                        }
                        else
                        {
                            getItemIamge.sprite = itemSprite[itemNo];
                            getItemIamge.gameObject.SetActive(true);
                            space4GotItemList.Add(itemNo);
                            int crNo = space4GotItemList.Count - 1;
                            Debug.Log("crNo" + crNo);
                            GameManager.Instance.itemButton[crNo].ItemButtonOn(space4GotItemList[crNo]);
                            TalkTexting(getItem);
                        }
                        break;
                }
            }
        }
    }
    public void InteractCheck(int interactNo)
    {
        currentInteractNo = interactNo;
        if (currentItemNo == currentInteractNo)
        {
            switch (currentInteractNo)
            {
                case 0:
                    break;
                case 1:
                    CardUse();
                    break;
                case 2:
                    WaterBasketUse();
                    break;
                case 3:
                    DduruUse();
                    break;
                case 4:
                    FillSink();
                    break;
            }
            for (int i = 0; i < 8; i++)
            {
                itemButton[i].GetComponent<Image>().color = Color.white;
            }
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                itemButton[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
    public GameObject handle;
    public GameObject clear;
    public void CardUse()
    {
        handle.SetActive(false);
        before[0].sprite = GameManager.Instance.changeImage[0];
        before[0].GetComponent<RectTransform>().sizeDelta = new Vector2(255, 275);
        before[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(51, -49, 0);
        clear.SetActive(true);
    }
    public GameObject waterbasket;
    public void WaterBasketUse()
    {
        before[1].sprite =changeImage[0];
        before[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(147, 103, 0);
        before[1].GetComponent<RectTransform>().sizeDelta = new Vector2(800, 800);
        waterbasket.SetActive(true);
    }
    public GameObject keyActive;
    public void FillSink()
    {
        before[2].sprite = GameManager.Instance.changeImage[1];
        before[2].GetComponent<RectTransform>().sizeDelta = new Vector2(900, 650);
        before[2].GetComponent<RectTransform>().anchoredPosition = new Vector3(-60, -100, 0);
        keyActive.SetActive(true);
    }
    public GameObject water;
    public GameObject key;
    public GameObject dirty;
    public void DduruUse()
    {
        before[2].sprite = GameManager.Instance.changeImage[4];
        before[2].GetComponent<RectTransform>().sizeDelta = new Vector2(900, 650);
        before[2].GetComponent<RectTransform>().anchoredPosition = new Vector3(-60, -100, 0);
        water.SetActive(true);
        key.SetActive(true);
        dirty.SetActive(true);
    }
   
    public void TalkTexting(string dial)
    {
        talkGUI.TalkText(dial);
        talkGUI.gameObject.SetActive(true);
        isTexting = true;
        Invoke("TalkGUIOff", 1.5f);
    }

    void TalkGUIOff()
    {
        isTexting = false;
        getItemIamge.gameObject.SetActive(false);
        talkGUI.gameObject.SetActive(false);
    }

    public int buttoncnt1;
    public int buttoncnt2;
    public int buttoncnt3;
    public int buttoncnt4;
    public bool isDialClear;
    public GameObject dialActivate;
    void Dialcheck()
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
                        dialActivate.SetActive(false);
                        isDialClear = true;
                    }
                }
            }
        }
    }

}