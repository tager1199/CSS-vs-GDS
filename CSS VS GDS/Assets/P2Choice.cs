using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P2Choice : MonoBehaviour
{
    public void CSS()
    {
        //Change the message to say the name of the current Dropdown selection using the value

        PlayerPrefs.SetInt("Player 2 Choice", 0);
        PlayerPrefs.SetString("P2", "CSS");
        SceneManager.LoadScene("Map 2", LoadSceneMode.Single);
    }

    public void GDS()
    {
        PlayerPrefs.SetInt("Player 2 Choice", 1);
        PlayerPrefs.SetString("P2", "GDS");
        SceneManager.LoadScene("Map 2", LoadSceneMode.Single);
    }
    public void Other()
    {
        PlayerPrefs.SetInt("Player 2 Choice", 2);
        PlayerPrefs.SetString("P2", "Other");
        SceneManager.LoadScene("Map 2", LoadSceneMode.Single);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
