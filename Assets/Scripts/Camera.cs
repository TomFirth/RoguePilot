using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public float cameraX = 200.0f;
    public float cameraY = 200.0f;
    public float cameraZ = 0.0f;
    public Rigidbody rb;
    void Update() {
        Vector3 pos = player.transform.position;
        pos.x += cameraX + rb.velocity.normalized.x * 30f;
        pos.y += cameraY;
        pos.z += cameraZ + rb.velocity.normalized.z * 50f;
        transform.position = pos;
    }
}
