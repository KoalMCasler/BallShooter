using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowStrip : MonoBehaviour
{
    private Rigidbody RB;
    public int BoostSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            RB = other.GetComponent<Rigidbody>();
            RB.AddForce(Vector3.back * BoostSpeed, ForceMode.VelocityChange);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Ball"))
        {
            RB = null;
        }
    }
}