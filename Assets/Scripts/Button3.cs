using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject ball3;
    Rigidbody rg;
    SphereCollider sc;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Action(GameObject gameobject)
    {
        //ball3.transform.Translate(Vector3.forward * 3f * Time.deltaTime);
        //rg = ball3.GetComponent<Rigidbody>();
        //rg.AddForce(Vector3.forward * 1000);
        //rg.useGravity = true;
        gameobject.transform.Translate(Vector3.forward * 3f * Time.deltaTime);
        rg = gameobject.GetComponent<Rigidbody>();
        sc = gameobject.GetComponent<SphereCollider>();
        sc.isTrigger = true;
        rg.AddForce(Vector3.forward * 1000);
        rg.useGravity = true;
    }
}
