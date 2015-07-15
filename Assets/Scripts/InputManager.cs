using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public bool ReceiveInput (string Key, KeyState State)
	{
		if (State == KeyState.KeyHeld)
		{
			if (Input.GetKey(Key))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else if (State == KeyState.KeyDown)
		{
			if (Input.GetKeyDown(Key))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else if (State == KeyState.KeyUp)
		{
			if (Input.GetKeyUp(Key))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		else
		{
			return false;
		}
	}
}
