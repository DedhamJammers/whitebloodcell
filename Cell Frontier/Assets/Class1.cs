using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    public float startingHealth = 100;
    public float currentHealth;
    public Image healthbar;

    void Update()
    {
        healthbar.transform.localScale = new Vector3(currentHealth / 100f, 1, 1);
        if (GameObject.FindGameObjectsWithTag("Virus").Length >= 1)
        {
            currentHealth -= 5 * Time.deltaTime;
        }
    }

    bool isdead;
    bool isdamaged;
    void Awake()
    {
        transform.localScale=new Vector3(1, 1, 1);
    }

}

