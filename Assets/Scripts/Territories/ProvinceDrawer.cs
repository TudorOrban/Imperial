using UnityEngine;

public class ProvinceDrawer : MonoBehaviour
{
    public Terrain terrain;
    public Material lineMaterial;

    public void DrawBoundary(Province province)
    {
        if (!province) return;

        LineRenderer lineRenderer = province.gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = lineMaterial;
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.positionCount = province.boundaryPoints.Count;
        lineRenderer.loop = true; 

        Vector3[] positions = new Vector3[province.boundaryPoints.Count];
        for (int i = 0; i < province.boundaryPoints.Count; i++)
        {
            positions[i] = GetTerrainPosition(province.boundaryPoints[i]);
        }
        lineRenderer.SetPositions(positions);
    }

    private Vector3 GetTerrainPosition(Vector2 point)
    {
        float terrainHeight = terrain.SampleHeight(point) + 0.5f;
        return new Vector3(point.x, terrainHeight, point.y);
    }
}