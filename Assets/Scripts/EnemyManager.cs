using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private Transform _enemyContainer;
    [SerializeField] private EnemiesConfig _enemiesConfig;
    private EnemyData _currentEnemyData;
    private Enemy _currentEnemy;
    private HealthBar _healthBar;

    public void Initialize(HealthBar healthBar)
    {
        _healthBar = healthBar;
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        _currentEnemyData = _enemiesConfig.Enemies[0];
        _currentEnemy = Instantiate(_enemiesConfig.EnemyPrefab, _enemyContainer);
        _currentEnemy.Initialize(_currentEnemyData);
        
        
        
        InitHPBar();
    }

    private void InitHPBar()
    {
        _healthBar.ShowHPBar();
        _healthBar.SetMaxValue(_currentEnemyData.Health);
        _currentEnemy.OnDamage += _healthBar.SetDecreaseValue;
        _currentEnemy.OnDeath += _healthBar.HideHPBar;
    }

    public void DamageCurrentEnemy(float damage)
    {
        _currentEnemy.DoDamage(damage);
        Debug.Log($"Damaged!{damage}");
    }

    
}