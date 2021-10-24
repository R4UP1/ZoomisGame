using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputHandler : MonoBehaviour
{
    //Components
    CarController carController;

    //Awake is called when the script instance is lfoaded
    private void Awake()
    {
        carController = GetComponent<CarController>();
    }

    private void Update()
    {
        Vector2 inputVector = Vector2.up;

        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
		
        carController.SetInputVector(inputVector);
    }
}
