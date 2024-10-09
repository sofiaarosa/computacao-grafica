using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{

    public int pace = 2;
    private int mclicks = 0;
    private bool rotateFlag = false;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        pace = 2;
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(rotateFlag)
            transform.Rotate(0,pace,0);
    }

    private void OnMouseDown() {
        mclicks++;
        Debug.Log("Esse objeto foi escolhido " + mclicks + " vezes");  

        rotateFlag = !rotateFlag;  
    }

    private void OnMouseDrag() {
        
    }
}
