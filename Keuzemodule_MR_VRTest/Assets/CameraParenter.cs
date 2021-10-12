using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraParenter : MonoBehaviour
{
    public GameObject VrCamera;
    public Vector3 ofset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = VrCamera.transform.position + ofset;
        transform.rotation = VrCamera.transform.rotation;
    }
}
