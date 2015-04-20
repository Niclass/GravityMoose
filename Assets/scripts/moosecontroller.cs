using UnityEngine;
using System.Collections;

public class moosecontroller : MonoBehaviour {

	public float maxSpeed = 10f;
	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;

	bool onRoof = false;
	public Transform roofCheck;
	float roofRadius = 0.2f;
	public LayerMask whatIsRoof;

	void Start () 
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		onRoof = Physics2D.OverlapCircle (roofCheck.position, roofRadius, whatIsRoof);
		anim.SetBool ("Roof", onRoof);

		anim.SetFloat ("Speed", Mathf.Abs (1));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (1 * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void Update()
	{
		if ((grounded ) && Input.GetKeyDown (KeyCode.Space)) 
		{
			anim.SetBool("Ground", false);
			GetComponent<Rigidbody2D>().gravityScale *= -1;
			onRoof = true;
		}

	  else if ((onRoof) && Input.GetKeyDown (KeyCode.Space)) 
		{
			anim.SetBool("Roof", false);
			GetComponent<Rigidbody2D>().gravityScale *= -1;
		}



	}




}
