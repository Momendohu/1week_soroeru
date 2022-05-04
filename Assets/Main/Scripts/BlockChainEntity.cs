using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BlockChainEntity : EntityBase {
    private List<BlockEntity> blockChain = new List<BlockEntity> ();

    public void Register (BlockEntity entity) {
        blockChain.Add (entity);
    }

    public BlockEntity GetBlock (int index) {
        return blockChain.Where (x => x.row == index) as BlockEntity;
    }
}