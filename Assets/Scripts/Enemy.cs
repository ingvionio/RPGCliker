using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Image _image;
    
    
    public event UnityAction<float> OnDamage;
    public event UnityAction OnDeath;
    private float _health;

    public void Initialize(EnemyData enemyData)
    {
        _health = enemyData.Health;
        _image.sprite = enemyData.Sprite;
    }

    public void DoDamage(float damage)
    {
        if (damage >= _health)
        {
            _health = 0;
            
            OnDamage?.Invoke(damage);
            OnDeath?.Invoke();
            return;
        }
        
        _health -= damage;
        OnDamage?.Invoke(damage);
    }

    public float GetHealth()
    {
        return _health;
    }
}