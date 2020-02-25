using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;



public class GimmickManager
{
    [SerializeField] private Gimmick[] gimmicks;

    public void gimmickmanager_init()
    {
        gimmicks = Object.FindObjectsOfType<Gimmick>();
        foreach (Gimmick g in gimmicks)
        {
            g.gimmick_init();
        }
    }

    public void gimmickphase()
    {
        foreach (Gimmick g in gimmicks)
        {
            g.RunTrigger_set();
        }
        foreach (Gimmick g in gimmicks)
        {
            g.gimmick_process();
        }
    }

}
