using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    [SerializeField] GameObject fireball;
    [SerializeField] float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        //random shooting
        spawnTime = Random.Range(.01f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if(spawnTime <= 0)
        Instantiate(fireball, transform.position, Quaternion.identity);
        spawnTime = Random.Range(.01f, 1f);
    }
}
