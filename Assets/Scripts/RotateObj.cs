using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 anglerSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        transform.Rotate(anglerSpeed * Time.fixedDeltaTime, Space.Self);
    }
}
