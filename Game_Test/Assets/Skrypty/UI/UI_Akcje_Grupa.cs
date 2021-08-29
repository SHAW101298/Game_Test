using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Akcje_Grupa : MonoBehaviour 
{
    public int id;
    public Text nazwa;
    public Image progress; // Pasek postepu misji
    public Grupa_Postaci grupa;

    public void NacisnietoGrupe()
    {
        Debug.Log("Wcisnieto grupe | " + id);
        Zarzadzanie_Grupy.ins.ostatnia_misja.grupa_id = id;
    }

    private void Update()
    {
        Wykonanie_Misji();
    }
    void RozdajNagrody()
    {
        int id_tablicy = Zarzadzanie_Misje.ins.ZwrocMisje(grupa.id_misji).tablica_nagrod;
        Zarzadzanie_Przedmioty.ins.DodajPrzedmioty(id_tablicy);

        foreach (Postac postac in grupa.postacie)
        {
            postac.ZwiekszDoswiadczenie(Zarzadzanie_Misje.ins.ZwrocMisje(grupa.id_misji).doswiadczenie);
        }

    }
    public void Wykonanie_Misji()
    {
        if (grupa.na_misji)
        {
            progress.fillAmount = 1 - grupa.czas_do_powrotu / grupa.max_czas;
            grupa.czas_do_powrotu -= Time.deltaTime;
            if (grupa.czas_do_powrotu <= 0)
            {
                RozdajNagrody();
                grupa.czas_do_powrotu += grupa.max_czas;
            }
        }
    }
}
