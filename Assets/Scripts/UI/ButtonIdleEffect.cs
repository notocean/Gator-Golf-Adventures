using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class ButtonIdleEffect : MonoBehaviour
{
    [SerializeField] AnimationCurve curve;
    [SerializeField] float scaleFactor = 1f;
    [SerializeField] float circleTime;

    RectTransform rectTrans;
    float timer = 0f;

    private void Awake()
    {
        rectTrans = GetComponent<RectTransform>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > circleTime) timer = 0f;

        float scale = curve.Evaluate(timer / circleTime) * scaleFactor;
        rectTrans.localScale = new Vector3(scale, scale, scale);
    }
}
