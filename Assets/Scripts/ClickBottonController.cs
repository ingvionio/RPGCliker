using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ClickBottonController : MonoBehaviour
{
   [SerializeField] private Button _button;
   [SerializeField] private Image _image;


   public void Initialize(UnityAction clickAction)
   {
      // Инициализируем палитры кнопки
      // Визуальные изменения кнопки при кллике
   }
   public void SubscribeOnClick(UnityAction action)
   {
      _button.onClick.AddListener(action);
   }

   public void UnsubscribeOnClick(UnityAction action)
   {
      _button.onClick.RemoveListener(action);
   }
}
