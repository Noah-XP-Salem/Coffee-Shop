using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    [SerializeField] private int beans = 3;
    [SerializeField] private int refills = 0;
    [SerializeField] private int maxRefills = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        while (beans > 0)
        {
            beans--;
            Debug.Log("Served a coffee, Beans left: " + beans);
        }
        do
        {
            Debug.Log(" Serving coffee refill number: " + refills);
            refills++;    
        } 
        while (refills < maxRefills);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
