using UnityEngine;

public class TestViewPort : MonoBehaviour
{
    new Camera camera;
    Controls controls;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.Enable();
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var sp = controls.Default.ScreenPoint.ReadValue<Vector2>();
        var vp = camera.ScreenToViewportPoint(sp);
        
        Debug.Log($"{camera.name} : {sp} -> {vp}");
    }
}
