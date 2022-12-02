using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	[SerializeField] Rigidbody2D rigid;
	[SerializeField] float moveHorizontal;
    [SerializeField] float moveVertical;
	[SerializeField] int speed = 10;
	[SerializeField] bool isFacingRight = true;
	/*[SerializeField] Animator animator;
	const int idle = 0;
    const int roll = 1;
    const int fly = 2;
	*/

    // Start is called before the first frame update
    void Start()
    {
		if (rigid == null)
			rigid = GetComponent<Rigidbody2D>();
		/*
		if (animator == null)
            animator = GetComponent<Animator>();
			
		animator.SetInteger("motion", idle);
		*/
    }

    // Update is called once per frame
    //good for user input
    void Update()
    {
		moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }

    //called potentially multiple times per frame
    //use for physics/movement
    void FixedUpdate()
	{
		rigid.velocity = new Vector2(moveHorizontal * speed, moveVertical * speed);
		/*if (moveHorizontal > 0 || moveHorizontal < 0)
                animator.SetInteger("motion", roll);
            else
                animator.SetInteger("motion", idle);
			*/
		if ((moveHorizontal > 0 && isFacingRight) || (moveHorizontal < 0 && !isFacingRight))
			Flip();
	}

    void Flip()
	{
		transform.Rotate(0, 180, 0);
		isFacingRight = !isFacingRight; 
	}
}