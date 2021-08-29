using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Akcje_Grupa_Tworzenie : MonoBehaviour 
{
    public int id;
    public bool wybrana;
    public Image check_BOX;
    public Text nazwa;

    public void BTN_wybraniepostaci()
    {
        wybrana = !wybrana;
        if(wybrana == true)
        {
            check_BOX.color = Color.green;
        }
        else
        {
            check_BOX.color = Color.red;
        }
    }
}
