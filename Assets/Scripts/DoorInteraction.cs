using UnityEngine;
using UnityEngine.Events;

public class DoorInteraction : MonoBehaviour
{
    public UnityEvent OnPressedKeyEvent;    
    private bool isOnTriggerZone = false;

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        if (isOnTriggerZone)
        {
            OnPressedKeyEvent.Invoke();
        }
    }
}

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        isOnTriggerZone = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
        isOnTriggerZone = false;
    }
}
