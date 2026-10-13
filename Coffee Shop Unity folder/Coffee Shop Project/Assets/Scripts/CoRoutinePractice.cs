using UnityEngine;
using System.Collections;


public class CoRoutinePractice : MonoBehaviour
{
    [SerializeField]public float coffeeTimer = 5;
    private IEnumerator HeatCoffee()
    {
        Debug.LogError("You Suck At Coding");
        yield return new WaitForSeconds(coffeeTimer);
        Debug.Log("..is that freddy fazbear.");
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
