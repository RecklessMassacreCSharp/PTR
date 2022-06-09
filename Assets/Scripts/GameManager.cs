using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject vehToSpawn;

    public GameObject obj;

    [SerializeField] List<GameObject> vehPrefabs = new List<GameObject>();
    
    void Awake()
    {
        vehToSpawn = vehPrefabs[DataManager.Instance.vehicleType];
        Vector3 pos = new Vector3(0, 0, 0);
        obj = Instantiate(vehToSpawn, pos, vehToSpawn.transform.rotation);
    }
}
