using TMPro;
using UnityEngine;

public class SettlementDrawer : MonoBehaviour
{
    public SettlementModelManager modelManager;
    public GameObject textPrefab;

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

            var instance = Instantiate(prefab, settlement.position + Vector3.up * 6f, Quaternion.Euler(0, settlement.orientation, 0));

            GameObject textInstance = Instantiate(textPrefab, instance.transform.position + Vector3.up * 1f, Quaternion.identity);
            textInstance.GetComponentInChildren<TextMeshProUGUI>().text = settlement.name;
            textInstance.transform.SetParent(instance.transform);
        }
    }
}