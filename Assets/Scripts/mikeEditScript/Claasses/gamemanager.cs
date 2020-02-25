using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 拍判定→プレイヤー移動→敵移動→ギミック処理→D.C.
/// </summary>
public class gamemanager : MonoBehaviour
{
    [SerializeField] private GimmickManager gimmickmanager;
    [SerializeField] private MoveManager move_manager;
    [SerializeField] private Player player;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player-idle-1").GetComponent<Player>();
        move_manager = new MoveManager();
        move_manager.movemanager_init();
        gimmickmanager = new GimmickManager();
        gimmickmanager.gimmickmanager_init();
    }

    // Update is called once per frame
    void Update()
    {
        player.set_UI(text);

        move_manager.move_phase();
        if(move_manager.getgo_transitiion())
        {
            gimmickmanager.gimmickphase();
        }

    }

}
