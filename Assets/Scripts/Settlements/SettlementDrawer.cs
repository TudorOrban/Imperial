using UnityEngine;

public class SettlementDrawer : MonoBehaviour
{
    public SettlementModelManager modelManager;

    public void DrawSettlements(SettlementGameData data)
    {
        foreach (var settlement in data.settlements)
        {
            var prefab = modelManager.GetSettlementPrefab(modelManager.GetModelEnumFromString(settlement.model));
            if (prefab == null)
            {
                Debug.LogError("Could not find model prefab!");
                continue;
            }

            var instance = GameObject.Instantiate(prefab);
            settlement.position.y += 7f;
            instance.transform.position = settlement.position;
        }
    }
}