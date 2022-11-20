using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject frog;
    [SerializeField] float spawntime;
    [SerializeField] float currentSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpawnTime > 0)
        {
            currentSpawnTime -= Time.deltaTime;
        }
        else 
        {
            spawn();
            currentSpawnTime = spawntime;
        }
    }

    public void spawn() 
    {
        Vector2 position = new Vector2(Random.Range(-10, 10), Random.Range(5, 10));
        Instantiate(frog, position, Quaternion.identity);
    }
}
