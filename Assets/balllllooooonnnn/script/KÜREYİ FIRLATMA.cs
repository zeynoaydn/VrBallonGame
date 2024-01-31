using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KÜREYİFIRLATMA : MonoBehaviour
{
    public GameObject mermi;
    Rigidbody rigid;
    public Transform cameraTransform;
    
    void Start()
    {
       
    }
    void Update()
    {

        if (OVRInput.Get(OVRInput.Button.One))
        {
            Vector3 pos = cameraTransform.position;

            Vector3 dir = cameraTransform.forward;

            GameObject go = Instantiate(mermi);
            go.transform.position = pos;

            Rigidbody rigid = go.GetComponent<Rigidbody>();
            rigid.AddForce(dir * 5000.0f, ForceMode.Force);

        }

        //if (Input.GetMouseButtonUp(0))
        //{
        //    Vector3 pos = cameraTransform.position;

        //    Vector3 dir= cameraTransform.forward;

        //    GameObject go = Instantiate(mermi);
        //    go.transform.position = pos;

        //    Rigidbody rigid = go.GetComponent<Rigidbody>();
        //    rigid.AddForce(dir * 5000.0f, ForceMode.Force);

        //}
    }
}
