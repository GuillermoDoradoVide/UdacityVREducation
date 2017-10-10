using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : SingletonComponent<LevelController> { 

    public GameObject player;
    private PlayerController playerController;

    public GameObject firstPost;
    public FirstPost first;
    public GameObject secondPost;
    public SecondPost second;
    public GameObject thirdPost;
    public Third third;
    public GameObject forthPost;
    public ForthPost forth;
    public GameObject fithPost;
    public FifthPost fith;

    public GameObject sixPost;
    public StartPost Sith;

    public GameObject infoPanel;

    // Use this for initialization
    private void Awake () {
        if (player == null)
        {
            Debug.LogWarning("(" + transform.name + ")  (gameobject)Player hasn't beeing asigned.");
            Debug.Break();
        }
        playerController = player.GetComponent<PlayerController>();

    }

    private void Start()
    {
        playerController.init();
        QualitySettings.antiAliasing = 4;
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 0;
    }

    // Update is called once per frame
    private void Update () {
		
	}

    public void startDemo()
    {
        StartCoroutine(initialiceIntroDemo());
    }

    private IEnumerator initialiceIntroDemo()
    {
        yield return new WaitForSeconds(1.5f);
        firstPost.SetActive(true);
        first.init();
        playerController.playAmbientSound();
    }

    public void initMuseum()
    {
        playerController.stopAmbientSound();
        playerController.changeAmbientSound();
        playerController.playAmbientSound();
        //setStart();
    }

    public void hideInfoPanels()
    {
        infoPanel.SetActive(false);
    }

    public void showInfoPanels()
    {
        infoPanel.SetActive(true);
        hideStart();
        hideSecond();
        hideThird();
        hideForth();
        hideFitfh();
    }

    public void setfirst()
    {
        firstPost.SetActive(true);
    }

    public void hidefirst()
    {
        firstPost.SetActive(false);
    }

    public void setSecond()
    {
        secondPost.SetActive(true);
    }

    public void hideSecond()
    {
        secondPost.SetActive(false);
    }

    public void setThird()
    {
        thirdPost.SetActive(true);
    }

    public void hideThird()
    {
        thirdPost.SetActive(false);
    }

    public void setForth()
    {
        forthPost.SetActive(true);
    }

    public void hideForth()
    {
        forthPost.SetActive(false);
    }

    public void setFitfh()
    {
        fithPost.SetActive(true);
    }

    public void hideFitfh()
    {
        fithPost.SetActive(false);
    }

    public void setStart()
    {
        sixPost.SetActive(true);
    }

    public void hideStart()
    {
        sixPost.SetActive(false);
    }
}
