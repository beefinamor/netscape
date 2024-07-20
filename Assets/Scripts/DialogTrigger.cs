using System;
using UnityEngine;
using UnityEngine.Events;

public class DialogTrigger : MonoBehaviour
{
    public UnityEvent WhenEnterTriggerEvent;
    public UnityEvent WhenExitTriggerEvent;

    private void OnTriggerEnter2D(Collider2D other)
    {
        WhenEnterTriggerEvent.Invoke();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        WhenExitTriggerEvent.Invoke();
    }
}