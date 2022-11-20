using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int playerScore;
    
    public static PersistentData Instance;
/*
    public void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(gameObject);
    } */
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }

    public void SetScore (int score)
    {
        playerScore = score;
    }

    public int GetScore()
    {
        return playerScore;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
