using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Sword : MonoBehaviour
{
    GameObject referenceObject;
    P2Movement referenceScript;
    //P2Movement P2 = new P2Movement();
    // Start is called before the first frame update
    public void Start()
    {

        referenceObject = GameObject.FindGameObjectWithTag("Player 2");
        referenceScript = referenceObject.GetComponent<P2Movement>();

        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player 2")
        {
            referenceScript.health -= 10;
        }
    }
}
