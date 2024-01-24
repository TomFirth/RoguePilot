using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    Vector2 movement, vision;
    float rightTrigger, leftTrigger, topSpeed = 40f;

    void Update()
    {
        var gamepad = Gamepad.current;
        if (gamepad == null)
            return; // No gamepad connected.

        movement = gamepad.leftStick.ReadValue();
        vision = gamepad.rightStick.ReadValue();
        rb.AddForce(transform.forward * movement.y * 1000f * Time.deltaTime);
        rb.AddForce(transform.right * movement.x * 500f * Time.deltaTime);
        if (rb.velocity.magnitude > topSpeed) {
            rb.velocity = rb.velocity.normalized * topSpeed;
        }
        transform.rotation = Quaternion.Euler(transform.eulerAngles += new Vector3(0f, vision.x * 100f * Time.deltaTime, 0f));

        leftTrigger = gamepad.leftTrigger.ReadValue();
        if (leftTrigger > 0) {
            // cycle weapons
        }
        rightTrigger = gamepad.rightTrigger.ReadValue();
        if (rightTrigger > 0) {
            // fire
        }

        if (gamepad.leftShoulder.wasPressedThisFrame) {

        }

        if (gamepad.rightShoulder.wasPressedThisFrame) {

        }

        if (gamepad.buttonNorth.wasPressedThisFrame || gamepad.dpad.up.wasPressedThisFrame) {
        
        }

        if (gamepad.buttonSouth.wasPressedThisFrame || gamepad.dpad.down.wasPressedThisFrame) {
        
        }

        if (gamepad.buttonEast.wasPressedThisFrame || gamepad.dpad.right.wasPressedThisFrame) {
        
        }

        if (gamepad.buttonWest.wasPressedThisFrame || gamepad.dpad.left.wasPressedThisFrame) {

        }
    }
}
