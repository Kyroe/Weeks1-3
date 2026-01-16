using UnityEngine;

public class Missle : MonoBehaviour
{
    public Transform startValue;
    public Transform endValue;
    public float progress = 0; // a percentage value of how far between start and and 
    public Vector3 output; // where it is

    public float duration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       progress += Time.deltaTime / duration;
       output = Vector3.Lerp(startValue.position, endValue.position, progress);

        transform.position = output;
        
    }
}
