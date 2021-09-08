using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Recepta Przedmiotu", menuName = "CUSTOM/Recepta/Default")]
public class Recepta : ScriptableObject
{
    public string nazwa;
    public int id;
    public Przedmiot_w_Ekwipunku[] wymagane;
    public Przedmiot_w_Ekwipunku rezultat;
}
