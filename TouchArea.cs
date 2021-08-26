using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchArea : MonoBehaviour
{
    Image touchArea;
    public int spaceNo;
    public int itemNo;
    public int interactNo;
    public string dialog_GetItem;


    // Start is called before the first frame update
    void Start()
    {
        touchArea = GetComponent<Image>();
        //       touchArea.enabled = false;
    }
    public void TouchedButton()
    {
        if (GameManager.Instance.isGameStart)
        {
            Debug.Log("이름 = " + gameObject.name);
                
            GameManager.Instance.TouchCheck(spaceNo, itemNo, dialog_GetItem);
            this.gameObject.SetActive(false);
        }
    }
    public void InteractButton()
    {
        if (!GameManager.Instance.isItemSelected)
        {
            GameManager.Instance.InteractCheck(0);
        }
        else
        {
            GameManager.Instance.InteractCheck(interactNo);
        }
    }
}