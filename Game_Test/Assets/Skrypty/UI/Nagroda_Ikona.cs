using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Nagroda_Ikona : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int id_przedmiotu;
    public int ilosc;
    public Image ikona;
    public Text nazwa;

    public void OnPointerEnter(PointerEventData eventData)
    {
        nazwa.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        nazwa.gameObject.SetActive(false);
    }

    
}
