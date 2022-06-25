using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    Rigidbody rigibody;

    // Start is called before the first frame update
    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float noise = (Mathf.PerlinNoise(Time.time / 5, 3243) - 0.5f) * 2;

        Vector3 speed = new Vector3(Mathf.Cos(Time.time / 5) * 5, Mathf.Sin(Time.time / 5) * 5, noise * 10);
        rigibody.velocity = speed;

        speed.Normalize();
        Vector3 targetPos = transform.position - speed;
        this.transform.LookAt(targetPos);
    }






}
