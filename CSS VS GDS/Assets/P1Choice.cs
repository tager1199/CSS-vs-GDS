using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1Choice : MonoBehaviour
{
    public void CSS()
    {
        //Change the message to say the name of the current Dropdown selection using the value

        PlayerPrefs.SetInt("Player 1 Choice", 0);
        PlayerPrefs.SetString("P1", "CSS");
        SceneManager.LoadScene("P2Menu", LoadSceneMode.Single);
    }

    public void GDS()
    {
        PlayerPrefs.SetInt("Player 1 Choice", 1);
        PlayerPrefs.SetString("P1", "GDS");
        SceneManager.LoadScene("P2Menu", LoadSceneMode.Single);
    }
    public void Other()
    {
        PlayerPrefs.SetInt("Player 1 Choice", 2);
        PlayerPrefs.SetString("P1", "Other");
        SceneManager.LoadScene("P2Menu", LoadSceneMode.Single);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
