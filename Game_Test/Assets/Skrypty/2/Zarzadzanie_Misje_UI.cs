using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zarzadzanie_Misje_UI : MonoBehaviour
{
    #region
    public static Zarzadzanie_Misje_UI ins;
    public void StworzReferencje()
    {
        ins = this;
    }
    #endregion

    public GameObject prefab_nagrody;
    public GameObject nagrody_container;
    public Text nazwa_misji_text;
    public List<GameObject> obiekty_w_container;
    GameObject dynamic_inst;
    Nagroda_Ikona dynamic_iko;

    public void PokazNagrodyZaMisje(LOOT_TABLES tablica)
    {
        GameObject temp;
        foreach (GameObject obiekt in obiekty_w_container)
        {
            Destroy(obiekt);
        }
        obiekty_w_container.Clear();

        foreach (Przedmiot_w_Ekwipunku przedmiot in tablica.gwarantowane_nagrod)
        {
            dynamic_inst = Instantiate(prefab_nagrody);
            dynamic_inst.transform.SetParent(nagrody_container.transform);
            dynamic_iko = dynamic_inst.GetComponent<Nagroda_Ikona>();
            dynamic_iko.nazwa.text = przedmiot.przedmiot.nazwa + " : " + przedmiot.ilosc;
            dynamic_iko.ikona.sprite = Lista_Ikon.ins.ikony[przedmiot.przedmiot.id_ikony];
        }
    }
    public void PokazNagrodyZaMisje(int id)
    {
        Misja misja = Zarzadzanie_Misje.ins.ZwrocMisje(id);
        LOOT_TABLES tablica = Zarzadzanie_Przedmioty.ins.ZwrocTablice(misja.tablica_nagrod);
        GameObject temp;

        nazwa_misji_text.text = misja.nazwa;

        foreach (GameObject obiekt in obiekty_w_container)
        {
            Destroy(obiekt);
        }
        obiekty_w_container.Clear();

        foreach (Przedmiot_w_Ekwipunku przedmiot in tablica.gwarantowane_nagrod)
        {
            dynamic_inst = Instantiate(prefab_nagrody);
            dynamic_inst.transform.SetParent(nagrody_container.transform);
            dynamic_iko = dynamic_inst.GetComponent<Nagroda_Ikona>();
            dynamic_iko.nazwa.text = przedmiot.przedmiot.nazwa + " : " + przedmiot.ilosc;
            dynamic_iko.ikona.sprite = Lista_Ikon.ins.ikony[przedmiot.przedmiot.id_ikony];
            obiekty_w_container.Add(dynamic_inst);
        }
    }
}
