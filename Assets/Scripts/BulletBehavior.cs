using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour 
{
	Rigidbody2D BulletBody;

	private float Speed = 1;
	private Vector3 Direction = Vector3.zero;

	// Use this for initialization
	void Start () 
	{
		BulletBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.Translate(Vector3.right * 0.25f);
	}

	public void SetDirection (Vector3 NewDirection)
	{
		Direction = NewDirection;
	}

	public void SetSpeed (float NewSpeed)
	{
		Speed = NewSpeed;
	}

	public Vector3 GetDirection ()
	{
		return Direction;
	}

	public float GetSpeed ()
	{
		return Speed;
	}
}
