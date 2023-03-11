using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersistSpawner : MonoBehaviour
{
    [SerializeField] GameObject PersistantOBJ;

    static bool isSpawned = false;

    private void Awake()
    {
        if (isSpawned)
        {
            return;
        }
        SpawnObj();
        isSpawned = true;

    }

    private void SpawnObj()
    {
        GameObject persist = Instantiate(PersistantOBJ);
        DontDestroyOnLoad(persist);
    }
}
