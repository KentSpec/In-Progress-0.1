using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour 
{
	public Vector3 Direction;
	public float Speed;

	Rigidbody2D BulletBody;

	Vector3 V;

	// Use this for initialization
	void Start () 
	{
		BulletBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		V = new Vector3 (Direction.x, Direction.y, 0.0f) * Speed;


		BulletBody.velocity = V;
	}
}
