using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal_Tile : Gimmick
{
    public override void RunTrigger_set()
    {
        if (player.get_current_tile_position() == this.current_tile_position)
        {
            this.RunTrigger = true;
        }
    }

    protected override void gimmick_effect()
    {
        player.apply_damage(-1);
        this.RunTrigger = false;
    }
}
