using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveToy : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(45, 45, 45);
    public float moveSpeed = 5f;

    void Update()
    {
        transform.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }

}
