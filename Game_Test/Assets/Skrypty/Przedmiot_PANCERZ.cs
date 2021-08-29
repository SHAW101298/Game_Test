using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pancerz", menuName = "CUSTOM/Przedmioty/Pancerz")]
public class Przedmiot_PANCERZ : Przedmiot
{
    [Space(15)]
    public ENUM_czesc_pancerza czesc_pancerza;
    public int pancerz;

    private void Awake()
    {
        typ_przedmiotu = ENUM_typ_przedmiotu.pancerz;
    }
}
