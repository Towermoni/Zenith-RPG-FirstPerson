using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Item : IGeneric
{
    string itemName { get; set; }
  //  int Value { get; set; }
    int Quantity { get; set; }
   // double Weight { get; set; }
}
