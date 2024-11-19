using UnityEngine;

public class orthographicSize : MonoBehaviour
{
    private Camera mainCamera;
    private float initialAspectRatio;
    private float initialOrthographicSize;

    void Start()
    {
        mainCamera = GetComponent<Camera>();

        initialAspectRatio = (float)Screen.width / Screen.height;
        initialOrthographicSize = mainCamera.orthographicSize;
    }

    void Update()
    {
        float currentAspectRatio = (float)Screen.width / Screen.height;

        mainCamera.orthographicSize = initialOrthographicSize * (initialAspectRatio / currentAspectRatio);
    }
}
