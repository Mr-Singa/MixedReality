using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlyphButton : MonoBehaviour
{
    [SerializeField] private GlyphButton AnderHand;
    private Animator _Button = new Animator();
    public List<GameObject> InputObjects = new List<GameObject>();
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
        InCorrect.AddListener(gameObject.GetComponent<GlyphButton>().ResetHand);
        InCorrect.AddListener(AnderHand.ResetHand);
    }

    public void ResetHand()
    {
        gameObject.GetComponent<SphereCollider>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("button"))
        {
            Debug.Log("HITTT");

            _Button = other.gameObject.GetComponent<Animator>();
            _Button.SetTrigger("ButtonPressed");
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
                    gameObject.GetComponent<SphereCollider>().enabled = false;
                }
                else
                {
                    InCorrect.Invoke();
                    Debug.Log("WRONG");
                }
                InputObjects.Clear();
                AnderHand.InputObjects.Clear();
            }
        }
        
    }
}
