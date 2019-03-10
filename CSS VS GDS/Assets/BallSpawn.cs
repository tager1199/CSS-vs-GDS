﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{

    // Start is called before the first frame update
    public float spawnTime;            // How long between each spawn.
    public Quaternion RotateVec;        // An array of the spawn points this enemy can spawn from.
    public Vector3 vector;
    public GameObject ball;
    public Collider Col;
    Renderer m_Renderer;

    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        var CSS1 = Resources.Load<Texture2D>("Textures/thomas");
        var GDS1 = Resources.Load<Texture2D>("Textures/louis");
        var Other1 = Resources.Load<Texture2D>("Textures/tomos");
        var CSS2 = Resources.Load<Texture2D>("Textures/dink");
        var GDS2 = Resources.Load<Texture2D>("Textures/Jordan");
        var Other2 = Resources.Load<Texture2D>("Textures/tom");
        var CSS3 = Resources.Load<Texture2D>("Textures/ryan");
        var GDS3 = Resources.Load<Texture2D>("Textures/tom");
        var Other3 = Resources.Load<Texture2D>("Textures/thomas");
        m_Renderer = GetComponent<Renderer>();
        ball = gameObject;
        string win;
        int loss;
        win = PlayerPrefs.GetString("Winner");
        
        Col = ball.GetComponent<Collider>();
        Col.attachedRigidbody.useGravity = true;
        RotateVec.Set(0, 0, 0, 0);
        vector.Set(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        int rnd = Random.Range(0, 3);
        if (win == "P2")
        {
            loss = PlayerPrefs.GetInt("Player 1 Choice");
        }
        else
        {
            loss = PlayerPrefs.GetInt("Player 2 Choice");
        }
        if (loss == 0)
        {
            if (rnd == 0)
            {
                m_Renderer.material.mainTexture = CSS1;
            }
            if (rnd == 1)
            {
                m_Renderer.material.mainTexture = CSS2;
            }
            else
            {
                m_Renderer.material.mainTexture = CSS3;
            }
        }
        else if (loss == 1)
        {
            if (rnd == 0)
            {
                m_Renderer.material.mainTexture = GDS1;
            }
            if (rnd == 1)
            {
                m_Renderer.material.mainTexture = GDS2;
            }
            else
            {
                m_Renderer.material.mainTexture = GDS3;
            }
        }
        else
        {
            if (rnd == 0)
            {
                m_Renderer.material.mainTexture = Other1;
            }
            if (rnd == 1)
            {
                m_Renderer.material.mainTexture = Other2;
            }
            else
            {
                m_Renderer.material.mainTexture = Other3;
            }
        }
    }

    private void Update()
    {
         spawnTime = Random.Range(1f, 3f);
    }
    
    void Spawn()
    {
        
        
        // Find a random index between zero and one less than the number of spawn points.

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(ball, vector, RotateVec);
    }
}