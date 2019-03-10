using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  P2Sword : MonoBehaviour
{
    GameObject referenceObject;
    P1Movement referenceScript;
    Component halo;
    //P2Movement P2 = new P2Movement();
    // Start is called before the first frame update
    public void Start()
    {
        halo = GetComponent("Halo");
        referenceObject = GameObject.FindGameObjectWithTag("Player 1");
        referenceScript = referenceObject.GetComponent<P1Movement>();
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player 1")
        {
            referenceScript.heal -= 10;
            halo.GetType().GetProperty("enabled").SetValue(halo, true, null);
            Invoke("diable", 1f);
        }
    }

    private void diable()
    {
        halo.GetType().GetProperty("enabled").SetValue(halo, false, null);
    }
}