using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour


{
   [Range(1, 10)]
public float jumpVelocity;
public Rigidbody2D rb;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector3.up * jumpVelocity;

        }
    }
}
