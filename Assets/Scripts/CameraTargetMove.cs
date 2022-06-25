using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetMove : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.transform.position;
        this.transform.rotation = Quaternion.LookRotation(target.transform.forward);
    }
}
