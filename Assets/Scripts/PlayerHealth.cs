using UnityEngine;

public class PlayerHealth : Health
{
    public GameObject deathScreen;

    public override void Death()
    {
        if (deathScreen != null)
        {
            deathScreen.SetActive(true);
        }
    }
    
}
