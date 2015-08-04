using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour 
{
	public GameObject bulletPrefab;

	private GameObject bulletInstance;
	private Transform startPos;
	
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
		bulletInstance = Instantiate (bulletPrefab, startPos.position, startPos.rotation) as GameObject;
		//bulletInstance.GetComponent<BulletBehavior>().SetDirection(startPos.eulerAngles);

		//Debug.Log(startPos.eulerAngles);
	}

	public void SetStart (Transform NewStart)
	{
		startPos = NewStart;
	}
}
