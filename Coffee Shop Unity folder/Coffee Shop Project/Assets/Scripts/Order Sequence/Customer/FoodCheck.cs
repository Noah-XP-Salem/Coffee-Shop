using UnityEngine;

public class FoodCheck : MonoBehaviour
{
    public bool doritoCrisps = false;
    public bool hullaHoopsCrisps = false;
    public bool walkersCrisps = false;
    public bool pringlesCrisps = false;
    public bool smallCake = false;
    public bool mediumCake = false;
    public bool largeCake = false;
    public bool cupcake = false;
    void Start()
    {
        if (doritoCrisps)
        {
            Debug.Log("Customer wants some Doritos!");
        }
        else if (hullaHoopsCrisps)
        {
            Debug.Log("Customer wants some Hulla Hoops!");
        }
        else if (walkersCrisps)
        {
            Debug.Log("Customer wants some Walkers!");
        }
        else if (pringlesCrisps)
        {
            Debug.Log("Customer wants some Pringles");
        }
        else if (smallCake)
        {
            Debug.Log("Customer wants a small cake!");
        }
        else if (mediumCake)
        {
            Debug.Log("Customer wants a Medium cake!");
        }
        else if (largeCake)
        {
            Debug.Log("Customer wants a large cake!");
        }
        else if (cupcake)
        {
            Debug.Log("Customer wants a cupcake!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
