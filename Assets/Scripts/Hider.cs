using UnityEngine;
using UnityEngine.InputSystem;

public class Hider : MonoBehaviour
{
    public Vector3 hidePos;
    public float hideDist;
    public Camera gamCam;

    public float waitDura;
    private float timePassed = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 currMouse = Mouse.current.position.ReadValue();
        //Vector3 worldMousePos = gamCam.ScreenToWorldPoint(currMouse);
        //worldMousePos.z = 0;
        ////need to bring mouse postion into world space 
        //float mouseDist = Vector3.Distance(worldMousePos, transform.position);

        //if (mouseDist < hideDist) 
        //{ 
        //    transform.position = hidePos; 
        //}

        timePassed += Time.deltaTime;

        if(timePassed > waitDura)
        {
            transform.position = hidePos;
        }
        
    }

    }

