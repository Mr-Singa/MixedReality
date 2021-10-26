using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBoxColider : MonoBehaviour
{
    private Animator _Button;

    public void EnableCollider()
    {
        _Button = gameObject.GetComponent<Animator>();
        Invoke("NuWerkHetWel", 1);
        _Button.SetTrigger("ButtonUnpressed");
    }

    private void NuWerkHetWel()
    {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
