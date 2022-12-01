using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] GameObject frog;
    [SerializeField] int speed = 5;
    [SerializeField] float size = .01f;
    const int num = 5;
    // Start is called before the first frame update
    void Start()
    {
        //increase size after time
        InvokeRepeating("scaling", 0.0f, 2.0f);
        //InvokeRepeating("spawn", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        //movement across screen
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //balloon disappears when 'big enough'
        pop();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //change direction when colliding with edge
        if(collision.gameObject.tag == "edge")
            speed *= -1;
    }

    public void scaling() 
    {
        //increase scale
        transform.localScale = new Vector3 (.07f+size, .07f+size, 0.0f);
        size += size;
    } 

    public void pop() 
    {
        if(size>.9f) 
            Destroy(gameObject);
    }

    public void spawn() 
    {
        Vector2 position = new Vector2(Random.Range(-10, 10), Random.Range(5, 10));
        Instantiate(frog, position, Quaternion.identity);
    }
}
