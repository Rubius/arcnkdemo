using DG.Tweening;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public float max = 1.05f;
    public float duration = .5f;
    public Ease ease = Ease.Linear;

    private void Start() => this.transform.DOScale(max, duration).SetEase(ease).SetLoops(-1, LoopType.Yoyo);
}
