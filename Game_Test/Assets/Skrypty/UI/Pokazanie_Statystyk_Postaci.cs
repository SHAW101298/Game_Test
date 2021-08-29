using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pokazanie_Statystyk_Postaci : MonoBehaviour 
{
    public GameObject okno_statystyk;
    public Text imie;
    public Text poziom;
    public Text doswiadczenie;
    public Text zdrowie;
    public Text sila;
    public Text wytrzymalosc;
    public Text zrecznosc;
    public Text pancerz;
    public Text szansa_na_kryt;

    public void AktualizujDane(Postac postac)
    {
        imie.text = "Imie: " + postac.id.ToString();
        poziom.text = "Poziom: " + postac.poziom.ToString();
        doswiadczenie.text = "Doswiadczenie: " + postac.doswiadczenie.ToString();
        zdrowie.text = "Zdrowie: " + postac.zdrowie.ToString();
        sila.text = "Sila: " + postac.sila.ToString();
        wytrzymalosc.text = "Wytrzymalosc: " + postac.wytrzymalosc.ToString();
        zrecznosc.text = "Zrecznosc: " + postac.zrecznosc.ToString();
        pancerz.text = "Pancerz: " + postac.pancerz.ToString();
        szansa_na_kryt.text = "Szansa Na Cios Krytyczny: " + postac.szansa_Na_Cios_Krytyczny.ToString();
        PokazOkno();
    }
    public void SchowajOkno()
    {
        Debug.Log("Pokazywanie Okna");
        okno_statystyk.SetActive(false);
    }
    public void PokazOkno()
    {
        okno_statystyk.SetActive(true);
    }
}
