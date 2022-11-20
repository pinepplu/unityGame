using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyShoot : MonoBehaviour
{
    [SerializeField] float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        //collision with edge, destroy itself
        if(collision.gameObject.tag == "edge") {
            Destroy(gameObject);
        }
        //collision with player destroy player and itself
        if(collision.gameObject.tag == "Player") {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            //relead current level if player dies
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
