using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _damage;

    private int _currentHealth;

    public UnityAction<int, int> PlayerHealthChanged;

    private void Start()
    {
        _currentHealth = _health;
    } 

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;

        PlayerHealthChanged?.Invoke(_currentHealth, _health);

        if(_currentHealth <= 0)
            Destroy(gameObject);
    }
}
