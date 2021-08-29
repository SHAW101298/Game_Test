using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Podstawowy Przedmiot", menuName ="CUSTOM/Przedmioty/Default")]
public class Przedmiot : ScriptableObject
{
    public int id;
    public string nazwa;
    public ENUM_typ_przedmiotu typ_przedmiotu;
    public int id_ikony;
    public int wartosc;
}
