using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float _sensitivity = 2f;
    [SerializeField]
    private bool move = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                DoneSee();
            }
            if (move == false)
            {
                float mousex = Input.GetAxis("Mouse X");
                Vector3 newrotation = transform.localEulerAngles;
                newrotation.y = newrotation.y + (mousex * _sensitivity);
                transform.localEulerAngles = newrotation;
            }
        }
        
    }
    public void DoneSee()
    {
        move = true;
    }
    public void YesSee()
    {
        move = false;
    }
}
