using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zarzadzanie_Przedmioty_UI : MonoBehaviour
{
    public GameObject bronie_okno;
    public GameObject bronie_content;
    public List<GameObject> bronie_obiekty;

    public GameObject pancerze_okno;
    public GameObject pancerze_content;
    public List<GameObject> pancerze_obiekty;

    public GameObject materialy_okno;
    public GameObject materialy_content;
    public List<GameObject> materialy_obiekty;

    public GameObject crafting_okno;
    public GameObject crafting_content;
    public List<GameObject> crafting_obiekty;
    public Lista_Recept recepty_lista;

    [SerializeField]
    GameObject WND_LAST;

    GameObject dynamic_inst;
    public GameObject prefab_przedmiotu;
    public GameObject prefab_recepty;
    Nagroda_Ikona dynamic_iko;

    public void BTN_Bronie()
    {
        Debug.Log("BTN BRONIE");
        WND_LAST.SetActive(false);
        bronie_okno.SetActive(true);
        WND_LAST = bronie_okno;
        AktualizujBronie();
    }
    public void BTN_Pancerze()
    {
        Debug.Log("BTN PANCERZE");
        WND_LAST.SetActive(false);
        pancerze_okno.SetActive(true);
        WND_LAST = pancerze_okno;
        AktualizujPancerze();
    }
    public void BTN_Materialy()
    {
        Debug.Log("BTN MATERIALY");
        WND_LAST.SetActive(false);
        materialy_okno.SetActive(true);
        WND_LAST = materialy_okno;
        AktualizujMaterialy();
    }

    public void BTN_Crafting()
    {
        Debug.Log("BTN CRAFTING");
        WND_LAST.SetActive(false);
        crafting_okno.SetActive(true);
        WND_LAST = crafting_okno;
        AktualizujCrafting();
    }

    public void AktualizujBronie()
    {
        foreach(GameObject bron in bronie_obiekty)
        {
            Destroy(bron);
        }
        bronie_obiekty.Clear();

        foreach (Przedmiot_w_Ekwipunku przedmiot in Zarzadzanie_Przedmioty.ins.ekwipunek.ekwipunek)
        {
            if(przedmiot.przedmiot.typ_przedmiotu == ENUM_typ_przedmiotu.bron)
            {
                dynamic_inst = Instantiate(prefab_przedmiotu);
                dynamic_inst.transform.SetParent(bronie_content.transform);
                bronie_obiekty.Add(dynamic_inst);

                dynamic_iko = dynamic_inst.GetComponent<Nagroda_Ikona>();
                dynamic_iko.nazwa.text = przedmiot.przedmiot.nazwa + " : " + przedmiot.ilosc;
                dynamic_iko.ikona.sprite = Lista_Ikon.ins.ikony[przedmiot.przedmiot.id_ikony];
            }
        }
    }
    public void AktualizujPancerze()
    {
        foreach (GameObject pancerz in pancerze_obiekty)
        {
            Destroy(pancerz);
        }
        pancerze_obiekty.Clear();

        foreach (Przedmiot_w_Ekwipunku przedmiot in Zarzadzanie_Przedmioty.ins.ekwipunek.ekwipunek)
        {
            if (przedmiot.przedmiot.typ_przedmiotu == ENUM_typ_przedmiotu.pancerz)
            {
                dynamic_inst = Instantiate(prefab_przedmiotu);
                dynamic_inst.transform.SetParent(pancerze_content.transform);
                pancerze_obiekty.Add(dynamic_inst);

                dynamic_iko = dynamic_inst.GetComponent<Nagroda_Ikona>();
                dynamic_iko.nazwa.text = przedmiot.przedmiot.nazwa + " : " + przedmiot.ilosc;
                dynamic_iko.ikona.sprite = Lista_Ikon.ins.ikony[przedmiot.przedmiot.id_ikony];
            }
        }
    }
    public void AktualizujMaterialy()
    {
        foreach (GameObject material in materialy_obiekty)
        {
            Destroy(material);
        }
        materialy_obiekty.Clear();

        foreach (Przedmiot_w_Ekwipunku przedmiot in Zarzadzanie_Przedmioty.ins.ekwipunek.ekwipunek)
        {
            if (przedmiot.przedmiot.typ_przedmiotu == ENUM_typ_przedmiotu.material)
            {
                dynamic_inst = Instantiate(prefab_przedmiotu);
                dynamic_inst.transform.SetParent(materialy_content.transform);
                materialy_obiekty.Add(dynamic_inst);

                dynamic_iko = dynamic_inst.GetComponent<Nagroda_Ikona>();
                dynamic_iko.nazwa.text = przedmiot.przedmiot.nazwa + " : " + przedmiot.ilosc;
                dynamic_iko.ikona.sprite = Lista_Ikon.ins.ikony[przedmiot.przedmiot.id_ikony];
            }
        }
    }
    public void AktualizujCrafting()
    {
        Debug.Log("Crafting jest stały, nie ma co aktualizować");
        // return;

        UI_Akcje_Recepta temp;

        foreach (GameObject recepta in crafting_obiekty)
        {
            Destroy(recepta);
        }
        crafting_obiekty.Clear();

        foreach (Recepta recepta in recepty_lista.lista)
        {
            dynamic_inst = Instantiate(prefab_recepty);
            dynamic_inst.transform.SetParent(crafting_content.transform);
            crafting_obiekty.Add(dynamic_inst);

            temp = dynamic_inst.GetComponent<UI_Akcje_Recepta>();
            temp.recepta = recepta;
            temp.nazwa.text = recepta.nazwa;
            temp.gameObject.GetComponent<Image>().sprite = Lista_Ikon.ins.ikony[recepta.rezultat.przedmiot.id_ikony];
        }
    }
}
