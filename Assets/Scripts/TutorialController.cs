using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TutorialController : MonoBehaviour
{
    [Header("UI")] public RawImage defectoscopeUi;
    public Texture uiIntroTexture;
    public Texture startUiTexture;
    public Texture[] uiTextures;

    [Header("Timings")] public float fadeInDuration = .5f;
    public float fadeOutDuration = .3f;
    public float introInDuration = 1f;
    public float introDuration = 1f;
    public float introOutDuration = 1f;
    public float startDelay = 1f;
    public float midStepDelay = .5f;

    [Header("Steps")] public CanvasGroup step0;
    public CanvasGroup step1;
    public CanvasGroup step2;
    public CanvasGroup step3;
    public CanvasGroup step4;

    [Header("Other")] public GameObject lines;

    private int _currentUiTexture = 0;

    private void Start() =>
        DOTween.Sequence()
            .OnStart(() =>
            {
                defectoscopeUi.color = Color.black;
                defectoscopeUi.texture = null;
                lines.SetActive(false);
                step1.gameObject.SetActive(false);
                step2.gameObject.SetActive(false);
                step3.gameObject.SetActive(false);
                step4.gameObject.SetActive(false);
            }).PrependInterval(startDelay)
            .Append(Show(step0));

    public void OnStep0() =>
        DOTween.Sequence()
            .OnStart(() =>
            {
                step0.interactable = false;
                defectoscopeUi.color = Color.black;
            }).Append(Hide(step0))
            .Join(defectoscopeUi
                .DOColor(Color.white, introInDuration)
                .OnStart(() => defectoscopeUi.texture = uiIntroTexture))
            .AppendInterval(introDuration)
            .Append(defectoscopeUi
                .DOColor(Color.black, introOutDuration)
                .From(Color.white)
                .OnComplete(() =>
                {
                    defectoscopeUi.color = Color.white;
                    defectoscopeUi.texture = startUiTexture;
                    lines.SetActive(true);
                }))
            .AppendInterval(midStepDelay)
            .Append(Show(step1));

    public void OnStep1() =>
        DOTween.Sequence()
            .OnStart(() =>
            {
                step1.interactable = false;
                defectoscopeUi.texture = uiTextures[_currentUiTexture];
            })
            .Append(Hide(step1))
            .AppendInterval(midStepDelay)
            .Append(Show(step2));

    public void OnStep2() =>
        DOTween.Sequence()
            .OnStart(() => step2.interactable = false)
            .Append(Hide(step2))
            .AppendInterval(midStepDelay)
            .Append(Show(step3));

    public void OnStep3(int val)
    {
        _currentUiTexture += val;
        _currentUiTexture = Mathf.Clamp(_currentUiTexture, 0, uiTextures.Length - 1);
        defectoscopeUi.texture = uiTextures[_currentUiTexture];
        if (_currentUiTexture == uiTextures.Length - 1)
        {
            DOTween.Sequence()
                .OnStart(() => step3.interactable = false)
                .Append(Hide(step3))
                .AppendInterval(midStepDelay)
                .Append(Show(step4));
        }
    }

    public void OnStep4() =>
        DOTween.Sequence()
            .OnStart(() => step4.interactable = false)
            .Append(Hide(step4));

    private Tween Show(CanvasGroup canvasGroup) =>
        canvasGroup.DOFade(1f, fadeInDuration)
            .OnStart(() => canvasGroup.gameObject.SetActive(true))
            .From(0f);

    private Tween Hide(CanvasGroup canvasGroup) =>
        canvasGroup.DOFade(0f, fadeOutDuration)
            .From(1f)
            .OnComplete(() => canvasGroup.gameObject.SetActive(false));
}
