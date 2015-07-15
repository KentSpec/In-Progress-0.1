using UnityEngine;
using System.Collections;

[RequireComponent (typeof (InputManager))]
[RequireComponent (typeof (MovementManager))]


public class PlayerController : MonoBehaviour 
{
	InputManager InputM;
	MovementManager Movement;
	
	public float MovementSpeed;
	public float SprintModifer;
	public float TimeScale;

	private bool isRunning;

	// Use this for initialization
	void Start () 
	{
		InputM = GetComponent<InputManager>();
		Movement = GetComponent<MovementManager>();

		isRunning = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		PlayerMovement();
		PlayerAttack();
		PlayerStatChanges();

		//transform.LookAt (Vector3.zero);

		//Debug.Log(Input.mousePosition);
	}

	void PlayerMovement()
	{
		if (InputM.ReceiveInput("w", KeyState.KeyHeld))
		{
			Movement.Move(new Vector3 (0.0f, 1.0f, 0.0f), MovementSpeed * TimeScale);
		}
		else if (InputM.ReceiveInput("s", KeyState.KeyHeld))
		{
			Movement.Move(new Vector3 (0.0f, -1.0f, 0.0f), MovementSpeed * TimeScale);
		}

		if (InputM.ReceiveInput("a", KeyState.KeyHeld))
		{
			Movement.Move(new Vector3 (-1.0f, 0.0f, 0.0f), MovementSpeed * TimeScale);
		}
		else if (InputM.ReceiveInput("d", KeyState.KeyHeld))
		{
			Movement.Move(new Vector3 (1.0f, 0.0f, 0.0f), MovementSpeed * TimeScale);
		}
	}

	void PlayerAttack()
	{
		if (InputM.ReceiveInput("space", KeyState.KeyHeld))
		{
			Debug.Log("Space has been held");
		}

		if (InputM.ReceiveInput("space", KeyState.KeyHeld))
		{
			Debug.Log("Space has been held");
		}
	}

	void PlayerStatChanges()
	{
		if (InputM.ReceiveInput("left shift", KeyState.KeyHeld))
		{
			if (!isRunning)
			{
				isRunning = true;
				MovementSpeed = MovementSpeed * SprintModifer;
			}
		}
		else if (InputM.ReceiveInput("left shift", KeyState.KeyUp))
		{
			isRunning = false;
			MovementSpeed = MovementSpeed / SprintModifer;
		}
	}
}
