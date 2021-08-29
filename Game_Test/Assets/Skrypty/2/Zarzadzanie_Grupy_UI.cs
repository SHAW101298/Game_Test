using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarzadzanie_Grupy_UI : MonoBehaviour
{
    public static Zarzadzanie_Grupy_UI ins;
    private void Awake()
    {
        ins = this;
    }

    public GameObject grupy_content;
    public List<GameObject> grupy_istniejace_obiekty;
    public GameObject grupa_prefab;

    public GameObject postacie_content;
    public List<GameObject> postacie_istniejace_obiekty;
    public GameObject postac_prefab;

    [Header("Referencje")]
    public GameObject okno_Grupy;
    public GameObject okno_Postacie;
    public GameObject okno_Misje;

    public UI_Akcje_Grupa_Tworzenie temp_grupa;

    public void ZaktualizujListeGrup()
    {
        ResetujOkno();
        UI_Akcje_Grupa temp_grupa;
        foreach (GameObject obiekt in grupy_istniejace_obiekty)
        {
            Destroy(obiekt);
        }
        grupy_istniejace_obiekty.Clear();
        for (int i = 0; i < Zarzadzanie_Grupy.ins.lista_grup.grupy.Count; i++)
        {
            grupy_istniejace_obiekty.Add(Instantiate(grupa_prefab));
            grupy_istniejace_obiekty[i].transform.SetParent(grupy_content.transform);

            temp_grupa = grupy_istniejace_obiekty[i].GetComponent<UI_Akcje_Grupa>();
            temp_grupa.id = Zarzadzanie_Grupy.ins.lista_grup.grupy[i].id;
            temp_grupa.nazwa.text = Zarzadzanie_Grupy.ins.lista_grup.grupy[i].nazwa + " | " + temp_grupa.id;
            temp_grupa.grupa = Zarzadzanie_Grupy.ins.lista_grup.grupy[i];
            Debug.Log(temp_grupa.grupa.id + " | " + Zarzadzanie_Grupy.ins.lista_grup.grupy[i].id);
        }
    }
    public void BTN_ZapiszGrupe()
    {
        Grupa_Postaci nowa_grupa = new Grupa_Postaci();
        foreach (GameObject obiekt in postacie_istniejace_obiekty)
        {
            if (obiekt.GetComponent<UI_Akcje_Grupa_Tworzenie>().wybrana == true)
            {
                Postac postac = Zarzadzanie_Postacie.ins.ZwrocPostac(obiekt.GetComponent<UI_Akcje_Grupa_Tworzenie>().id);
                postac.aktualna_grupa = nowa_grupa.id;
                nowa_grupa.postacie.Add(postac);
            }
        }

        if (nowa_grupa.postacie.Count > 0)
        {
            Zarzadzanie_Grupy.ins.PrzyznajIdDlaGrupy(nowa_grupa);
            Zarzadzanie_Grupy.ins.lista_grup.grupy.Add(nowa_grupa);
        }
        else
        {
            nowa_grupa = null;
        }


        ResetujOkno();
        WyczyscStworzonePostacie();
        ZaktualizujListeGrup();
    }

    public void StworzPostacieDoGrupy()
    {
        if (Zarzadzanie_Grupy.ins.dostepne_postacie.Count > 0)
        {
            //UI_Akcje_Grupa_Tworzenie temp_grupa;

            WyczyscStworzonePostacie();

            for (int i = 0; i < Zarzadzanie_Grupy.ins.dostepne_postacie.Count; i++)
            {
                postacie_istniejace_obiekty.Add(Instantiate(postac_prefab));
                postacie_istniejace_obiekty[i].transform.SetParent(postacie_content.transform);

                temp_grupa = postacie_istniejace_obiekty[i].GetComponent<UI_Akcje_Grupa_Tworzenie>();
                temp_grupa.id = Zarzadzanie_Grupy.ins.dostepne_postacie[i].id;
            }
        }
    }
    public void ResetujOkno()
    {
        Zarzadzanie_Grupy.ins.dostepne_postacie.Clear();
        okno_Grupy.SetActive(true);
        okno_Postacie.SetActive(false);
        okno_Misje.SetActive(true);
    }
    void WyczyscStworzonePostacie()
    {
        foreach (GameObject obiekt in postacie_istniejace_obiekty)
        {
            Destroy(obiekt);
        }
        postacie_istniejace_obiekty.Clear();
    }

}
