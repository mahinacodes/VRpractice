using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TextMeshProUGUI healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + health; 
        UpdateHealth(0);
    }

    public void UpdateHealth(int healthToChange)
    {
        health -= healthToChange;
        healthText.text = "Health: " + health; 
    }
}
