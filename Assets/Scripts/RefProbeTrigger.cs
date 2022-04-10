using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefProbeTrigger : MonoBehaviour
{
    [SerializeField] ReflectionProbe rp;
    public int renderFrame = 60;
    private int frame = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (frame % renderFrame == 0)
        {
            rp.RenderProbe();
            frame -= renderFrame;
            Debug.Log("RP Render");
        }
        frame++;
    }
}
