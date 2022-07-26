using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    Vector3 preVelocity;
    Vector3 currVelocity;
    bool start;

    private void Start()
    {
        start = false;
        rb = this.GetComponent<Rigidbody>();
        preVelocity = Vector3.zero;
        currVelocity = rb.velocity;
    }
    private void FixedUpdate()
    {
        currVelocity = rb.velocity;

        if (currVelocity.x > 0 && start == false)
        {
            start = true;
        }

        if (start)
        {
            if (preVelocity == currVelocity)
            {
                //GameManager.instance.YouLose();
            }
            preVelocity = currVelocity;
        }
    }
}
