using UnityEngine;

public class CoffeeCheck : MonoBehaviour
{
    public bool blackCoffee = false;
    public bool cappuccino = false;
    public bool latte = false;
    public bool pepsi = false;
    public bool coke = false;
    void Start()
    {
         if (blackCoffee)
        {
            Debug.Log("Customer Wants Black Coffee!");
        }
        else if (cappuccino)
        {
            Debug.Log("Customer Wants Cappuccino!");
        }
        else if (latte)
        {
            Debug.Log("Customer Wants Latte!");
        }
        else if (pepsi)
        {
            Debug.Log("Customer Wants Pepsi!");
        }
        else if (coke)
        {
            Debug.Log("Customer Wants Coke!");
        }
        else
        {
            Debug.Log("Customer Hasnt Decided Yet..");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
