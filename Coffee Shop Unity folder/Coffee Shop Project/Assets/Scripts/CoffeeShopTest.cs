using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
	public int coffeesSold = 2;
	public float coffeePrice = 3.50f;

	void Start()
	{
		Debug.Log("Coffees sold:  " + coffeesSold);
		AddCoffee();
	}

	void AddCoffee()
	{
		coffeesSold++;	
		coffeesSold = coffeesSold * 5;
		Debug.Log("Coffees sold:  " + coffeesSold);
	}
	
}
