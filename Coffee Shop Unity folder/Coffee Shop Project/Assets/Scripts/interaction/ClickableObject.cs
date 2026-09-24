using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour, IClickable
{
    [SerializeField] private UnityEvent onClickAction;

    public void OnClick()
    {
        onClickAction?.Invoke();
        Debug.Log("Found the clickable object");
    }
}