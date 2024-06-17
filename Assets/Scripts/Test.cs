using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    //public AssetReference assetReference;
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        //Addressables.LoadAssetAsync<GameObject>("Assets/Prefab/Cube.prefab").Completed += (handle) => 
        //{
        //    GameObject prefabObj = handle.Result;
        //    GameObject curObj=Instantiate(prefabObj);
        //};
        Addressables.InstantiateAsync("Assets/Prefab/Cube.prefab").Completed += (handle) =>
        {
            GameObject prefabObj = handle.Result;
        };
        //assetReference.LoadAssetAsync<GameObject>().Completed += (handle) =>
        //{
        //    GameObject prefabObj = handle.Result;
        //    GameObject curObj = Instantiate(prefabObj);
        //};
        //assetReference.InstantiateAsync().Completed += (handle) => 
        //{
        //    GameObject prefabObj = handle.Result;
        //};
        Addressables.LoadAssetAsync<Sprite>("Assets/Texture/±³°ü½çÃæ1.png").Completed+=(handle)=>
        {
            Sprite texture2D = handle.Result;
            image.sprite = texture2D;
        };
    }

    // Update is called once per frame
    void Update()
    {

    }
}
