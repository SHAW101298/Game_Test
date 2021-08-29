using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarzadzanie_Przedmioty : MonoBehaviour
{
    public static Zarzadzanie_Przedmioty ins;
    public Ekwipunek ekwipunek;
    public Przedmiot[] lista_przedmiotow;
    //UnityEngine.Random rnd = new UnityEngine.Random();
    public int wylosowana_liczba;

    

    public void StworzReferencje()
    {
        ins = this;
    }

    public LOOT_TABLES[] tables;
    public LOOT_TABLES ZwrocTablice(int id)
    {
        //LOOT_TABLES temp = tables.Find(tablica => tablica.id_tablicy == id);
        LOOT_TABLES temp = Array.Find(tables, tablica => tablica.id_tablicy == id);
        return temp;
    }
    public void DodajPrzedmioty(int id)
    {
        LOOT_TABLES tablica = ZwrocTablice(id);
        Debug.Log("ID Loot Tablicy = " + id);
        
        // Dawanie gwarantowanych nagród
        foreach(Przedmiot_w_Ekwipunku przedmiot in tablica.gwarantowane_nagrod)
        {
            ekwipunek.DodajPrzedmiot(przedmiot);
            Debug.Log("Przedmiot = " + przedmiot.przedmiot.id + " | ilosc = " + przedmiot.ilosc);
        }
        // Dawanie możliwych nagród
        for(int i = 0; i < tablica.mozliwe_nagrody.Count; i++)
        {
            wylosowana_liczba = UnityEngine.Random.Range(1, 100);
            if (wylosowana_liczba <= tablica.szanse[i])
            {
                ekwipunek.DodajPrzedmiot(tablica.mozliwe_nagrody[i]);
                Debug.Log("Dodawanie BONUSU | " + tablica.mozliwe_nagrody[i].przedmiot.nazwa);
            }
        }

    }
    public Przedmiot ZwrocPrzedmiot(int id)
    {
        //Przedmiot temp = lista_przedmiotow.Find(przedmiot => przedmiot.id == id);
        Przedmiot temp = Array.Find(lista_przedmiotow, przedmiot => przedmiot.id == id);
        return temp;
    }
}
