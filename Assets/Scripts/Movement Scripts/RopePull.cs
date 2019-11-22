using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopePull : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(player1.transform.position, player2.transform.position) >= 35)
        {
            pullingForce();
        }
    }

    private void pullingForce()
    {
        player1.transform.LookAt(player2.transform.position);
        player1.GetComponent<Rigidbody>().AddForce(0, 0, 1);
        player2.transform.LookAt(player1.transform.position);
        player2.GetComponent<Rigidbody>().AddForce(0, 0, 1);

    }
}
