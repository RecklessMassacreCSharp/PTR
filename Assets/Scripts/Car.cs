using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : VehicleBase // INHERITANCE
{
    float horizontalInput;
    float verticalInput;

    const float rotSpeed = 40; 

    float _maxSpeed;
    public float MaxSpeed // ENCAPSULATION
    {
        get
        {
            return _maxSpeed;
        }
        set
        {
            if (value > 0f || value < 120.01f) {
                _maxSpeed = value;
            } else {
                Debug.LogError("speed must be higher than 0 and less than 120");
            }
        }
    }

    void Start() {
        MaxSpeed = 70;
    }

    void Update()
    {
        Move();
    }

    public override void Move() { // POLYMORPHISM // ABSTRACTION
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * _maxSpeed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed * horizontalInput);
    }
}
