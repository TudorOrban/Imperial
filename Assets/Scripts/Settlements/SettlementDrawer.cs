using UnityEngine;

public class SettlementDrawer : MonoBehaviour
{
    public SettlementModelManager modelManager;

    public void DrawSettlements(SettlementGameData data)
    {
        foreach (var settlement in data.settlements)
        {
            var prefab = modelManager.GetSettlementPrefab(settlement.model);
            if (prefab == null)
            {
                Debug.LogError("Unsupported settlement model!");
                continue;
            }

            var instance = GameObject.Instantiate(prefab);
            instance.transform.position = settlement.position;
        }
    }
}