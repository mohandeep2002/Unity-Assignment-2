using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject ball1;
    Rigidbody rg;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clicking()
    {
        transform.Translate(Vector3.down);
    }
    public void Action()
    {
        ball1.transform.Translate(Vector3.forward * 3f * Time.deltaTime);
        rg = ball1.GetComponent<Rigidbody>();
        rg.AddForce(Vector3.forward * 1000);
    }
}
