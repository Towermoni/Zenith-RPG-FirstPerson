using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPick : MonoBehaviour, Item
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string itemName { get; set; }
    public int Value { get; set; }
    public int Quantity { get; set; }
    public double Weight { get; set; }

    public LockPick()
    {
        itemName = "Lock Pick";
        Value = 3;
        Quantity = 1;
        Weight = 0.5;
    }


}
