using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aisle3F : MonoBehaviour
{
    private void Update()
    {
        Onclicked_OK();
    }
    public Text numbering;
    public int num;
    public string passward = "1241";
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
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject G;
    public GameObject A;

    public void Cbutton()
    {
        C.GetComponent<Animation>().Play("calpha");
        GameManager.Instance.DoSound();
        numbering.text += "0";
    }
    public void Dbutton()
    {
        D.GetComponent<Animation>().Play("dalpha");
        GameManager.Instance.ReSound();
        numbering.text += "1";
    }
    public void Ebutton()
    {
        E.GetComponent<Animation>().Play("ealpha");
        GameManager.Instance.MiSound();
        numbering.text += "2";
    }
    public void Gbutton()
    {
        G.GetComponent<Animation>().Play("galpha");
        GameManager.Instance.SolSound();
        numbering.text += "3";
    }
    public void Abutton()
    {
        A.GetComponent<Animation>().Play("aalpha");
        GameManager.Instance.RaSound();
        numbering.text += "4";
    }
    public GameObject Clear;
    public void Onclicked_OK()
    {
        if (numbering.text.Length == 4)
        {
            if (numbering.text == passward)
            {
                GameManager.Instance.JailSound();
                Clear.SetActive(true);
            }
            else
            {
                GameManager.Instance.WrongSound();
                numbering.text = "";
            }
        }
    }
}
