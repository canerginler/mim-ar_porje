using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
public class main : MonoBehaviour
{
    public void sahneGecis(int itemId)
    {
        PlayerPrefs.SetInt("ItemId", itemId);
        SceneManager.LoadScene(1);
    }

    public void quitButton()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }
}
