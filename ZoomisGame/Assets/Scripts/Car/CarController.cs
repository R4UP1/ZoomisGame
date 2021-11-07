using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	[Header("Car settings")] 
	// If drift factor is closer to 1, it floats more - 0 = more train like
	public float driftFactor = 0.01f;
	public float accelerationFactor = 20f;
	public float turnFactor = 4.5f;

	// Local variable 
	float accelerationInput = 0;
	float steeringInput = 0;
	
	float rotationAngle = 0;

	// Components
	Rigidbody2D carRigidbody2D;

	// Awake is called when the script instance is being loaded.
	void Awake() 
	{
		carRigidbody2D = GetComponent<Rigidbody2D>();
	}

	void KillOrthogonalVelocity()
	{
		Vector2 forwardVelocity = transform.up * Vector2.Dot(carRigidbody2D.velocity, transform.up);
		Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody2D.velocity, transform.right);

		carRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;

	}

	void FixedUpdate()
	{
		ApplyEngineForce();
		
		KillOrthogonalVelocity();

		ApplySteering();
	}

	void ApplyEngineForce()
	{
		//Create a force for the engine
		Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

		//Apply force and pushes the car forward
		carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
		
	}

	void ApplySteering()
	{
		//Update the rotation angle based on input
		rotationAngle -= steeringInput * turnFactor;

		// Apply steering by rotating the car object
		carRigidbody2D.MoveRotation(rotationAngle);
	}

	public void SetInputVector(Vector2 inputVector)
	{
		steeringInput = inputVector.x;
		accelerationInput = inputVector.y;
	}
}