using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inicjalizacja : MonoBehaviour 
{
	public static Inicjalizacja ins;
	public Konsola konsola;
	public System_XML xml;
	public Zarzadzanie_Postacie zarzadzanie_postaciami;
	public Zarzadzanie_Misje zarzadzanie_misjami;
	public Zarzadzanie_UI zarzadzanie_ui;
	public Zarzadzanie_Grupy zarzadzanie_grupami;
	public Zarzadzanie_Przedmioty zarzadanie_przedmiotami;
	public Lista_Ikon lista_ikon;

	public Zarzadzanie_Grupy_UI zarzadzanie_grupy_UI;
	public Zarzadzanie_Misje_UI zarzadzanie_misje_UI;
	
	public void StworzReferencje()
	{
		ins = this;
		konsola.Log("Stworzono Referencje Do Inicjalizacji");
	}
	// Use this for initialization
	void Start () 
	{
		StworzReferencje();
		InicjalizujObiekty();
		WczytajPliki();
	}

	void InicjalizujObiekty()
    {
		Debug.Log("Inicjalizacja Podstawowych Obiektow");
		xml.StworzReferencje();
		zarzadzanie_postaciami.StworzReferencje();
		zarzadzanie_misjami.StworzReferencje();
		zarzadzanie_grupami.StworzReferencje();
		zarzadzanie_ui.StworzReferencje();
		zarzadanie_przedmiotami.StworzReferencje();
		lista_ikon.StworzReferencje();

		zarzadzanie_misje_UI.StworzReferencje();
	}
	void WczytajPliki()
    {
		Debug.Log("Wczytywanie danych z plikow");
		zarzadzanie_postaciami.WczytajPostacieZPliku();
		//zarzadzanie_misjami.WczytajMisjeZPliku();
		zarzadzanie_grupami.WczytajPostacieZPliku();


		xml.Zapisz_ListaPostaci(zarzadzanie_postaciami.lista_postaci);
    }
	void PokazMenu()
    {

    }
}
