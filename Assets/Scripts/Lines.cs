using UnityEngine;

public class Lines : MonoBehaviour
{
    public Detector detector;
    public Vector3 offset;
    public LineRenderer red;
    public LineRenderer blue;
    [Range(0, 5)] public int blueAmount = 1;
    [Range(0, 180f)] public float angle = 50f;
    public LayerMask mask;

    private Transform detectorTransform;

    private void Start()
    {
        detectorTransform = detector.transform;
        red.positionCount = 2;
    }

    private void Update()
    {
        var redStart = detectorTransform.localPosition + offset;
        red.SetPosition(0, redStart);

        var redDir = new Vector3(0, -Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle));
        Physics.Raycast(redStart, redDir, out var hit, 20f, mask);
        var blueStart = hit.point;
        var blueDir = Vector3.Reflect(redDir,hit.normal);
        red.SetPosition(1, blueStart);
        blue.positionCount = blueAmount + 1;
        blue.SetPosition(0,blueStart);

        for (int i = 1; i <= blueAmount; i++)
        {
            Physics.Raycast(blueStart, blueDir, out hit, 20f, mask);
            blueStart = hit.point;
            blueDir = Vector3.Reflect(blueDir, hit.normal);
            blue.SetPosition(i, blueStart);
        }
    }
}
