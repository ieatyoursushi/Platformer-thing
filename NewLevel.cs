using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour {
    private float moveSpeed = 5.5f;

    void FixedUpdate()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
