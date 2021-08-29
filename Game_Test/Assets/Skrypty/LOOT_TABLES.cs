using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
//[SerializeField]
[CreateAssetMenu(fileName = "LOOT", menuName = "CUSTOM/LootTablica")]
public class LOOT_TABLES : ScriptableObject
{
    public int id_tablicy;
    public List<Przedmiot_w_Ekwipunku> gwarantowane_nagrod;
    public List<Przedmiot_w_Ekwipunku> mozliwe_nagrody;
    public List<int> szanse;
}
