using UnityEngine;

public class HealthBarEnemy : Bar
{
    [SerializeField] private Enemy _enemy;

    private void OnEnable()
    {
        _enemy.EnemyHealthChanged += OnValueChanged;

        Wellness.value = 1;
    }

    private void OnDisable()
    {
        _enemy.EnemyHealthChanged -= OnValueChanged;
    }
}
