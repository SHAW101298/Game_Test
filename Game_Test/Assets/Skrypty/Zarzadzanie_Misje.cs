using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zarzadzanie_Misje : MonoBehaviour
{
    #region 
    public static Zarzadzanie_Misje ins;
    public void StworzReferencje()
    {
        ins = this;
    }
    #endregion 

    public List<Misja> misje;
    public Misja[] misja;
    

    public Misja ZwrocMisje(int id)
    {
        Misja temp = misje.Find(misja => misja.id == id);
        return temp;
    }
    
}
