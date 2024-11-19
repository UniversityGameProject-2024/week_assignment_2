using UnityEngine;
using UnityEngine.InputSystem;

public class playerMover : MonoBehaviour
{
    [Tooltip("Object speed, in meters per second")]
    [SerializeField] float stepSize = 1;

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField]
    private void OnEnable()
    {
        moveRight.Enable();
        moveLeft.Enable();
        moveDown.Enable();
        moveUp.Enable();
    }

    private void OnDisable()
    {
        moveRight.Disable();
        moveLeft.Disable();
        moveDown.Disable();
        moveUp.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, stepSize, 0);
        }
        else if (moveDown.WasPressedThisFrame())
        {
            transform.position += new Vector3(0, -stepSize, 0);
        }
        else if (moveLeft.WasPressedThisFrame())
        {
            transform.position += new Vector3(-stepSize, 0, 0);
        }
        else if (moveRight.WasPressedThisFrame())
        {
            transform.position += new Vector3(stepSize, 0, 0);
        }
    }
}
