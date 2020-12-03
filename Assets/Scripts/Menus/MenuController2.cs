using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController2 : MonoBehaviour
{
    public void ButtonBack()
    {
        SceneManager.LoadScene(0);
    }
}
