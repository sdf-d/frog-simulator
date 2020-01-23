using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

namespace GameEvents
{

  public abstract class BaseEventListener<T> : MonoBehaviour
  {

      public BaseEvent<T> eventt;
      //[SerializeField]
      //private UnityEvent response; // 3

      private void OnEnable()
      {
          eventt.AddListener(this);
      }

      private void OnDisable()
      {
          eventt.RemoveListener(this);
      }

      public abstract void HandleEvent(T eventData);
  }


}
