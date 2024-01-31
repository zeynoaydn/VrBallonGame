using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patla : MonoBehaviour
{
    RenkVerici renkverici;
    void Start()
    {
        renkverici = GetComponent<RenkVerici>();

    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        string ad = collision.gameObject.name;
        Renk benimsecilenrengim = renkverici.secilenRenk;
        
        if (ad.Contains("Mermi"))
        {
            //ScoreSayacý.sayac++;
            if (benimsecilenrengim == Renk.Kirmizi)
            {
                ScoreSayacý.sayac++;
            }
            else if (benimsecilenrengim == Renk.Mavi)
            {
                ScoreSayacý.sayac += 2;
            }
            else if (benimsecilenrengim == Renk.Sari)
            {
                ScoreSayacý.sayac += 3;
            }
            else if (benimsecilenrengim == Renk.Yesil)
            {
                ScoreSayacý.sayac += 4;
            }



            Debug.Log(ScoreSayacý.sayac);

            Destroy(gameObject);
        }


    }
}
