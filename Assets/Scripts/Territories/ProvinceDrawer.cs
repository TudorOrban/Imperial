using UnityEngine;

public class ProvinceDrawer : MonoBehaviour
{
    public Terrain terrain;
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

        if (terrain == null)
        {
            Debug.LogError("Terrain has not been assigned in ProvinceDrawer.");
            return;
        }

        GameObject lineParent = new GameObject("LineParent");
        lineParent.transform.parent = province.transform;

        for (int i = 0; i < province.boundaryRegions.Count; i++)
        {
            GameObject lineGO = new GameObject("RegionLine " + i);
            lineGO.transform.parent = lineParent.transform;
            LineRenderer lineRenderer = lineGO.AddComponent<LineRenderer>();
            if (lineRenderer == null)
            {
                Debug.LogError("Failed to create LineRenderer on the province GameObject.");
                continue;
            }

            lineRenderer.material = lineMaterial;
            lineRenderer.startWidth = 0.1f;
            lineRenderer.endWidth = 0.1f;
            lineRenderer.positionCount = province.boundaryRegions[i].Count;

            Vector3[] positions = new Vector3[province.boundaryRegions[i].Count];
            for (int j = 0; j < province.boundaryRegions[i].Count; j++)
            {
                positions[j] = GetTerrainPosition(province.boundaryRegions[i][j]);
            }
            lineRenderer.SetPositions(positions);
        }
    }


    private Vector3 GetTerrainPosition(Vector2 point)
    {
        float terrainHeight = terrain.SampleHeight(new Vector3(point.x, 0, point.y)) + 0.5f;
        return new Vector3(point.x, terrainHeight, point.y);
    }
}