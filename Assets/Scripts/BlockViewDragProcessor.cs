using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

#if UNITY_EDITOR
[InitializeOnLoad]
#endif
public class BlockViewDragProcessor : InputProcessor<Vector2>
{
#if UNITY_EDITOR
    static BlockViewDragProcessor()
    {
        Initialize();
    }
#endif

    [RuntimeInitializeOnLoadMethod]
    static void Initialize()
    {
        InputSystem.RegisterProcessor<BlockViewDragProcessor>();
    }

    public override Vector2 Process(Vector2 value, InputControl control)
    {
        var cm = Utils.Controls.Default.CameraMovement.ReadValue<float>() < .5f;
        var inside = Utils.IsInsideCamera3DViewPort();

        if (cm || !inside)
            return Vector2.zero;

        return value;
    }
}
