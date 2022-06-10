using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject ball2;
    Rigidbody rg;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Action()
    {
        ball2.transform.Translate(Vector3.forward * 3f * Time.deltaTime);
        rg = ball2.GetComponent<Rigidbody>();
        rg.AddForce(Vector3.forward * 1000);
    }
}
