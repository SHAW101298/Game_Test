using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarzadzanie_Postacie : MonoBehaviour 
{
	public static Zarzadzanie_Postacie ins;
	public void StworzReferencje()
    {
		ins = this;
    }

	[Header("Glowne")]
	[SerializeField]
	public Lista_Postaci lista_postaci;

	[Space(10)]
	[Header("UI")]
	public List<GameObject> lista_elementow;
	public GameObject container;
	public GameObject prefab;
	public Pokazanie_Statystyk_Postaci statystyki;

    [Header("Dynmic")]
    public GameObject wybrana_postac;

    public void WczytajPostacieZPliku()
    {
		Lista_Postaci temp = System_XML.ins.Wczytaj_ListaPostaci();
		if(temp != null)
        {
			lista_postaci.posiadane_postacie = temp.posiadane_postacie;
        }
		else
        {
			lista_postaci.posiadane_postacie = new List<Postac>();
        }
    }
	public void DodajPostac(Postac postac)
    {
		lista_postaci.DodajPostac(postac);
    }
    public Postac ZwrocPostac(int id)
    {
        Postac szukana_postac = lista_postaci.posiadane_postacie.Find(postac => postac.id == id);
        return szukana_postac;
    }

    // >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> //

    public void Aktualizuj_ListePostaci()
    {
        foreach (GameObject element in lista_elementow)
        {
            Destroy(element);
        }
        lista_elementow.Clear();
        for (int i = 0; i < lista_postaci.posiadane_postacie.Count; i++)
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
