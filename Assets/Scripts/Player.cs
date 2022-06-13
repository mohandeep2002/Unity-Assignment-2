using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController cc;
    [SerializeField]
    private bool _move = false, isCLicked = false;
    [SerializeField]
    private GameObject button1, button2, button3;
    private Button3 b3;
    private Button2 b2;
    private Button1 b1;
    private SpawnManager _sm;

    public void YesMove()
    {
        _move = false;
    }
    public void NoMove()
    {
        _move = true;
    }
    void Start()
    {
        cc = GetComponent<CharacterController>();
        _sm = GetComponent<SpawnManager>();
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        b3 = GameObject.Find("Button3").GetComponent<Button3>();
        b2 = GameObject.Find("Button2").GetComponent<Button2>();
        b1 = GameObject.Find("Button1").GetComponent<Button1>();
    }
    private void OnMouseDown()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Cursor.visible = true;
        //    Cursor.lockState = CursorLockMode.None;
        //}
        if (_move == false)
        {
            Movement();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            YesMove();
        }
        if (Input.GetMouseButton(0) && isCLicked != true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            if (hit.transform != null)
            {
                Debug.Log(hit.transform.tag);
                //Debug.Log(hit.transform.position.x);
                //Debug.Log(hit.transform.position.y);
                //Debug.Log(hit.transform.position.z);
                if (hit.transform.tag == "Button1")
                {
                    Vector3 v = new Vector3(button1.transform.position.x, button1.transform.position.y - 0.05f, button1.transform.position.z);
                    button1.transform.position = v;
                    isCLicked = true;
                    _sm.InstantiateB1();
                    // b1.Action();
                    StartCoroutine(ButtonRaise1(v));
                }
                else if (hit.transform.tag == "Button2")
                {
                    Vector3 v = new Vector3(button2.transform.position.x, button2.transform.position.y - 0.05f, button2.transform.position.z);
                    button2.transform.position = v;
                    isCLicked = true;
                    _sm.InstantiateB2();
                    // b2.Action();
                    StartCoroutine(ButtonRaise2(v));
                }
                else if (hit.transform.tag == "Button3")
                {
                    Vector3 v = new Vector3(button3.transform.position.x, button3.transform.position.y - 0.05f, button3.transform.position.z);
                    button3.transform.position = v;
                    isCLicked = true;
                    _sm.InstantiateB3();
                    // b3.Action();
                    StartCoroutine(ButtonRaise3(v));
                }


            }
        }
        
    }
    void Movement()
    {
        float HI = Input.GetAxis("Horizontal");
        float VI = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(HI, 0, VI);
        Vector3 velocity = direction * 3.0f;
        velocity.y = velocity.y - 9.18f;
        velocity = transform.transform.TransformDirection(velocity);
        cc.Move(velocity * Time.deltaTime);
    }
    public void newplayerpos()
    {
        Vector3 newPOs = new Vector3(-6f, -1.5f, 6.6f);
        transform.position = newPOs;
    }
    IEnumerator ButtonRaise1(Vector3 v)
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("yield");
        v = new Vector3(-7.163856f, 1.982044f, 5.57f);
        button1.transform.position = v;
        isCLicked = false;
    }
    IEnumerator ButtonRaise2(Vector3 v)
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("yield");
        v = new Vector3(-0.02385604f, 1.982044f, 5.57f);
        button2.transform.position = v;
        isCLicked = false;
    }
    IEnumerator ButtonRaise3(Vector3 v)
    {
        yield return new WaitForSeconds(0.5f);
        Debug.Log("yield");
        v = new Vector3(6.756144f, 1.982044f, 5.57f);
        button3.transform.position = v;
        isCLicked = false;
    }
}
