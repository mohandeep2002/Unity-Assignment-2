using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class High1 : MonoBehaviour
{
    Player player;
    LookX x;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        x = GameObject.Find("Player").GetComponent<LookX>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //player.newplayerpos();
            Debug.Log("Player hitted on high1");
            x.DoneSee();
            player.YesMove();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player outeds on high1");
            x.YesSee();
            player.NoMove();
        }
    }
}
