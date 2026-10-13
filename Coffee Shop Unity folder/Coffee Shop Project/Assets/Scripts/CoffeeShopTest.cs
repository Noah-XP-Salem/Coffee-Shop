
using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
	public int coffeesSold = 2;
	public float coffeePrice = 3.50f;
	
	void Awake()
	{
		Debug.LogError("What you lookin at");
	}
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
