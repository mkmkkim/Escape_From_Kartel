using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coffer : MonoBehaviour
{
    public Image[] before;
    public Sprite[] number;
    public Sprite[] alpha;
    public int numcnt1;
    public int numcnt2;
    public int alphacnt1;
    public int alphacnt2;
    private void Update()
    {
        Check();
    }
    public void Numberdial1()
    {
        GameManager.Instance.PressKey();
        numcnt1 += 1;
        if (numcnt1 % 6 == 0)
        {
            before[1].sprite = number[0];
        }
        else if (numcnt1 % 6 == 1)
        {
            before[1].sprite = number[1];
        }
        else if (numcnt1 % 6== 2)
        {
            before[1].sprite = number[2];
        }
        else if (numcnt1 % 6 == 3)
        {
            before[1].sprite = number[3];
        }
        else if (numcnt1 % 6 == 4)
        {
            before[1].sprite = number[4];
        }
        else if (numcnt1% 6 == 5)
        {
            before[1].sprite = number[5];
        }
    }
    public void Numberdial2()
    {
        GameManager.Instance.PressKey();
        numcnt2 += 1;
        if (numcnt2 % 6 == 0)
        {
            before[3].sprite = number[0];
        }
        else if (numcnt2 % 6 == 1)
        {
            before[3].sprite = number[1];
        }
        else if (numcnt2 % 6 == 2)
        {
            before[3].sprite = number[2];
        }
        else if (numcnt2 % 6 == 3)
        {
            before[3].sprite = number[3];
        }
        else if (numcnt2 % 6 == 4)
        {
            before[3].sprite = number[4];
        }
        else if (numcnt2 % 6 == 5)
        {
            before[3].sprite = number[5];
        }
    }
    public void Alphadial1()
    {
        GameManager.Instance.PressKey();
        alphacnt1 += 1;
        if (alphacnt1 % 6 == 0)
        {
            before[0].sprite = alpha[0];
        }
        else if (alphacnt1 % 6 == 1)
        {
            before[0].sprite = alpha[1];
        }
        else if (alphacnt1 % 6 == 2)
        {
            before[0].sprite = alpha[2];
        }
        else if (alphacnt1 % 6 == 3)
        {
            before[0].sprite = alpha[3];
        }
        else if (alphacnt1 % 6 == 4)
        {
            before[0].sprite = alpha[4];
        }
        else if (alphacnt1 % 6 == 5)
        {
            before[0].sprite = alpha[5];
        }
    }
    public void Alphadial2()
    {
        GameManager.Instance.PressKey();
        alphacnt2 += 1;
        if (alphacnt2 % 6 == 0)
        {
            before[2].sprite = alpha[0];
        }
        else if (alphacnt2 % 6 == 1)
        {
            before[2].sprite = alpha[1];
        }
        else if (alphacnt2 % 6 == 2)
        {
            before[2].sprite = alpha[2];
        }
        else if (alphacnt2 % 6 == 3)
        {
            before[2].sprite = alpha[3];
        }
        else if (alphacnt2 % 6 == 4)
        {
            before[2].sprite = alpha[4];
        }
        else if (alphacnt2 % 6 == 5)
        {
            before[2].sprite = alpha[5];
        }
    }
    public Button cofferbutton;
    public void Check()
    {
        if (alphacnt1 % 6 == 2)
        {
            if (numcnt1 % 6 == 2)
            {
                if (alphacnt2 % 6 == 5)
                {
                    if (numcnt2 % 6 == 3)
                    {
                        cofferbutton.interactable = true;
                        before[0].gameObject.SetActive(false);
                        before[1].gameObject.SetActive(false);
                        before[2].gameObject.SetActive(false);
                        before[3].gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
