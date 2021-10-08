using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRenderTexture : MonoBehaviour
{
    public Camera targetCamera;
    public RenderTexture cubeMapLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetCamera.RenderToCubemap(cubeMapLeft);
    }
}
