using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class damage : MonoBehaviour
{
    public float startingHealth = 100;
    public float currentHealth;
    public GameObject healthbar;

    void Update()
    {
        healthbar.transform.localScale = new Vector3(currentHealth / 100, 1, 1);
        if (GameObject.FindGameObjectsWithTag("Virus").Length >= 1)
        {
            currentHealth -= 5 * Time.deltaTime;

            {
                
            }
        }
    }

    bool isdead;
    bool isdamaged;
    void Awake()
    {
        currentHealth = startingHealth;
        transform.localScale = new Vector3(1, 1, 1);
    }

}

