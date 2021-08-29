using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Akcje_Grupa_Misja : MonoBehaviour
{
    public int id;
    public Text nazwa;

    public void BTN_MisjaNacisnieta()
    {
        Debug.Log("Nacisnieto Na Misje");
        Zarzadzanie_Grupy.ins.ostatnia_misja.misja_id = id;
        Zarzadzanie_Misje_UI.ins.PokazNagrodyZaMisje(id);
    }
}
