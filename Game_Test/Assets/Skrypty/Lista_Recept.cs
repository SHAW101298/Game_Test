using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista_Recept : MonoBehaviour
{
    public Recepta[] lista;

    public Recepta ZwrocPrzedmiot(int id)
    {
        //Przedmiot temp = lista_przedmiotow.Find(przedmiot => przedmiot.id == id);
        Recepta temp = Array.Find(lista, recepta => recepta.id == id);
        return temp;
    }
}
