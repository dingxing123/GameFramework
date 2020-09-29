namespace GameFramework.Resource
{
    /// <summary>
    /// 同步加载AssetBundle回调
    /// </summary>
    /// <param name="fullPath"></param>
    /// <param name="bytes"></param>
    /// <returns></returns>
    public delegate object SyncAssetBundleCallback(string fullPath, byte[] bytes);
}
