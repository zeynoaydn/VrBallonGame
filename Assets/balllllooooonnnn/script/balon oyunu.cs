using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class balonoyunu : MonoBehaviour
{
   
    public GameObject Target; 
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -50; i < 500; i++)
        {
            GameObject go = Instantiate(Target);//prefab çaðýrmak için kullanýlýyor.
            go.transform.position = new Vector3(Random.value * i, (Random.value * i) + 10, Random.value * i);
            go.transform.SetParent(transform);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
