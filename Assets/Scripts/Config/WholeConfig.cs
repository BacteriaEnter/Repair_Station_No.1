using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class WholeConfig
{
    public Dictionary<string, string> configDic = new Dictionary<string, string>();
    
    
    public void LoadData()
    {
        var data=ExcelHelper.ReadExcel(ConstParameter.WHOLECONFIG);
        DataRowCollection collection;
        int rowNum = 0;
        for (int drcIndex = 0; drcIndex < data.drc.Count; drcIndex++)
        {
            collection = data.drc[drcIndex];
            rowNum = data.rowNum[drcIndex];
            for (int i = 1; i < rowNum; i++)
            {
                string itemID = collection[i][0].ToString();
                string path = collection[i][1].ToString();
                // var prefab = await ResourceManager.LoadAssetAsync<BuffSO>(path);

                configDic.TryAdd(itemID, path);
            }

        }
    }

    public T GetData<T>(string objectID)where T:UnityEngine.Object
    {
        if ( configDic.TryGetValue(objectID,out string path))
        {
           
            var prefab= ResourceManager.LoadAsset<T>(path);
            return prefab;
        }
        return default;
    }
}