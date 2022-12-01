using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    [SerializeField] InputField playerNameInput;

    public void PlayGame()
    {
        string s = playerNameInput.text;
        PersistentData.Instance.SetName(s);
        SceneManager.LoadScene("level1");
    }

    public void HighScores() 
    {
        SceneManager.LoadScene("highscore");
    }
}
