using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = new Vector3(transform.position.x
                                        + horizontalInput*speed*Time.deltaTime
                                        , 1,
                                        transform.position.z + verticalInput*speed*Time.deltaTime);
    }
}