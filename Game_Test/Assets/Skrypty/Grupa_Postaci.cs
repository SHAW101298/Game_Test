using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[SerializeField]
public class Grupa_Postaci 
{
    public int id;
    public string nazwa;
    [SerializeField]
    public List<Postac> postacie = new List<Postac>();
    public bool na_misji = false;
    public int id_misji = -1;
    public bool wymus_zakonczenie = false;
    public float czas_do_powrotu = 0;
    public float max_czas = 0;

    public void WysylanieNaMisje(Misja misja)
    {
        Debug.Log("Grupa | " + id + " idzie na misje");
        id_misji = misja.id;
        czas_do_powrotu = misja.czas;
        na_misji = true;
        max_czas = misja.czas;
    }
}
