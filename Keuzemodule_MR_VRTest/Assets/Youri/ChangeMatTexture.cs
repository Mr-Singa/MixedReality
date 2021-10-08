using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMatTexture : MonoBehaviour
{
    [SerializeField] private RenderTexture render;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
               this.gameObject.GetComponent<Renderer>().material.SetTexture("_Tex", render); 
    }
}
