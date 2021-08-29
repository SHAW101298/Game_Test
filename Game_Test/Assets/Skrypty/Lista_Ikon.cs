using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lista_Ikon : MonoBehaviour
{
    #region
    public static Lista_Ikon ins;
    public void StworzReferencje()
    {
        ins = this;
    }
    #endregion

    public List<Sprite> ikony;
}
