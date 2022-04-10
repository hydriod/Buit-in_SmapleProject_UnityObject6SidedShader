using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnvControl : MonoBehaviour
{
    [SerializeField] float lightness = 1.414f;
    private void Start()
    {
        if (RenderSettings.sun.gameObject != this.gameObject)
        {
            this.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        float sunRad = Mathf.Deg2Rad * transform.rotation.eulerAngles.x;
        RenderSettings.ambientIntensity = Mathf.Clamp01(Mathf.Sin(sunRad)) * lightness;
    }
}
