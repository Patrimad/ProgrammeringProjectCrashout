using UnityEngine;
using TMPro;
public class Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public GameObject healthBar;

    public BarScript barScript;
    public TextMeshProUGUI healthText;
    
    public virtual void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
        barScript.SetHealth(currentHealth);
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Death();
        }

        UpdateHealthUI();
        barScript.SetHealth(currentHealth);
    }


    public virtual void Death()
    {
        Destroy(this.gameObject);
        UpdateHealthUI();
        barScript.SetHealth(currentHealth);
    }
    
    public virtual void Heal(int amount)
    {
        currentHealth += amount;
        UpdateHealthUI();
        barScript.SetHealth(currentHealth);
    }
    
    public virtual void Heal(int amount, GameObject prefab)
    {
        currentHealth += amount;
        UpdateHealthUI();
        barScript.SetHealth(currentHealth);
    }

    private void UpdateHealthUI()
    {
        if (healthText == null)
        {
            return;
        }
        healthText.text = $"{currentHealth}/{maxHealth}";
    }
}
