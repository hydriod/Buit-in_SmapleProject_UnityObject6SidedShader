using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudColor : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] Light sun;
    private Transform sunTra;
    [Range(0.0f, 1f)] public float lerp = 0.222f;
    [Range(0.1f, 2.0f)] public float exponent = 0.76f;
    // Start is called before the first frame update
    void Start()
    {
        sunTra = sun.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float sunRad = sunTra.rotation.eulerAngles.x * Mathf.Deg2Rad;
        float envLight = Mathf.Sin(sunRad);
        envLight = Mathf.Lerp(envLight, 1, lerp);
        envLight = Mathf.Pow(Mathf.Clamp01(envLight + 0.02f), exponent);
        material.SetColor("_Tint", new Color(envLight, envLight, envLight));
    }
}
