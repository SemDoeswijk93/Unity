using UnityEngine;

public class goumba : MonoBehaviour
{
    public float amplitude = 1.0f;    // Hoe hoog/laag (afstand tussen heen en weer)
    public float frequency = 0.5f;    // Hoe snel

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Sine wave (Sinus golf) beweging voor op-en-neer effect
        float newY = startPosition.x + amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(newY, startPosition.y, startPosition.z);
    }
}
