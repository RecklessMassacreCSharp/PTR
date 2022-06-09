using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Van : VehicleBase // INHERITANCE
{
    float horizontalInput;
    float verticalInput;

    float _maxSpeed;
    public float MaxSpeed // ENCAPSULATION
    {
        get
        {
            return _maxSpeed;
        }
        set
        {
            if (value > 0f || value < 80.01f) {
                _maxSpeed = value;
            } else {
                Debug.LogError("speed must be higher than 0 and less than 80");
            }
        }
    }

    const float rotSpeed = 34;

    void Start() {
        MaxSpeed = 50;
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
