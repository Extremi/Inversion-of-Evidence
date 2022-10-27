using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyPositive;
    [SerializeField]
    KeyCode keyNegative;


    public float maxSpeed = 10f;

    private Rigidbody localRgb;

    private void Start()
    {
        localRgb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (localRgb.velocity.magnitude > maxSpeed)
            localRgb.velocity = Vector3.ClampMagnitude(localRgb.velocity, maxSpeed);



        if (Input.GetKey(keyPositive))
        GetComponent<Rigidbody>().velocity += v3Force;
        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3Force;
    }
}
