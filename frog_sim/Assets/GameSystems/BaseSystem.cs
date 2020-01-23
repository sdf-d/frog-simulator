using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystems
{

  public interface BaseSystem
  {
      void UpdateSystem();
      void AddItem(dynamic item);
      void RemoveItem(dynamic item);
  }
}
