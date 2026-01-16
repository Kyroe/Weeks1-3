using UnityEditor;
using UnityEngine;

public class Pulser : MonoBehaviour
{
    public AnimationCurve curve;

    private float progress = 0f;
    public float duration;
    public float output;

    Vector3 posY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime / duration;
        output = curve.Evaluate(progress);

        posY = transform.position;
        posY.y = output;
        transform.position = posY;
        // set variable to transform
        // make changes to varible
        //set new changes to the transform

        if (progress > 1f)
        {
            progress = 0f;
        }

    }
}

