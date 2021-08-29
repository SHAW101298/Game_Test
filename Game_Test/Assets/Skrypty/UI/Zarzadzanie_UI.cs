using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarzadzanie_UI : MonoBehaviour 
{
	[Header("Referencje Okien")]
	public GameObject WND_Main;
	public GameObject WND_Postacie;
	public GameObject WND_Grupy;
	public GameObject WND_Przedmioty;
	public GameObject WND_Opcje;
	public GameObject WND_Wyjscie;
	[Header("Referencje Skryptow")]
	public Zarzadzanie_Postacie postacie;
	public Zarzadzanie_Grupy grupy;

	public Zarzadzanie_Grupy_UI grupy_ui;

	[SerializeField]
	GameObject WND_LAST;


	public void BTN_Postacie()
    {
		//WND_LAST.SetActive(false);
		//WND_Postacie.SetActive(true);
		WND_LAST.transform.localScale = new Vector3(0, 0, 0);
		WND_Postacie.transform.localScale = new Vector3(1, 1, 1);
		WND_LAST = WND_Postacie;
		postacie.Aktualizuj_ListePostaci();
    }
    public void BTN_Grupy()
    {
		Debug.Log("BTN_Grupy");
		//WND_LAST.SetActive(false);
		//WND_Grupy.SetActive(true);
		WND_LAST.transform.localScale = new Vector3(0, 0, 0);
		WND_Grupy.transform.localScale = new Vector3(1, 1, 1);
		WND_LAST = WND_Grupy;
		Zarzadzanie_Grupy_UI.ins.ZaktualizujListeGrup();
		//grupy_ui.ZaktualizujListeGrup();
		//grupy.Aktualizuj_ListeGrup();
	}
	public void BTN_Przedmioty()
    {
		//WND_LAST.SetActive(false);
		//WND_Przedmioty.SetActive(true);
		WND_LAST.transform.localScale = new Vector3(0, 0, 0);
		WND_Przedmioty.transform.localScale = new Vector3(1, 1, 1);
		WND_LAST = WND_Przedmioty;
	}
	public void BTN_Opcje()
    {
		//WND_LAST.SetActive(false);
		//WND_Opcje.SetActive(true);
		WND_LAST.transform.localScale = new Vector3(0, 0, 0);
		WND_Opcje.transform.localScale = new Vector3(1, 1, 1);
		WND_LAST = WND_Opcje;
	}
	public void BTN_Wyjscie()
    {
		//WND_LAST.SetActive(false);
		//WND_Wyjscie.SetActive(true);
		WND_LAST.transform.localScale = new Vector3(0, 0, 0);
		WND_Wyjscie.transform.localScale = new Vector3(1, 1, 1);
		WND_LAST = WND_Wyjscie;
	}


	public static Zarzadzanie_UI ins;
	public void StworzReferencje()
	{
		Debug.Log("Zarzadzanie UI | Tworzenie Referencji");
		ins = this;
	}
}
