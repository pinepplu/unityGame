using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseresume : MonoBehaviour
{
    [SerializeField] GameObject[] pause;
    [SerializeField] GameObject[] resume;
    // Start is called before the first frame update
    void Start()
    {
       foreach(GameObject button in resume)
        {
            button.SetActive(true);
        }
        foreach(GameObject button in pause)
        {
            button.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toMenu() 
    {
        SceneManager.LoadScene("menu");
    }

    public void PauseGame() 
    {
        Time.timeScale = 0;
        foreach(GameObject button in pause)
        {
            button.SetActive(true);
        }
        foreach(GameObject button in resume)
        {
            button.SetActive(false);
        }
    }

    public void ResumeGame() 
    {
        Time.timeScale = 1;
        foreach(GameObject button in resume)
        {
            button.SetActive(true);
        }
        foreach(GameObject button in pause)
        {
            button.SetActive(false);
        }
    }
}
