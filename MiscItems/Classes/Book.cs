using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour, Item
{
    public string itemName { get; set; }
    public int ID { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }
    public int Quantity { get; set; }
    public double Weight { get; set; }

    public Book()
    {
        itemName = "Book";
        Value = 5;
        Quantity = 1;
        Weight = 2.0;
    }

}
