using UnityEngine;

public class BoatStatus:MonoBehaviour
{
    public int _currentHealth;
    public int _currentMaxHealth;
    public int _currentArmor;
    public int _currentMaxArmor;

    public void TakeDamage(int damage)
    {
        int armorTaken=Mathf.CeilToInt(damage / 2f);
        
        _currentArmor -= armorTaken;
        if (_currentArmor<=0)
        {
            _currentArmor = 0;
        }

        _currentHealth -= (damage-armorTaken);
        if (_currentHealth<=0)
        {
            _currentHealth = 0;
        }
    }
}