using UnityEngine;

public static class Utils
{
    public static Controls Controls { get; private set; }
    public static Camera Camera3D { get; set; }

    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        Controls = new Controls();
        Controls.Enable();
    }

    public static bool IsInsideCamera3DViewPort()
    {
        if (Camera3D == null) return false;
        
        var sp = Controls.Default.ScreenPoint.ReadValue<Vector2>();
        var vp = Camera3D.ScreenToViewportPoint(sp);

        if (vp.x < 0 || vp.x > 1) return false;
        if (vp.y < 0 || vp.y > 1) return false;
        
        return true;
    }
}