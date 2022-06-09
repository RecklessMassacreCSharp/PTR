using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VehicleBase : MonoBehaviour
{
    protected bool IsTurnedOn = false;

    public abstract void Move();

    public void TurnOn() {
        IsTurnedOn = true;
    }
    
    public void TutnOff() {
        IsTurnedOn = false;
    }
}
