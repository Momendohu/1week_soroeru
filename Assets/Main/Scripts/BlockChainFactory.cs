using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class BlockChainFactory : MonoBehaviour {
    [SerializeField] private BlockFactory blockFactory;

    private bool[, ] _blockChainTable = { { true, false, false },
        { false, false, true },
        { false, true, false },
    };

    public async UniTask Load () {
        await blockFactory.Load ();
    }

    public void Create (BlockType correct) {
        var table = Random.Range (0, 2); //真ん中が正解のパターンを最初から弾く
        for (int i = 0; i < 3; i++) {
            blockFactory.Create (
                new BlockEntity.BlockEntityArgs {
                    blockType = _blockChainTable[table, i] ? correct : RandomBlockType (correct),
                        row = i - 1,
                }
            );
        }
    }

    private BlockType RandomBlockType (BlockType correct) {
        int rand = -1;
        while (true) {
            rand = Random.Range (0, System.Enum.GetValues (typeof (BlockType)).Length);
            if (!(rand == (int) correct)) {
                break;
            }
        }

        return (BlockType) rand;
    }
}