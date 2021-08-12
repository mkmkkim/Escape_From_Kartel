using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dial : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public void OnClickNo1()
    {
        button1.transform.Rotate(0.0f, 0.0f, -15.0f);
        EscapeGM.Instance.buttoncnt1++;
    }
    public void OnClickNo2()
    {
        button2.transform.Rotate(0.0f, 0.0f, 30.0f);
        EscapeGM.Instance.buttoncnt2++;
    }
    public void OnClickNo3()
    {
        button3.transform.Rotate(0.0f, 0.0f, -45.0f);
        EscapeGM.Instance.buttoncnt3++;
    }
    public void OnClickNo4()
    {
        button4.transform.Rotate(0.0f, 0.0f, 60.0f);
        EscapeGM.Instance.buttoncnt4++;
    }
}
