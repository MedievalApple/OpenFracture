using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleText : MonoBehaviour
{
    public Key toggleKey;

    public GameObject textObject;

    // Start is called before the first frame update
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard[toggleKey].wasPressedThisFrame)
        {
            textObject.SetActive(!textObject.activeSelf);
        }
    }
}
