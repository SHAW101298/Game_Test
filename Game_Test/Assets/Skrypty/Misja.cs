using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Misja", menuName = "CUSTOM/Misje")]
public class Misja : ScriptableObject
{
    public int id;
    public string nazwa;
    public int nagrody;
    public int doswiadczenie;
    public int poziom_trudnosci;
    public float czas;
    public int tablica_nagrod;
}
