using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void ShowHPBar()
    {
        gameObject.SetActive(true);
    }

    public void HideHPBar()
    {
        gameObject.SetActive(false);
    }
    public void SetMaxValue(float value)
    {
        _slider.maxValue = value;
        _slider.value = value;
    }

    public void SetDecreaseValue(float value)
    {
        _slider.value -= value;
    }
    
}
