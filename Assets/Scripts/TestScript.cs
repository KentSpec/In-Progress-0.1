using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour 
{

	public float test;

	public float PosX;
	public float PosY;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{


		float camDis = Camera.main.transform.position.y - transform.position.y;

		Vector3 mouse = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, camDis));

		float AngleRad = Mathf.Atan2 (mouse.y - transform.position.y, mouse.x - transform.position.x);
		float angle = (360 / Mathf.PI) * AngleRad;

		transform.eulerAngles = new Vector3 (transform.rotation.x, transform.rotation.y, angle);

	}
}
