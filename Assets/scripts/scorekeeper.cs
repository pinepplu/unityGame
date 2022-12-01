using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class scorekeeper : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text sceneText;
    const int DEFAULT_POINTS = 1;
    const int SCORE_TO_ADVANCE = 5;
    int level;
    string playerName;
    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        playerName = PersistentData.Instance.GetName();
        level = SceneManager.GetActiveScene().buildIndex;
        scoreText.text = "Welcome " + playerName + " Score: " + score;
        sceneText.text = "Level: " + (level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int points)
    {
        score += points;
        PersistentData.Instance.SetScore(score);
        scoreText.text = playerName + "'s " + "Score: " + score;
        if(score >= (level) * SCORE_TO_ADVANCE)
        {
            AdvanceLevel();
        }
    }

    public void AddPoints()
    {
        AddPoints(DEFAULT_POINTS);
    }

    public void AdvanceLevel()
    {
        //advance to next level/scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
