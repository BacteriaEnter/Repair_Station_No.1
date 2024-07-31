using UnityEngine;

public class ResourceManager
{
    private static readonly ResourceManager resourceManager = new ResourceManager();
    public static ResourceManager Inst => resourceManager;

    public WholeConfig wholeConfig;
    
    private ResourceManager()
    {
    }

    public static T LoadAsset<T>(string path) where T : UnityEngine.Object
    {
        return Resources.Load<T>(path);
    }
}