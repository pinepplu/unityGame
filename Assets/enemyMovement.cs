using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
			rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "edge")
            speed *= -1;
    }
}
