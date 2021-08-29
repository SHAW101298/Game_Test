using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Postac_Grupa_Akcje : MonoBehaviour 
{
    public Text nazwa;
    public int id;
    public bool wybrany;
    public Image checkBox;

    public void WcisnietoPostac()
    {
        wybrany = !wybrany;

        if(wybrany == true)
        {
            checkBox.color = Color.green;
        }
        else
        {
            checkBox.color = Color.red;
        }
    }
}
