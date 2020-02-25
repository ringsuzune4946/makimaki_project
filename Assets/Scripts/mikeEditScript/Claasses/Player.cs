using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


[RequireComponent(typeof(Animator))]

public class Player : MonoBehaviour
{
    /// <summary>
    /// 自身の体力
    /// </summary>
    [SerializeField] private int HP = 5;

    /// <summary>
    /// 移動中かのフラグ
    /// </summary>
    [SerializeField] private bool ismove;

    /// <summary>
    /// タイル上の現在位置
    /// </summary>
    [SerializeField] private Vector2Int current_tile_position;

    /// <summary>
    /// 自身のアニメーターコンポーネント
    /// </summary>
    private Animator anim;

    /// <summary>
    /// Playerクラスの初期化
    /// </summary>
    public void player_init()
    {
        this.HP = 5;
        this.ismove = false;
        //this.anim = this.gameObject.GetComponent<Animator>();
        this.current_tile_position = new Vector2Int(0, 1);
    }

    /// <summary>
    /// プレイヤーの移動処理
    /// </summary>
    public void move(Vector2Int vector2Int)
    {
        StartCoroutine(Tile_move(new Vector3(vector2Int.x, vector2Int.y, 0)));
        this.change_current_tile_position(vector2Int);
    }

    IEnumerator Tile_move(Vector3 move_vector)
    {
        ismove = true;
        //anim.Play("player_run");
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

        ismove = false;
    }

    public void damage_check()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.apply_damage(1);
        }
    }

    public void apply_damage(int damage)
    {
        this.HP -= damage;
    }

    private void change_current_tile_position(Vector2Int vector2Int)
    {
        this.current_tile_position += vector2Int;
    }

    public bool tile_move_check(Vector2Int vector2Int, Tilemap tilemap)
    {
        //移動先のTileの位置情報を生成
        vector2Int += this.current_tile_position;
        Vector3Int vector3Int = new Vector3Int(vector2Int.x, vector2Int.y, 0) ;

        if (tilemap.GetTile(vector3Int) != null && !ismove)
        {
            return true;
        }
        return false;
    }

    public Vector2Int get_current_tile_position()
    {
        return this.current_tile_position;
    }

    public bool get_ismove()
    {
        return this.ismove;
    }

    public void set_UI(Text text)
    {
        text.text = "HP：" + this.HP;
    }

}
