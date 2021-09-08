using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Akcje_Recepta : MonoBehaviour
{
    public Recepta recepta;
    public Text nazwa;

    public void NacisnietoRecepte()
    {
        Debug.Log("Nalezy Wyswietlic Skladniki Recepty");
    }
    public void AktualizujDane()
    {
        nazwa.text = recepta.id.ToString();
    }
}
