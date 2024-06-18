using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ProvinceDrawer : MonoBehaviour
{
    public Material lineMaterial;

    public void DrawBoundary(Province province)
    {
        if (province == null)
        {
            Debug.LogError("Province is null.");
            return;
        }

        if (lineMaterial == null)
        {
            Debug.LogError("Line material has not been assigned in ProvinceDrawer.");
            return;
        }

        GameObject line = new GameObject("LineParent");
        line.transform.parent = province.transform;

        
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            Debug.LogError("Failed to create LineRenderer on the province GameObject.");
            return;
        }

        lineRenderer.material = lineMaterial;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;

        List<Vector3> positions = new List<Vector3>();
        for (int i = 0; i < province.boundaryPoints.Count - 1; i++)
        {
            // Check elevation condition for both points in the segment
            if (province.boundaryPoints[i].y > 19 && province.boundaryPoints[i + 1].y > 19)
            {
                if (positions.Count == 0 || positions.Last() != province.boundaryPoints[i])
                {
                    positions.Add(province.boundaryPoints[i]);  // Add first point if starting new or disconnected
                }
                positions.Add(province.boundaryPoints[i + 1]); // Always add second point
            }
            else if (positions.Count > 0)
            {
                // If breaking a line due to elevation, render what was collected and start anew
                lineRenderer.positionCount = positions.Count;
                lineRenderer.SetPositions(positions.ToArray());
                positions.Clear();

                // Optionally, create a new GameObject and LineRenderer for subsequent segments
                line = new GameObject($"LineParent_Segment_{i}");
                line.transform.parent = province.transform;
                lineRenderer = line.AddComponent<LineRenderer>();
                lineRenderer.material = lineMaterial;
                lineRenderer.startWidth = 0.1f;
                lineRenderer.endWidth = 0.1f;
                lineRenderer.useWorldSpace = true;
            }
        }

        // After loop, if there are any remaining positions to render
        if (positions.Count > 0)
        {
            lineRenderer.positionCount = positions.Count;
            lineRenderer.SetPositions(positions.ToArray());
        }
    }
}