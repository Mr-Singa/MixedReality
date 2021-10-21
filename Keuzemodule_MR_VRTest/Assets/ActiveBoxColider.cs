using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBoxColider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableCollider()
    {
        Invoke("NuWerkHetWel",1);
    }

    private void NuWerkHetWel()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
