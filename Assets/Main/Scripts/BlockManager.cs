using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public enum BlockType {
    A = 0,
    B,
    C,
    D,
    E,
}

public class BlockManager : SingletonMonoBehaviour<BlockManager> {
    [SerializeField] private BlockChainFactory blockChainFactory;

    async UniTask Start () {
        await blockChainFactory.Load();
        blockChainFactory.Create(BlockType.A);
        blockChainFactory.Create(BlockType.A);
        blockChainFactory.Create(BlockType.A);
    }

    void Update () {
    }
}