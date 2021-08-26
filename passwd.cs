using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class passwd : MonoBehaviour
{
    public GameObject aisle_5F;
    public Text numbering;
    public int num;
    public string passward = "0918";
    public bool IsOK = false;


    public void Onclicked_Num(int num)
    {
        if (IsOK == true)
        {
            numbering.text = "";
        }
        else
        {
            numbering.text = num.ToString();
        }

        if (numbering.text == "")
        {
            numbering.text = num.ToString();
        }
        else
        {
            numbering.text += num;
        }
    }
    public void Onclicked_0()
    {
        numbering.text += "0";
    }
    public void Onclicked_1()
    {
        numbering.text += "1";
    }
    public void Onclicked_2()
    {
        numbering.text += "2";
    }
    public void Onclicked_3()
    {
        numbering.text += "3";
    }
    public void Onclicked_4()
    {
        numbering.text += "4";
    }
    public void Onclicked_5()
    {
        numbering.text += "5";
    }
    public void Onclicked_6()
    {
        numbering.text += "6";
    }
    public void Onclicked_7()
    {
        numbering.text += "7";
    }
    public void Onclicked_8()
    {
        numbering.text += "8";
    }
    public void Onclicked_9()
    {
        numbering.text += "9";
    }

    public void Onclicked_Cancel()
    {
        numbering.text = "";
    }
    public void Onclicked_OK()
    {
        if (numbering.text == passward)
        {
            GameManager.Instance.JailSound();
            this.gameObject.SetActive(false);
            aisle_5F.gameObject.SetActive(true);
        }
        else
        {
            numbering.text = "";
        }
    }
}
