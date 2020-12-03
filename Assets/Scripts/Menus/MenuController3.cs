using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController3 : MonoBehaviour
{
    public void ButtonMainMenu()
    {
        SceneManager.LoadScene(0);
    }
     
    public void ButtonCredits()
    {
        SceneManager.LoadScene(1);
    }
}
