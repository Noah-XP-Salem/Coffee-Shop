
using UnityEngine;

public class CoffeePriceHangler : MonoBehaviour
{
    [SerializeField] private CoffeeData CoffeeData;
    [SerializeField] private CoffeeType CoffeeType;
    void Start()
    {
        float price = GetCoffeePrice(CoffeeType);
        Debug.Log($"{CoffeeType} costs £{price:F2}");
    }

    private float GetCoffeePrice(CoffeeType type)
    {
        switch (type)
        {
            case CoffeeType.Espresso:
                return CoffeeData.espressoPrice;
            case CoffeeType.Latte:
                return CoffeeData.lattePrice;
            case CoffeeType.Cappuccino:
                return CoffeeData.cappuccinoPrice;
            case CoffeeType.Americano:
                return CoffeeData.americanoPrice;
            case CoffeeType.Mocha:
                return CoffeeData.mochaPrice;
            default:
                return 0f;
        }
    }
}
