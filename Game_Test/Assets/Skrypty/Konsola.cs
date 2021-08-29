using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Konsola : MonoBehaviour
{
    public static Konsola ins;
    public void StworzReferencje()
    {
        ins = this;
        Log("Stworzono Referencje Do Konsoli");
    }
    [SerializeField]
    bool Debugowac;
    // FLAGI
    [SerializeField]
    bool podstawowe;
    [SerializeField]
    bool bledy;
    public void Log(string tekst)
    {
        if(Debugowac == true)
            Debug.Log(tekst);
    }
    public void Log(string tekst, object value)
    {
        if (Debugowac == true)
            Debug.Log(tekst + " = " + value);
    }
    public void Ost(string tekst)
    {
        if (Debugowac == true)
            Debug.LogWarning(tekst);
    }
    public void Blad(string tekst)
    {
        if (Debugowac == true)
            Debug.LogError(tekst);
    }

}
