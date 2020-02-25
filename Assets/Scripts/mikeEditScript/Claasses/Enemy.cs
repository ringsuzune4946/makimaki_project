using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// タイル上の現在位置
    /// </summary>
    [SerializeField] protected Vector2Int current_tile_position;
    private Animator anim;

    Tilemap tilemap;

    /// <summary>
    /// Enemyクラスの初期化
    /// </summary>
    public void enemy_init()
    {
        this.current_tile_position = new Vector2Int((int)(this.transform.position.x), (int)(this.transform.position.y));
        tilemap = GameObject.Find("Grid/Tilemap").GetComponent<Tilemap>();
    }

    public virtual void move()
    {

    }

    protected void change_current_tile_position(Vector2Int vector2Int)
    {
        this.current_tile_position += vector2Int;
    }

    protected bool tile_move_check(Vector2Int vector2Int)
    {

        Vector3Int vector3Int = new Vector3Int(vector2Int.x, vector2Int.y, 0);

        if (tilemap.GetTile(vector3Int) != null)
        {
            return true;
        }
        return false;
    }

    protected IEnumerator Tile_move(Vector3 move_vector)
    {
        float time = 0;
        Vector3 player_pos = this.transform.position;
        Vector3 target_pos = player_pos + move_vector;

        while (time < 1.0f)
        {
            time += 0.1f;
            // オブジェクトの移動
            transform.position = Vector3.Lerp(player_pos, target_pos, time * 4);
            yield return null; //1フレーム待つ

        }

    }

}
