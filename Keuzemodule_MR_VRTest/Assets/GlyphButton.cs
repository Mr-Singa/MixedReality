using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlyphButton : MonoBehaviour
{

    private List<GameObject> InputObjects = new List<GameObject>();
    [SerializeField] private List<GameObject> CorrectOrder;
    public UnityEvent Correct = new UnityEvent();
    private UnityEvent InCorrect = new UnityEvent();
    private GameObject[] buttons;

    void Start()
    {
     buttons = GameObject.FindGameObjectsWithTag("button");
        for (int i = 0; i < buttons.Length; i++)
        {
            InCorrect.AddListener(buttons[i].GetComponent<ActiveBoxColider>().EnableCollider);
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HITTT");

            InputObjects.Add(other.gameObject);
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

            if (InputObjects.Count >= CorrectOrder.Count)
            {
                int temp = 0;
                for (int i = 0; i < InputObjects.Count; i++)
                {
                    if (InputObjects[i] == CorrectOrder[i])
                    {
                        temp++;
                    }
                }

                if (temp == CorrectOrder.Count)
                {
                    Debug.Log("LITTT");
                    Correct.Invoke();
                }
                else
                {
                    InCorrect.Invoke();
                    Debug.Log("WRONG");
                }
                InputObjects.Clear();
            }
        
    }
}
