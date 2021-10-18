using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToTexture : MonoBehaviour
{
    public Camera targetCamera;
    public RenderTexture cubeMapLeft;
    public RenderTexture Bingo;

    // Update is called once per frame
    void Update()
    {
        targetCamera.RenderToCubemap(cubeMapLeft);
        cubeMapLeft.ConvertToEquirect(Bingo);
    }
}
