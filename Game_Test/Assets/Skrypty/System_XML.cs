using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class System_XML : MonoBehaviour
{
    public static System_XML ins;
    public void StworzReferencje()
    {
        ins = this;
    }
    public static void Save(object item, string path)
    {
        XmlSerializer serializer = new XmlSerializer(item.GetType());
        StreamWriter writer = new StreamWriter(path);
        serializer.Serialize(writer.BaseStream, item);
        writer.Close();
    }
    public static T Load<T>(string path)
    {
        bool istnieje = File.Exists(path);
        if(istnieje)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader reader = new StreamReader(path);
            T deserialized = (T)serializer.Deserialize(reader.BaseStream);
            reader.Close();
            return deserialized;
        }
        return default(T);
        
    }

    public void Zapisz_ListaPostaci(Lista_Postaci lista)
    {
        Save(lista, Application.dataPath + "/Lista_Postaci.xml");
    }
    public Lista_Postaci Wczytaj_ListaPostaci()
    {
        Debug.Log("Wczytywanie Postaci");
        Lista_Postaci lista = Load<Lista_Postaci>(Application.dataPath + "/Lista_Postaci.xml");
        return lista;
    }
    public void Zapisz_ListeGrup(Lista_Grup grupa)
    {
        Save(grupa, Application.dataPath + "/Lista_Grup.xml");
    }
    public Lista_Grup Wczytaj_ListeGrup()
    {
        Lista_Grup lista = Load<Lista_Grup>(Application.dataPath + "/Lista_Grup.xml");
        return lista;
    }


    // OBSOLETE
    /*
    public Lista_Postaci WczytajListePostaci()
    {
        Lista_Postaci lista;
        bool kontrolka = File.Exists(Application.dataPath + "/Lista_Postaci.xml");
        if (kontrolka == false)
        {
            //Debug.Log(Application.dataPath + "/Lista_Postacie.xml");
            Debug.LogWarning("Plik nie istnieje, tworzenie pustej listy");
            lista = new Lista_Postaci();
            return lista;
        }

        XmlSerializer serializer = new XmlSerializer(typeof(Lista_Postaci));
        //Debug.Log(Application.dataPath);
        FileStream stream = new FileStream(Application.dataPath + "/Lista_Postaci.xml", FileMode.OpenOrCreate);

        lista = serializer.Deserialize(stream) as Lista_Postaci;

        stream.Close();

        return lista;
    }
    public void ZapiszListePostaci(Lista_Postaci lista)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Lista_Postaci));
        FileStream stream = new FileStream(Application.dataPath + "/Lista_Postaci.xml", FileMode.Create);
        serializer.Serialize(stream, lista);
        stream.Close();
    }
    public Lista_Misji WczytajListeMisji()
    {
        Lista_Misji lista;

        bool kontrolka = File.Exists(Application.dataPath + "/Lista_Misji.xml");
        if (kontrolka == false)
        {
            //Debug.Log(Application.dataPath + "/Lista_Postacie.xml");
            Debug.LogWarning("Plik nie istnieje, tworzenie pustej listy");
            lista = new Lista_Misji();
            return lista;
        }


        XmlSerializer serializer = new XmlSerializer(typeof(Lista_Misji));
        FileStream stream = new FileStream(Application.dataPath + "Lista_Misji.xml", FileMode.OpenOrCreate);

        lista = serializer.Deserialize(stream) as Lista_Misji;
        stream.Close();

        return lista;
    }
    public void ZapiszListeMisji(Lista_Misji lista)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Lista_Misji));
        FileStream stream = new FileStream(Application.dataPath + "Lista_Misji.xml", FileMode.Create);
        serializer.Serialize(stream, lista);
        stream.Close();
    }

    */
}
