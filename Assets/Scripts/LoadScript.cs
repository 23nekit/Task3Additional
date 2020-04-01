using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LoadScript : MonoBehaviour
{
    public string Url;
    public string FileName;

    private Object CreatedObject;
    private AssetBundle MyLoadedAssetBundle;
    
    public void LoadAssetBundleCreateObjectAndGiveLinkToDestroy()
    {
        try
        {
            LoadAssetBundle();
            CreateObjectLoadedFromAssetBundle();
        }
        catch (System.Exception e)
        {
            ShowExeptionMessage(e);
        }
    }
    private void LoadAssetBundle()
    {
        MyLoadedAssetBundle = AssetBundle.LoadFromFile(Url);
        CreatedObject = MyLoadedAssetBundle.LoadAsset(FileName);
    }
    private void CreateObjectLoadedFromAssetBundle()
    {
        Instantiate(CreatedObject);
    }
    private void ShowExeptionMessage(System.Exception e)
    {
        Debug.Log(e.Message);
    }
}
