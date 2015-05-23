using UnityEngine;
using System.Collections;

public class DeathMoveX : MonoBehaviour {
	
	protected Vector3 velocity;
	public Transform transformm;
	public float distance = 5f;
	public float speed = 1f;
	Vector3 originalPosition;
	bool isGoingRight = false;
	public float distFromStart;
	public void Start()
	{
		originalPosition = gameObject.transform.position;
		transformm = GetComponent<Transform>();
		velocity = new Vector3(speed, 0, 0);
		transformm.Translate(velocity.x * Time.deltaTime, 0, 0);
	}
	
	void Update()
	{
		distFromStart = transformm.position.x - originalPosition.x;
		
		if (isGoingRight)
		{
			// Ändrar riktining åt vänster
			if (distFromStart < -distance)
			{
				SwitchDirection();
			}
			transformm.Translate(-velocity.x * Time.deltaTime, 0, 0);
		}
		else
		{
			// ändrar riktning åt höger
			if (distFromStart > distance)
			{
				SwitchDirection();
			}
			transformm.Translate(velocity.x * Time.deltaTime, 0, 0);
		}
	}
	
	void SwitchDirection()
	{
		isGoingRight = !isGoingRight;
	}
}
