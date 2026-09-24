

using UnityEngine;

public class OrderingManager : MonoBehaviour
{
    void Start()
    {
        ProcessOrder();
    }
    void ProcessOrder()
    {
        Debug.Log(Customer.drinkType);
    }
}