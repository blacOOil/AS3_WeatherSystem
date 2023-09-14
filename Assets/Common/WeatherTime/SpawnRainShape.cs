using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRainShape : MonoBehaviour
{
    public int numIterations = 4;
    public Color color = Color.blue;
    public float xLeft = -1f;
    public float xRight = 1f;
    public float yUp = -1f;
    public float yDown = -5f;

    private LineRenderer lineRenderer;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<LineRenderer>().enabled = true;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(Random.Range(xLeft, xRight), yUp);

       
        lineRenderer = GetComponent<LineRenderer>();
        Color color = new Color(92f, 226f, 255f, Random.Range(0.25f, 0.75f));

        Vector3[] points = GennerateRainShape(numIterations, 0);
        float thickness = 4;
        lineRenderer.useWorldSpace = false;
        lineRenderer.loop = true;

        lineRenderer.positionCount = points.Length;
        lineRenderer.SetPositions(points);
        lineRenderer.startWidth = thickness;
        lineRenderer.endWidth = thickness;
        lineRenderer.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yDown)
        {
            Destroy(gameObject);
        }
    }
    private Vector3[] GennerateRainShape(int iterations, float Length)
    {
        Vector3[] points = new Vector3[6];

        points[0] = new Vector3(0f, 0f, 0f);
        points[1] = new Vector3(Length / 2, 0f, 0f);
        points[2] = new Vector3(-Length / 2, 0f, 0f);
        for(int i = 0; i < iterations; i++)
        {
            int numPoint = points.Length;
            Vector3[] newPoints = new Vector3[numPoint * 4 - 3];
            int index = 0;
        }
        return points;
    }
}
