using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bron", menuName = "CUSTOM/Przedmioty/Bron")]
public class Przedmiot_BRON : Przedmiot
{
    [Space(15)]
    public int obrazenia;
    private void Awake()
    {
        typ_przedmiotu = ENUM_typ_przedmiotu.bron;
    }
}
