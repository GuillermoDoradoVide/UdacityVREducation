using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMovement : MonoBehaviour {

    public GameObject plotPointObjectSin;
    public GameObject plotPointObjectCos;
    public int numberOfPoints = 100;
    public float animSpeed = 1.0f;
    public float scaleInputRange = 2 * Mathf.PI; // scale number from [0 to 99] to [0 to 2Pi]
    public float scaleResult = 10.0f;
    public bool animate = true;
    public float objectScale = 0.1f;

    public Transform parentSin;
    public Transform parentCos;

    GameObject[] plotPoints;
    GameObject[] CosplotPoints;

    // Use this for initialization
    private void Awake()
    {

        if (plotPointObjectSin == null) //if user did not fill in a game object to use for the plot points
            plotPointObjectSin = GameObject.CreatePrimitive(PrimitiveType.Sphere); //create a sphere

        plotPoints = new GameObject[numberOfPoints]; //creat an array of 100 points.
        CosplotPoints = new GameObject[numberOfPoints];

        for (int i = 0; i < numberOfPoints; i++)
        {
            plotPoints[i] = (GameObject)GameObject.Instantiate(plotPointObjectSin, new Vector3((i - (numberOfPoints / 2)) * objectScale, 0, 0), Quaternion.identity); //this specifies what object to create, where to place it and how to orient it
            plotPoints[i].transform.SetParent(parentSin);
            CosplotPoints[i] = (GameObject)GameObject.Instantiate(plotPointObjectCos, new Vector3((i - (numberOfPoints / 2)) * objectScale, 0, 0), Quaternion.identity); //this specifies what object to create, where to place it and how to orient it
            CosplotPoints[i].transform.SetParent(parentCos);
        }
        //we now have an array of 100 points- your should see them in the hierarchy when you hit play
        plotPointObjectSin.SetActive(false); //hide the original
        plotPointObjectCos.SetActive(false);

    }
    //
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < numberOfPoints; i++)
        {
            float functionXvalue = i * scaleInputRange / numberOfPoints; // scale number from [0 to 99] to [0 to 2Pi]
            if (animate)
            {
                functionXvalue += Time.time * animSpeed;
            }
            plotPoints[i].transform.localPosition = new Vector3((i - (numberOfPoints / 2)) * objectScale, ComputeFunction(functionXvalue) * scaleResult, 0);
            CosplotPoints[i].transform.localPosition = new Vector3((i - (numberOfPoints / 2)) * objectScale, ComputeFunctionCos(functionXvalue) * scaleResult, 0);
        }
    }
    float ComputeFunction(float x)
    {
        return Mathf.Sin(x);
    }

    float ComputeFunctionCos(float x)
    {
        return Mathf.Cos(x);
    }

    public void setLowFrec()
    {
        scaleInputRange = 3;
    }

    public void setMedFrec()
    {
        scaleInputRange = 8;
    }

    public void setHiFrec()
    {
        scaleInputRange = 15;
    }

    public void setLowAm()
    {
        scaleResult = 0.06f;
    }

    public void setMedAm()
    {
        scaleResult = 0.12f;
    }

    public void setHiAm()
    {
        scaleResult = 0.3f;
    }
}
