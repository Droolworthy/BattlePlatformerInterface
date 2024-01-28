using UnityEngine;

public class HealthBarPlayer : Bar
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.PlayerHealthChanged += OnValueChanged;

        Wellness.value = 1;
    }

    private void OnDisable()
    {
        _player.PlayerHealthChanged -= OnValueChanged;
    }
}
