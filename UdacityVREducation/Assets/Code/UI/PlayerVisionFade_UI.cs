using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisionFade_UI : MonoBehaviour {

    public Transform mainCanvas;

    private CanvasGroup mainCanvasCanvasGroup;
    private bool isUIAnimationTransition;

    private void Awake()
    {
        if(mainCanvas == null)
        {
            Debug.LogWarning("(" + transform.name + ") VisionFade canvas hasn't beeing asigned.");
            Debug.Break();
        }

        mainCanvasCanvasGroup = mainCanvas.GetComponent<CanvasGroup>();
        if (mainCanvasCanvasGroup == null)
        {
            Debug.LogWarning("(" + mainCanvas.name + ") couldn't find canvas group component.");
            Debug.Break();
        }
        isUIAnimationTransition = false;
    }

    [ContextMenu("ShowUI")]
    public void show()
    {
        showHideDisplayInfo(1);
    }

    [ContextMenu("HideUI")]
    public void hide()
    {
        showHideDisplayInfo(0);
    }

    public void showHideDisplayInfo(float action, float speed = 1f)
    {
        isUIAnimationTransition = false;
        StartCoroutine(DisplayInfoVisibility(speed, action));
    }

    private IEnumerator DisplayInfoVisibility(float speed, float action)
    {
        float t = 0;
        float currentAlphaValue = mainCanvasCanvasGroup.alpha;
        isUIAnimationTransition = true;
        while (mainCanvasCanvasGroup.alpha != action && isUIAnimationTransition)
        {
            t += speed * Time.deltaTime;
            mainCanvasCanvasGroup.alpha = Mathf.Lerp(currentAlphaValue, action, t);
            yield return null;
        }
        isUIAnimationTransition = false;
    }
}
