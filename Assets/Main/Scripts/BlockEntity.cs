using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEntity : EntityBase {
    public struct BlockEntityArgs {
        public BlockType blockType;
        public int row;
    }

    public BlockType blockType = BlockType.A;
    public int row;

    public void Initialize (BlockEntityArgs args) {
        blockType = args.blockType;
        row = args.row;
    }
}