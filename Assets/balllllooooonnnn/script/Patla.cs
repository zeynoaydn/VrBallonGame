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
            //ScoreSayacı.sayac++;
            if (benimsecilenrengim == Renk.Kirmizi)
            {
                ScoreSayacı.sayac++;
            }
            else if (benimsecilenrengim == Renk.Mavi)
            {
                ScoreSayacı.sayac += 2;
            }
            else if (benimsecilenrengim == Renk.Sari)
            {
                ScoreSayacı.sayac += 3;
            }
            else if (benimsecilenrengim == Renk.Yesil)
            {
                ScoreSayacı.sayac += 4;
            }



            Debug.Log(ScoreSayacı.sayac);

            Destroy(gameObject);
        }


    }
}
