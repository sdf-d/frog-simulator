using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents
{

  public class BaseEvent<T> : ScriptableObject
  {
      public List<BaseEventListener<T>> ListenerList;

      public void InvokeEvent(T eventData)
      {
        for (int i = ListenerList.Count - 1; i >= 0; i--)
          {
              ListenerList[i].HandleEvent(eventData);
          }
      }

      public void AddListener(BaseEventListener<T> li)
      {
        ListenerList.Add(li);
      }
      public void RemoveListener(BaseEventListener<T> li)
      {
        ListenerList.Remove(li);
      }
  }


}
