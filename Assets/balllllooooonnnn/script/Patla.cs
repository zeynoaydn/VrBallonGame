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
            //ScoreSayac�.sayac++;
            if (benimsecilenrengim == Renk.Kirmizi)
            {
                ScoreSayac�.sayac++;
            }
            else if (benimsecilenrengim == Renk.Mavi)
            {
                ScoreSayac�.sayac += 2;
            }
            else if (benimsecilenrengim == Renk.Sari)
            {
                ScoreSayac�.sayac += 3;
            }
            else if (benimsecilenrengim == Renk.Yesil)
            {
                ScoreSayac�.sayac += 4;
            }



            Debug.Log(ScoreSayac�.sayac);

            Destroy(gameObject);
        }


    }
}
