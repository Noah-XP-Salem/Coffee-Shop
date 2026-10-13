using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public float[] values;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(float value in values)
        {
            Debug.Log(value);
        }

            values = new float[10];

            values[1] = 5.0F;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
