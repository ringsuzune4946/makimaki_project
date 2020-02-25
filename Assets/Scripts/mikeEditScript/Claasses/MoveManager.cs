using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MoveManager
{

    [SerializeField] private Player player;
    [SerializeField] private Enemy[] enemys;
    [SerializeField] private EnemyManager enemymanager;

    [SerializeField] private Tilemap tile_map;
    [SerializeField] private bool go_transition;

    public void movemanager_init()
    {

        enemymanager = new EnemyManager();
        enemymanager.enemymanager_init();

        player = GameObject.Find("player-idle-1").GetComponent<Player>();
        player.player_init();

        tile_map = GameObject.Find("Grid/Tilemap").GetComponent<Tilemap>();
        go_transition = false;
    }

    public void move_phase()
    {
        this.setgo_transition(false);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            move_process(Vector2Int.right);
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            move_process(Vector2Int.left);
            return;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            move_process(Vector2Int.up);
            return;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            move_process(Vector2Int.down);
            return;
        }
    }

    private void move_process(Vector2Int vector2Int)
    {
        if (player.tile_move_check(vector2Int, tile_map))
        {
            player.move(vector2Int);

            enemymanager.enemys_move();

            this.setgo_transition(true);
        }
        return;
    }

    private void setgo_transition(bool b)
    {
        this.go_transition = b;
    }

    public bool getgo_transitiion()
    {
        return this.go_transition;
    }
}
