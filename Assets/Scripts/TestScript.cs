using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour 
{
	public GameObject bulletPrefab;
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
		bulletInstance = Instantiate (bulletPrefab, startPos.position, startPos.rotation) as GameObject;
		bulletInstance.GetComponent<BulletBehavior>().Direction = startPos.eulerAngles;

		Debug.Log(startPos.forward);
	}
}
