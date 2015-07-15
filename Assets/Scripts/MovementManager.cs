using UnityEngine;
using System.Collections;

public class MovementManager : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void Move (Vector3 Direction, float Speed)
	{
		transform.Translate((Direction * Speed) * Time.deltaTime);
	}

	void ImpluseMove (Vector3 Direction, float Speed)
	{

	}
}
