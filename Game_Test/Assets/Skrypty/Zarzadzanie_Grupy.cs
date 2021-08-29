using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarzadzanie_Grupy : MonoBehaviour 
{
    public static Zarzadzanie_Grupy ins;
    public void StworzReferencje()
    {
        ins = this;
    }

    public Lista_Grup lista_grup;

    [Header("UI")]
    public GameObject grupy_content;
    public GameObject postacie_content;
    public GameObject misje_content;
    public GameObject grupa_prefab;
    public GameObject postac_prefab;
    public GameObject misja_prefab;
    [Space(10)]
    public List<GameObject> grupy_obiekty;
    public List<GameObject> postacie_obiekty;
    [Header("Referencje")]
    public GameObject okno_Grupy;
    public GameObject okno_Postacie;
    public GameObject okno_Misje;
    public Ostatni_Wcisniety_Element ostatnia_misja;
    [Header("DEBUG ONLY")]
    public List<Postac> dostepne_postacie;

    public void WczytajPostacieZPliku()
    {
        Lista_Grup grupy = System_XML.ins.Wczytaj_ListeGrup();
        //Lista_Misji misje = System_XML.ins.Wczytaj_ListaMisji();
        /*
        if (misje != null)
        {
            lista_misji.wszystkie_misje = misje.wszystkie_misje;
            Debug.Log("Znaleziono liste misji w plikach gry");
        }
        else
        {
            lista_misji.wszystkie_misje = new List<Misja>();
            Debug.Log("Nie znaleziono listy misji w plikach gry");
        }
        */

        if (grupy != null)
        {
            lista_grup.grupy = grupy.grupy;
            Debug.Log("Znaleziono liste grup w plikach gry");
        }
        else
        {
            lista_grup.grupy = new List<Grupa_Postaci>();
            Debug.Log("Nie znaleziono listy grup w plikach gry");
        }
    }

    public void BTN_StworzNowaGrupe()
    {
        Debug.Log("Wcisnieto Przycisk Stworz Nowa Grupe");
        okno_Grupy.SetActive(false);
        okno_Postacie.SetActive(true);
        StworzPostacieDoGrupy();
    }
    
    
    public void BTN_WyslijNaMisje()
    {
        lista_grup.ZwrocGrupe(ostatnia_misja.grupa_id).WysylanieNaMisje(Zarzadzanie_Misje.ins.ZwrocMisje(ostatnia_misja.misja_id));
    }
    public void ResetujOkno()
    {
        dostepne_postacie.Clear();
        okno_Grupy.SetActive(true);
        okno_Postacie.SetActive(false);
        okno_Misje.SetActive(true);
    }
    public void StworzPostacieDoGrupy()
    {
        dostepne_postacie.Clear();
        dostepne_postacie = new List<Postac>();

        foreach (Postac postac in Zarzadzanie_Postacie.ins.lista_postaci.posiadane_postacie)
        {
            if (postac.aktualna_grupa != -1)
            {
                continue;
            }
            else
            {
                dostepne_postacie.Add(postac);
            }
        }
        Zarzadzanie_Grupy_UI.ins.StworzPostacieDoGrupy();
    }
    public void PrzyznajIdDlaGrupy(Grupa_Postaci grupa)
    {
        if (lista_grup.grupy.Count > 0)
        {
            grupa.id = lista_grup.grupy[lista_grup.grupy.Count - 1].id + 1;
        }
        else
        {
            grupa.id = 0;
        }
    }
    public Grupa_Postaci ZwrocGrupe(int id)
    {
        Grupa_Postaci temp = lista_grup.grupy.Find(grupa => grupa.id == id);
        return temp;
    }
}

