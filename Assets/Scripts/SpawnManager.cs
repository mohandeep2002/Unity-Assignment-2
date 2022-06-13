using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject b1, b2, b3;
    private Button3 buttonAction3;
    private Button1 buttonAction1;
    private Button2 buttonAction2;
    void Start()
    {
        buttonAction3 = GameObject.Find("Button3").GetComponent<Button3>();
        buttonAction1 = GameObject.Find("Button1").GetComponent<Button1>();
        buttonAction2 = GameObject.Find("Button2").GetComponent<Button2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InstantiateB1()
    {
        Vector3 newVector = new Vector3(-7.13f, 2.34f, 7.79f);
        GameObject go = Instantiate(b1, newVector, Quaternion.identity);
        buttonAction1.Action(go);
    }
    public void InstantiateB2()
    {
        Vector3 newVector = new Vector3(-0.02f, 2.34f, 7.79f);
        GameObject go = Instantiate(b2, newVector, Quaternion.identity);
        buttonAction2.Action(go);
    }
    public void InstantiateB3()
    {
        Vector3 newVector = new Vector3(6.27f, 2.34f, 7.79f);
        GameObject go = Instantiate(b3, newVector, Quaternion.identity);
        buttonAction3.Action(go);

    }
}
