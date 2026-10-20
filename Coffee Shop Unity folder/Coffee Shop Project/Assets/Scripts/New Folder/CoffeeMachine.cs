using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    public bool coffeeMachineOn = true;
    void Start()
    {
        if (coffeeMachineOn)
        {
            Debug.LogError("Take a look around you");
            Debug.Log("Brewing Coffee!");
        }
        else
        {
            Debug.LogError("WHERE are you going");
            Debug.Log("turn it on");
        
        }
        Debug.LogError("I dunnooo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
