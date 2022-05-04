using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BlockFactory : FactoryBase {
    private string path = "Prefabs/BlockEntity";
    public async UniTask Load () {
        await base.Load (path);
    }

    public BlockEntity Create (BlockEntity.BlockEntityArgs args) {
        var obj = base.Create ();
        var blockEntity = obj.GetComponent<BlockEntity> ();
        blockEntity.Initialize (args);
        return blockEntity;
    }
}