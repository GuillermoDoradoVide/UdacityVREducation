using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class Third : MonoBehaviour {

    public VideoPlayer videoA;
    public VideoPlayer videoB;
    public ShowHideUI uiButton;
    private void Start()
    {

    }

    public void disableInteractions()
    {
        if (videoA.isPlaying)
        {
            videoA.Pause();
        }
        if (videoB.isPlaying)
        {
            videoB.Pause();
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
