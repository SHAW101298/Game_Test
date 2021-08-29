using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Postacie : MonoBehaviour 
{
    public Lista_Postaci lista_postaci;
    public List<GameObject> lista_elementow;
    [Header("Referencje")]
    public GameObject container;
    public GameObject prefab;
    public Pokazanie_Statystyk_Postaci statystyki;

    [Header("Dynmic")]
    public GameObject wybrana_postac;
    

    public void StworzReferencje()
    {
        lista_postaci = Zarzadzanie_Postacie.ins.lista_postaci;
    }

    public void AktualizujZawartosc()
    {
        foreach(GameObject element in lista_elementow)
        {
            Destroy(element);
        }
        lista_elementow.Clear();
        for (int i = 0; i < lista_postaci.posiadane_postacie.Count;i++)
        {
            lista_elementow.Add(Instantiate(prefab));
            lista_elementow[i].transform.SetParent(container.transform);
            lista_elementow[i].GetComponent<UI_Akcje_Postac>().postac = lista_postaci.posiadane_postacie[i];
            lista_elementow[i].GetComponent<UI_Akcje_Postac>().AktualizujDane();
        }
    }

    public void PokazStatystykiPostaci(Postac postac)
    {
        statystyki.AktualizujDane(postac);
    }
}
