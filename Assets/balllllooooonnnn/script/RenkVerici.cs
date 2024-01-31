using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Renk
{
    Kirmizi,
    Mavi,
    Camgok,
    Sari,
    Yesil
}
public class RenkVerici : MonoBehaviour
{

    public Renk secilenRenk;
   

    void Start()
    {
        MeshRenderer rend = GetComponent<MeshRenderer>();
        Material mat = rend.material;

        //mat.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        //Color[] renkler = new Color[] { Color.red, Color.blue, Color.cyan, Color.yellow, Color.green };
        //int myRandom = Random.Range(0, 4);
        //mat.color = renkler[myRandom];

        //kirmizi = Renk.Kirmizi;
        //mavi = Renk.Mavi;
        //camgok = Renk.Camgok;
        //sari = Renk.Sari;
        //yesil = Renk.Yesil;

        secilenRenk = SecilenRenk();
        mat.color = RenkToColor(secilenRenk);

    }
    Renk SecilenRenk()
    {
        return (Renk)Random.Range(0, System.Enum.GetValues(typeof(Renk)).Length);
    }

    public Color RenkToColor(Renk renk)
    {
        switch (renk)
        {
            case Renk.Kirmizi:
                return Color.red;
            case Renk.Mavi:
                return Color.blue;
            case Renk.Camgok:
                return Color.cyan;
            case Renk.Sari:
                return Color.yellow;
            case Renk.Yesil:
                return Color.green;
            default:
                return Color.white;
        }
    }

    void Update()
    {
    }
}
