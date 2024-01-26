using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public FixedJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        Vector3 direction = new Vector3(variableJoystick.Horizontal, 0, variableJoystick.Vertical).normalized;
        transform.position += direction * speed * Time.fixedDeltaTime;
        //rb.velocity = direction * speed * Time.fixedDeltaTime;
    }

}