using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poepzooi : MonoBehaviour
{
    public int camerNum;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        Debug.Log("Number of web cams connected: " + devices.Length);
        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log(i + " " + devices[i].name);
        }
        string camName = devices[camerNum].name;
        Debug.Log("The webcam name is " + camName);
        Renderer rend = this.GetComponentInChildren<Renderer>();
        WebCamTexture mycam = new WebCamTexture();

        mycam.deviceName = camName;
        rend.material.mainTexture = mycam;

        mycam.Play();
    }
}
