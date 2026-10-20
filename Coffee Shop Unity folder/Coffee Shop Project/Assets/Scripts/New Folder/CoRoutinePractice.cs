using UnityEngine;
using System.Collections;



public class CoRoutinePractice : MonoBehaviour
{
    [SerializeField]public float coffeeTimer = 5;
    private IEnumerator HeatCoffee()
    {
        yield return new WaitForSeconds(coffeeTimer);
        Debug.Log("Coffee is Done!");
        
    }

    void Start()
    {
        StartCoroutine(HeatCoffee());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
