using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceHandler : MonoBehaviour
{
    public GameObject cubeToDestroy;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (cubeToDestroy != null)
            {
                Destroy(cubeToDestroy);
                Debug.Log("Cube destroyed!");
            }
        }
    }
}