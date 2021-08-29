using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[SerializeField]
public class Postac 
{
	public int id = 0;
	public int doswiadczenie = 0;
	public int poziom = 0;
	public int zdrowie = 1;
	public int maks_Zdrowie = 1;
	public int sila = 1;
	public int wytrzymalosc = 1;
	public int zrecznosc= 1;
	public int pancerz = 1;
	public int szansa_Na_Cios_Krytyczny = 0;

	public int aktualna_grupa = -1;

	public void UstawStatystyki()
    {
		maks_Zdrowie = wytrzymalosc * 5;
		zdrowie = maks_Zdrowie;
		szansa_Na_Cios_Krytyczny = zrecznosc / 2;
    }
	public void ZwiekszDoswiadczenie(int exp)
    {
		doswiadczenie += exp;
    }
}
