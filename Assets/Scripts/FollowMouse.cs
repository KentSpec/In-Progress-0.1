using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour 
{
	private Vector3 mousePos;
	private Vector3 objectPos;
	
	private float newAngle;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		LookAtMouse();
	}
	
	void LookAtMouse ()
	{
		mousePos = Input.mousePosition;
		mousePos.z = 5.23f;
		
		objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		newAngle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, newAngle));
	}
}
