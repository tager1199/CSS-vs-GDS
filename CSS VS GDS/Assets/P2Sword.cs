using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  P2Sword : MonoBehaviour
{
    GameObject referenceObject;
    P1Movement referenceScript;
    //P2Movement P2 = new P2Movement();
    // Start is called before the first frame update
    public void Start()
    {

        referenceObject = GameObject.FindGameObjectWithTag("Player 1");
        referenceScript = referenceObject.GetComponent<P1Movement>();



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player 1")
        {
            referenceScript.health -= 10;
        }
    }
}