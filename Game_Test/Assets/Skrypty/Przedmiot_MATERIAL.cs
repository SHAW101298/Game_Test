using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Material", menuName = "CUSTOM/Przedmioty/Material")]
public class Przedmiot_MATERIAL : Przedmiot
{
    [Space(15)]
    public ENUM_typ_materialu typ_materialu;

    private void Awake()
    {
        typ_przedmiotu = ENUM_typ_przedmiotu.material;
    }
}
