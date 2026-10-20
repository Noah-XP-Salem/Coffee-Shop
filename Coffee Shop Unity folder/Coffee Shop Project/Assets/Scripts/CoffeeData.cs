using UnityEngine;


 public enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino,
        Americano,
        Mocha,
        None
    }

[CreateAssetMenu(fileName = "CoffeeData", menuName = "Scriptable Objects/CoffeeData")]
public class CoffeeData : ScriptableObject
{
    public float espressoPrice = 2.00f;
    public float lattePrice = 3.50f;
    public float cappuccinoPrice = 3.00f;
    public float americanoPrice = 2.50f;
    public float mochaPrice = 2.75f;
}
