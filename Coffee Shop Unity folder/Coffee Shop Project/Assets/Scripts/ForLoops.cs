using UnityEngine;

public class ForLoops : MonoBehaviour
{
    [SerializeField] private string[] coffeeMenu = {"Espresso" , "Latte" , "Mocha" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (string coffee in coffeeMenu)
        {
            Debug.Log("Now Serving: " + coffee);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
