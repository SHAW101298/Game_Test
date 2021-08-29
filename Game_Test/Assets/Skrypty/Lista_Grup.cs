using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Lista_Grup 
{
	[SerializeField]
	public List<Grupa_Postaci> grupy;

	public Grupa_Postaci ZwrocGrupe(int id)
    {
		Grupa_Postaci temp = grupy.Find(grupa => grupa.id == id);
		return temp;
    }
}
