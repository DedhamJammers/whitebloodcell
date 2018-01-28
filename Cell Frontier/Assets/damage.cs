using UnityEngine;

public class Damage : MonoBehaviour
{
    public float startingHealth = 100;
    public float currentHealth;
    public GameObject healthbar;

    void Update()
    {
        healthbar.transform.localScale = new Vector3(Mathf.Clamp(value: currentHealth / 100f, min: 0, max: 1), y: 1, z: 1);
        if (GameObject.FindGameObjectsWithTag(tag: "Virus Count").Length >= 150)
        {
            currentHealth -= 5 * Time.deltaTime;
        }
    }
    
    void Awake()
    {
        currentHealth = startingHealth;
    }
}

