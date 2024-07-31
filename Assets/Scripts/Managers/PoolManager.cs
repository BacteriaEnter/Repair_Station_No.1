using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolManager:MonoBehaviour
{
    private static List<Pool> pools = new List<Pool>();
    
    [SerializeField] private List<Pool> basicPool = new List<Pool>();
    private static  GameObject poolParent;

    private void OnEnable()
    {
        Init();
    }

    private void OnDisable()
    {
        pools.Clear();
        poolParent = null;
    }


    public static GameObject Release(string objectID, Vector3 position, Quaternion identity)
    {
        Pool pool = pools.Find(p => p.poolName == objectID);
        if (pool==null)
        {
            var go=ResourceManager.Inst.wholeConfig.GetData<GameObject>(objectID);
            int poolSize = 10;

      
            
            pool = new Pool(poolName: objectID, poolSize,  go,poolParent.transform);
            pools.Add(pool);
        }

        GameObject spawnedObj = pool.poolObjects.Peek();
        if (spawnedObj == null||spawnedObj.activeSelf)
        {
            spawnedObj = Instantiate(pool.pref);
            spawnedObj.transform.SetParent(pool.objectsParent.transform);
            // pool.poolObjects.Enqueue(spawnedObj);
        }
        else
        {
            pool.poolObjects.Dequeue();
        }
        spawnedObj.transform.position = position;
        spawnedObj.transform.rotation = identity;
        spawnedObj.SetActive(true);
        pool.poolObjects.Enqueue(spawnedObj); 
        return spawnedObj;
    }

    public static void Recycle(string objectID,GameObject go)
    {
        Pool pool = pools.Find(p => p.poolName == objectID);
        go.transform.SetParent(pool.objectsParent.transform);
        go.SetActive(false);
    }

    private void Init()
    {
        poolParent = new GameObject("Pools");
        foreach (var pool in basicPool)
        {
            pool.Init(poolParent.transform);
            pools.Add(pool);
        }
    }
    
}