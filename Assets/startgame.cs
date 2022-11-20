using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    void Awake()
    {
        //enter level1
        SceneManager.LoadScene(1);
    }
}
