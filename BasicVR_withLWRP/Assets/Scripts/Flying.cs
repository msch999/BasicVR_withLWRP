using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public Transform head;

    //public TrackedReference leftHand;
    public TrackedReference rightHand;
    public OVRInput.Controller

    private bool isFlying = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 leftDir = leftHand.transform.position - head.position;
        Vector3 rightDir = rightHand.transform.position - head.position;

        Vector3 dir = leftDir + rightDir;

        transform.position += dir;
    }
}
