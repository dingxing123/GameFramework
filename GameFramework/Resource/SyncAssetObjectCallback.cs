namespace GameFramework.Resource
{
    /// <summary>
    /// 同步加载AssetObject回调
    /// </summary>
    /// <param name="resource"></param>
    /// <param name="resourceAssetName"></param>
    /// <param name="resourceSubName"></param>
    /// <returns></returns>
    public delegate object SyncAssetObjectCallback(object resource, string resourceAssetName, string resourceSubName);
}
