using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//[SerializeField]
public class Lista_Postaci 
{
	[SerializeField]
	public List<Postac> posiadane_postacie = new List<Postac>();

	public void DodajPostac(Postac postac)
	{
		posiadane_postacie.Add(postac);
	}
	public Postac ZwrocPostac(int id)
    {
		Postac postac = posiadane_postacie.Find(temp => temp.id == id);
		return postac;

	}
}
