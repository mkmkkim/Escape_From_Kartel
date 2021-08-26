using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    public AudioSource audiosource;
  
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
        if (PlayerPrefs.GetInt("isDialClear") ==1)
        {
           isDialClear = true;
        }
        if (SceneManager.GetActiveScene().name == "4FScene" && isDialClear == true)// 씬번호와 클리어가 참이면 해당 데이터로 실행
        {
            dial1.SetActive(true);
            isDialClear = false;
        }
        for (int i = 0; i < itemButton.Length; i++)
        {
            itemButton[i].ItemButtonInit();
        }
        currentSpaceNo = Mathf.Max(1, PlayerPrefs.GetInt("CurretSpaceNo"));//최소 스테이지 번호는 1이다.
    }
    private void Update()
    {
        Dialcheck();
    }

    int getItemCount;
    public void TouchCheck(int spaceNo, int itemNo, string getItem)
    {
     //   Debug.Log("터치 아이템 = " + gameObject.name);
        Debug.Log("space" + spaceNo);
        Debug.Log("item" + itemNo);
        Debug.Log("getItem" + getItem);
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
                                getItemIamge.GetComponent<Image>().SetNativeSize();
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
                                Debug.Log("space2GotItemList.Add"+ itemNo);
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
    public void Toilet()
    {
        currentSpaceNo = 1;
    }
    public void AIsle4F()
    {
        currentSpaceNo = 2;
    }
    public void Coffer()
    {
        currentSpaceNo = 3;
    }
    public void SetZero()
    {
        PlayerPrefs.DeleteAll();
    }
    public AudioClip openJail;
    public AudioClip punch;
    public AudioClip dooropen;
    public AudioClip pressbtn;
    public AudioClip usekey;
    public AudioClip usewater;
    public AudioClip poorwater;
    public AudioClip drainwater;
    public AudioClip rotatedial;
    public AudioClip wrongSound;
    public AudioClip Do;
    public AudioClip Re;
    public AudioClip Mi;
    public AudioClip Sol;
    public AudioClip Ra;
    public AudioClip SoS;
    public void DoSound()
    {
        audiosource.clip = Do;
        audiosource.Play();
    }
    public void ReSound()
    {
        audiosource.clip = Re;
        audiosource.Play();
    }
    public void MiSound()
    {
        audiosource.clip = Mi;
        audiosource.Play();
    }
    public void SolSound()
    {
        audiosource.clip = Sol;
        audiosource.Play();
    }
    public void RaSound()
    {
        audiosource.clip = Ra;
        audiosource.Play();
    }
    public void InteractCheck(int interactNo)
    {
        currentInteractNo = interactNo;
        if (currentItemNo == currentInteractNo)
        {
            Debug.Log("currentspaceNo" + currentSpaceNo);
            Debug.Log("cureentItemNo" + currentItemNo);
            Debug.Log("currentInteractNo" + currentInteractNo);
            switch (currentInteractNo)
            {
                case 0:
                    break;
                case 1:
                    audiosource.clip = dooropen;
                    audiosource.Play();
                    Invoke("CardUse", 1f);
                    break;
                case 2:
                    audiosource.clip = usewater;
                    audiosource.Play();
                    Invoke("WaterBasketUse", 1f);
                    break;
                case 3:
                    audiosource.clip = drainwater;
                    audiosource.Play();
                    Invoke("DduruUse",1f);
                    break;
                case 4:
                    audiosource.clip = poorwater;
                    audiosource.Play();
                    Invoke("FillSink", 1f);
                    break;
                case 5:
                    DialKey();
                    break;
                case 6:
                    audiosource.clip = pressbtn;
                    audiosource.Play();
                    NewKey();
                    break;
                case 7:
                    Experiment();
                    break;
                case 8:
                    Battery();
                    break;
                case 9:
                    SOS();
                    break;
                case 10:
                    BatteryOn();
                    break;
                case 11:
                    Pendant();
                    break;
            }
            Debug.Log("itemButton.l = " + itemButton.Length);
            for (int i = 0; i < itemButton.Length; i++)
            {
                Debug.Log("itemButton" + i);
                itemButton[i].GetComponent<Image>().color = Color.white;
            }
        }
        else
        {
            for (int i = 0; i < itemButton.Length; i++)
            {
                itemButton[i].GetComponent<Image>().color = Color.white;
            }
        }
    }
    public GameObject ImageOn;
    public void Pendant()
    {
        ImageOn.SetActive(true);
    }
    public GameObject Fill;
    public GameObject batteryon;
    public GameObject GoToEnding;
    public void BatteryOn()
    {
        Fill.SetActive(true);
        batteryon.SetActive(true);
        GoToEnding.SetActive(true);
    }
    public GameObject BImage;
    public void Experiment()
    {
        before[5].sprite = changeImage[8];
        before[5].GetComponent<RectTransform>().sizeDelta = new Vector2(445, 445);
        before[5].GetComponent<RectTransform>().anchoredPosition = new Vector3(-70, 130, 0);
        BImage.SetActive(true);
    }
    public GameObject AImage;
    public GameObject CImage;
    public GameObject battery;
    public void Battery()
    {
        AImage.SetActive(false);
        CImage.SetActive(true);
        battery.SetActive(true);
    }
    public GameObject TB10;
    public void SOS()
    {
        audiosource.clip = SoS;
        audiosource.Play();
        ImageOn.SetActive(true);
        batteryon.SetActive(true);
        TB10.SetActive(true);
    }
    public void WrongSound()
    {
        audiosource.clip = wrongSound;
        audiosource.Play();
    }
    public void RotateDialSound()
    {
        audiosource.clip = rotatedial;
        audiosource.Play();
    }
    public void CheckUse()
    {
        Debug.Log("currentItemNo" + currentItemNo);
        itemButton[currentItemNo].button.interactable = false;
        itemButton[currentItemNo].itemIcon.sprite = itemSprite[0];
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
    public GameObject sinkbutton;
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
    public GameObject Activate;
    public GameObject dial1;
    public void DialKey()
    {
        before[3].sprite = GameManager.Instance.changeImage[2];
        before[3].GetComponent<RectTransform>().sizeDelta = new Vector2(150, 150);
        Activate.SetActive(false);
    }
    public GameObject aisle4F;
    public GameObject coffer;
    public GameObject Fade;
    public void NewKey()
    {
        aisle4F.SetActive(false);
        coffer.SetActive(true);
        Fade.SetActive(false);
        Fade.SetActive(true);
    }
    public void TalkTexting(string dial)
    {
        talkGUI.TalkText(dial);
        talkGUI.gameObject.SetActive(true);
        isTexting = true;
        Invoke("TalkGUIOff", 1.5f);
    }
    public void JailSound()
    {
        audiosource.clip = openJail;
        audiosource.Play();
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
                        PlayerPrefs.SetInt("isDialClear", 1);
                    }
                }
            }
        }
    }

}