using UnityEngine;

public class damage : MonoBehaviour
{
    public float StartingHealth;
    private float currentHealth;
	public float HealthThreshold;
    public GameObject healthbar;
	public float DamageDelta;

    void Update()
    {
        healthbar.transform.localScale = new Vector3(Mathf.Clamp(value: currentHealth / StartingHealth, min: 0, max: 1), y: 1, z: 1);
        if (GameObject.FindGameObjectsWithTag(tag: "Virus Count").Length >= HealthThreshold)
        {
            currentHealth -= DamageDelta * Time.deltaTime;
        }
    }
    
    void Awake()
    {
        currentHealth = StartingHealth;
    }
}

