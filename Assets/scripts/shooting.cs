using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] float speed = 4;
    [SerializeField] GameObject controller;
    // Start is called before the first frame update
    void Start()
    {
        if (controller == null)
        {
            controller = GameObject.FindGameObjectWithTag("GameController");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision) {
        //destroy arrow when it hits enemy
        if(collision.gameObject.tag == "enemy") {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            controller.GetComponent<scorekeeper>().AddPoints();
        }
        //destroy arrow out of boundsß
        if(collision.gameObject.tag == "edge") {
            Destroy(gameObject);
        }
    }
}
