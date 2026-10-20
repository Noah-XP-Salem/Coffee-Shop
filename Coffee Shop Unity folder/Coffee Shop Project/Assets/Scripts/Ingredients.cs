using UnityEngine;

public enum Allergies
{
    Milk,
    Gluten
}
[CreateAssetMenu(fileName = "Ingredients", menuName = "Scriptable Objects/Ingredients")]
public class Ingredients : ScriptableObject
{
    public float price;
    public float quantity;
    public float quantityAvaliable;
    public bool inStock;
    public Allergies[] allergies;
}
