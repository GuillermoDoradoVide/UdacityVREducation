using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class FifthPost : MonoBehaviour {

    public VideoPlayer video;
    public ShowHideUI uiButton;
    private void Start()
    {

    }

    public void disableInteractions()
    {
        if (video.isPlaying)
        {
            video.Pause();
        }
        StartCoroutine(closePost());
    }

    private IEnumerator closePost()
    {
        uiButton.hideUI();
        yield return new WaitForSeconds(1);
        LevelController.Instance.showInfoPanels();
    }

    public void OnEnable()
    {
        StartCoroutine(enableUI());
    }

    private IEnumerator enableUI()
    {
        yield return new WaitForSeconds(1);
        uiButton.showUI();
    }
}
