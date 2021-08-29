using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Akcje_Postac : MonoBehaviour 
{
    public Postac postac;
    public Text nazwa;

    public void NacisnietoPostac()
    {
        Debug.Log("Nalezy Wyswietlic Statystyki I Ekwipunek Postaci");
        Zarzadzanie_UI.ins.postacie.PokazStatystykiPostaci(postac);
    }
    public void AktualizujDane()
    {
        nazwa.text = postac.id.ToString();
    }
}
