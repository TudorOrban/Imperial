
using UnityEngine;

public class SettlementModelManager : MonoBehaviour
{
    public GameObject fortressLevel1Prefab;
    public GameObject fortressLevel2Prefab;
    public GameObject fortressLevel3Prefab;

    public GameObject GetSettlementPrefab(SettlementModel model)
    {
        switch (model)
        {
            case SettlementModel.FortressLevel1:
                return fortressLevel1Prefab;
            case SettlementModel.FortressLevel2:
                return fortressLevel2Prefab;
            case SettlementModel.FortressLevel3:
                return fortressLevel3Prefab;
            default:
                Debug.LogError("Unsupported settlement model!");
                return null;
        }
    }
}