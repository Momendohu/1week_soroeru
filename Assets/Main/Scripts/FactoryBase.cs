using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class FactoryBase : MonoBehaviour {
    private GameObject prefab = null;

    public async UniTask Load (string path) {
        prefab = await Resources.LoadAsync (path) as GameObject;
    }

    public GameObject Create () {
        if (!prefab) {
            Debug.LogAssertion ($"プレハブがロードされていません{this}");
            return null;
        }

        return Instantiate (prefab, this.transform);
    }
}