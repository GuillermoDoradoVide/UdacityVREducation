using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class SecondPost : MonoBehaviour {

    public VideoPlayer video_A;
    public VideoPlayer video_B;
    public ShowHideUI uiButton;

    public GameObject videoA;
    public GameObject videoB;

    public Text VideoShowingText;

    private void Start()
    {

    }

    public void loadVideoA()
    {
        video_B.Pause();
        videoB.SetActive(false);
        videoA.SetActive(true);
        VideoShowingText.text = "VIDEO 1º";
    }

    public void loadVideoB()
    {
        video_B.Pause();
        videoB.SetActive(true);
        videoA.SetActive(false);
        VideoShowingText.text = "VIDEO 2º";
    }

    public void disableInteractions()
    {
        if (video_A.isPlaying)
        {
            video_A.Pause();
        }
        if (video_B.isPlaying)
        {
            video_B.Pause();
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
