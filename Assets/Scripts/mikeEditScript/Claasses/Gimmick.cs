using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gimmick : MonoBehaviour
{

    [SerializeField] protected bool RunTrigger;
    [SerializeField] protected Player player;

    /// <summary>
    /// タイル上の現在位置
    /// </summary>
    [SerializeField] protected Vector2Int current_tile_position;

    /// <summary>
    /// Gimmickクラスの初期化
    /// </summary>
    public void gimmick_init()
    {
        player = GameObject.Find("player-idle-1").GetComponent<Player>();
        this.current_tile_position = new Vector2Int((int)(this.transform.position.x), (int)(this.transform.position.y));
        RunTrigger = false;
    }

    private bool Run_Check()
    {
        return this.RunTrigger;
    }

    public void gimmick_process()
    {
        if (this.Run_Check())
        {
            this.gimmick_effect();
        }
    }

    protected virtual void gimmick_effect()
    {
        player.apply_damage(1);
        this.RunTrigger = false;
    }

    public virtual void RunTrigger_set()
    {
        if(player.get_current_tile_position() == this.current_tile_position)
        {
            this.RunTrigger = true;
        }
    }
}
