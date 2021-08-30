using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ekwipunek : MonoBehaviour
{


    public List<Przedmiot_w_Ekwipunku> ekwipunek = new List<Przedmiot_w_Ekwipunku>();

    public bool zmieniona_ilosc;
    public bool zmieniona_zawartosc;

    public void DodajPrzedmiot(Przedmiot_w_Ekwipunku przedmiot)
    {
        bool kontrolka = false;
        for(int i = 0; i < ekwipunek.Count; i++)
        {
            // Sprawdzenie czy przedmiot jest w ekwipunku, oraz dodanie ilosci
            if(ekwipunek[i].przedmiot.id == przedmiot.przedmiot.id)
            {
                ekwipunek[i].ilosc += przedmiot.ilosc;
                zmieniona_ilosc = true;
                kontrolka = true;
            }
        }
        // Przedmiotu nie ma w ekwipunku. Tworzenie nowego obiektu i dodawanie do ekwipunku
        if(kontrolka == false)
        {
            Przedmiot_w_Ekwipunku nowy = new Przedmiot_w_Ekwipunku();
            nowy.ilosc = przedmiot.ilosc;
            nowy.przedmiot = przedmiot.przedmiot;
            ekwipunek.Add(nowy);
            zmieniona_zawartosc = true;
        }

        if(przedmiot.przedmiot.id == 0)
        {
            Zarzadzanie_UI.ins.AktualizujZloto(ekwipunek[0].ilosc);
        }
    }
}
