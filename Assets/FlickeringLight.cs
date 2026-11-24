using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public float minIntensity = 0.25f;
    public float maxIntensity = 10f;

    float random;

    void Start()
    {
        random = Random.Range(0.0f, 65535.0f);
    }

    void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.time * 0.5f);
        GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}