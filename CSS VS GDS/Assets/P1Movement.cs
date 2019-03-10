using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class P1Movement : MonoBehaviour
{
    
    public int lives = 3;
    public float heal = 50;
    public int choice;
    public bool first = false;
    public bool second = false;
    Renderer m_Renderer;



    void Start()
    {
        //Load a Texture (Assets/Resources/Textures/tomos.png)
        var CSS1 = Resources.Load<Texture2D>("Textures/thomas");
        var GDS1 = Resources.Load<Texture2D>("Textures/louis");
        var Other1 = Resources.Load<Texture2D>("Textures/tomos");
        
        m_Renderer = GetComponent<Renderer>();
        


        choice = PlayerPrefs.GetInt("Player 1 Choice");
        if (choice == 0)
        {
            m_Renderer.material.mainTexture = CSS1;
        }
        else if (choice == 1)
        {
            m_Renderer.material.mainTexture = GDS1;
        }
        else
        {
            m_Renderer.material.mainTexture = Other1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject health1 = GameObject.Find("P1H1");
        GameObject health2 = GameObject.Find("P1H2");
        GameObject health3 = GameObject.Find("P1H3");
        var CSS2 = Resources.Load<Texture2D>("Textures/dink");
        var GDS2 = Resources.Load<Texture2D>("Textures/Jordan");
        var Other2 = Resources.Load<Texture2D>("Textures/tom");
        var CSS3 = Resources.Load<Texture2D>("Textures/ryan");
        var GDS3 = Resources.Load<Texture2D>("Textures/tom");
        var Other3 = Resources.Load<Texture2D>("Textures/thomas");
        if (heal <= 0)
        {
            lives -= 1;
            heal = 50;
        }
        if (lives == 2 && first == false)
        {
            first = true;
            health3.SetActive(false);
            if (choice == 0)
            {
                m_Renderer.material.mainTexture = CSS2;
            }
            else if (choice == 1)
            {
                m_Renderer.material.mainTexture = GDS2;
            }
            else
            {
                m_Renderer.material.mainTexture = Other2;
            }
        }
        if (lives == 1 && second == false)
        {
            second = true;
            health2.SetActive(false);
            heal = 100;
            if (choice == 0)
            {
                m_Renderer.material.mainTexture = CSS3;
            }
            else if (choice == 1)
            {
                m_Renderer.material.mainTexture = GDS3;
            }
            else
            {
                m_Renderer.material.mainTexture = Other3;
            }
        }

        if (Input.GetKey(KeyCode.A))
            transform.Translate((float)-0.5, 0, 0, Space.World);
        if (Input.GetKey(KeyCode.D))
            transform.Translate((float)0.5, 0, 0, Space.World);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0, (float)0.5, Space.World);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, (float)-0.5, Space.World);
        if (Input.GetKey(KeyCode.Space) && gameObject.transform.position.y < -4)
            transform.Translate(0, 10, 0, Space.World);
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(0, -5, 0, Space.Self);
        if (Input.GetKey(KeyCode.E))
            transform.Rotate(0, 5, 0, Space.Self);

        if (lives == 0)
        {
            health1.SetActive(false);
            PlayerPrefs.SetString("Winner", "P2");
            SceneManager.LoadScene("Ending", LoadSceneMode.Single);
        }
        
    }
}
