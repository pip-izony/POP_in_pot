using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class drawLine : MonoBehaviour
{
    public LineRenderer lr;
    apple stop;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
        stop = GetComponent<apple>();
    }

    public void RenderLine(Vector3 startPoint, Vector3 endPoint)
    {
        if (stop.stop)
        {
            lr.positionCount = 2;
            Vector3[] points = new Vector3[2];
            points[0] = startPoint;
            points[1] = endPoint;

            lr.SetPositions(points);
        }
    }

    public void endLine()
    {
        lr.positionCount = 0;
    }
}
