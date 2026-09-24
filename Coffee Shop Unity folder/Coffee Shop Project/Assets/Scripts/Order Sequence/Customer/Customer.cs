using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour, OrderHelper
{
    // static is a new keyword
    // static means that it is per class and not per instant of a class
    public readonly static string drinkType = "coffee";
    public string exampleVariable = "tea";
    public UnityEvent raiseOrder;


    void Start()
    {
        RequestDrinkType(drinkType);
    }

    void RequestDrinkType(string drinkType)
    {
        raiseOrder?.Invoke();
        Debug.Log(drinkType);
    }
}
