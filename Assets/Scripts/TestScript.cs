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
		/*Vector3 mousePos = Input.mousePosition;
		Vector3 newRotation = Vector3.zero;

		newRotation.z = Vector3.Angle(transform.position, mousePos);

		Debug.Log(newRotation.z);

		transform.eulerAngles = newRotation - new Vector3 (0.0f, 0.0f, 360.0f);
	*/


		/*Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
*/

		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

	}
}
