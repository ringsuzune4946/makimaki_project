using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager
{
    [SerializeField] private Enemy[] enemys;


    public void enemymanager_init()
    {
        enemys = Object.FindObjectsOfType<Enemy>();
        foreach (Enemy e in enemys)
        {
            e.enemy_init();
        }
    }

    public void enemys_move()
    {
        foreach (Enemy e in enemys)
        {
            e.move();
        }
    }
}
