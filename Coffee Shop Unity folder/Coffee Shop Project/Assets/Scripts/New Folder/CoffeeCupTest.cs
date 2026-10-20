using UnityEngine;

public class CoffeeCupTest : MonoBehaviour
{
    [SerializeField] private string[] coffeeMenu = {"Dark Coffee" , "Light Coffee" , "Milk" , "Tea" , "Mocha"};
    [SerializeField] private int beans = 10;
    [SerializeField] private int cupsPlaced = 0;
    void Start()
    {
        
        for (int i = 0; i < 10; i++ )
        {
        Debug.Log("Coffee Cup number " + i);
        cupsPlaced++;
        }
        if (cupsPlaced == 10)
        {
            while (beans > 0)
            {
                Debug.Log("One Coffee Made!");
                beans--;
                Debug.Log("Beans Left = " + beans);
            }
            Debug.Log(coffeeMenu);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
