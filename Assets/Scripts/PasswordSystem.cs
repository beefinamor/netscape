using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PasswordSystem : MonoBehaviour
{
    public string correctPassword = "2265";
    public string passwordInput = "";
    public GameObject passwordCanvas;
    public BoxCollider2D enterDoorTrigger;

    public TMP_Text uiPassword;
    public AudioClip correctSound;
    public AudioClip inCorrectSound;
    public AudioSource audioSource;

    public SpriteRenderer door;
    public Sprite openedDoor;

    private bool locked = false;

    public void SelectNumber(string number)
    {
        if (!locked)
        {
            if (passwordInput.Length < 4)
            {
                passwordInput += number;
                if (passwordInput.Length == 4)
                {
                    uiPassword.text = passwordInput;
                    VerifyPassword();
                }
            }
            else
            {
                passwordInput = number;
            }
        }
        uiPassword.text = passwordInput;
    }

    public void VerifyPassword()
    {
        if (passwordInput == correctPassword)
        {
            uiPassword.color = Color.green;
            if (correctSound != null)
            {
                audioSource.clip = correctSound;
                audioSource.Play();
            }
            CorrectPassword();
        }
        else
        {
            locked = true;
            uiPassword.color = Color.red;
            Invoke(nameof(Unlock), .8f);
            if (inCorrectSound != null)
            {
                audioSource.clip = inCorrectSound;
                audioSource.Play();
            }
        }
    }

    private void Unlock()
    {
        locked = false;
        passwordInput = "";
        uiPassword.color = Color.white;
        uiPassword.text = passwordInput;
    }

    public void CorrectPassword()
    {
        passwordCanvas.SetActive(false);
        door.sprite = openedDoor;
        enterDoorTrigger.enabled = true;        
    }

}
