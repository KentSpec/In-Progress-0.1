using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour 
{

	public GameObject bulletInstance;
	public Transform startPos;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void SpawnProjectile ()
	{
		Instantiate (bulletInstance, startPos.position, startPos.rotation);
	}
}
