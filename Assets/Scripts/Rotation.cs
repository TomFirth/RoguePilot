using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotation : MonoBehaviour {

    Vector2 movement;
    float forwardTiltForce = 20f, turnTiltForce = 30f;
    private Vector3 hTilt = Vector2.zero;

    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
            return; // No gamepad connected.

        movement = gamepad.leftStick.ReadValue();

        hTilt.x = Mathf.Lerp(hTilt.x, movement.x * turnTiltForce, Time.deltaTime);
        hTilt.y = Mathf.Lerp(hTilt.y, movement.y * forwardTiltForce, Time.deltaTime);
        transform.localRotation = Quaternion.Euler(hTilt.y, transform.localEulerAngles.y, -hTilt.x);
    }
}
