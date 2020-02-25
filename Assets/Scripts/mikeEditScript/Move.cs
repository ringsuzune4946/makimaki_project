using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //スタートと終わりの目印
    public Vector3 player_pos;
    public Vector3 target_pos;

    public GameObject up_collision;
    public GameObject down_collision;
    public GameObject left_collision;
    public GameObject right_collision;

    private bool ismove;

    private Animator anim;


    void Start()
    {
        ismove = false;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && !ismove && !right_collision.GetComponent<Player_collision>().Trigger_check())
        {
            StartCoroutine(Tile_move(Vector3.right));
            //player_move(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && !ismove && !left_collision.GetComponent<Player_collision>().Trigger_check())
        {
            StartCoroutine(Tile_move(Vector3.left));
            //player_move(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && !ismove && !up_collision.GetComponent<Player_collision>().Trigger_check())
        {
            StartCoroutine(Tile_move(Vector3.up));
            //player_move(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && !ismove && !down_collision.GetComponent<Player_collision>().Trigger_check())
        {
            StartCoroutine(Tile_move(Vector3.down));
            //player_move(Vector3.down);
        }
    }

    IEnumerator Tile_move(Vector3 move_vector)
    {
        ismove = true;
        //anim.Play("player_run");

        float time = 0;
        player_pos = this.transform.position;
        target_pos = player_pos + move_vector;

        while (time < 1.0f)
        {
            time += 0.1f;

            // オブジェクトの移動
            transform.position = Vector3.Lerp(player_pos, target_pos, time * 4);
            yield return null; //1フレーム待つ

        }

        ismove = false;
    }

    void player_move(Vector3 target)
    {
        target = this.transform.position + target;
        transform.position = Vector3.Lerp(this.transform.position, target, 0.05f);
    }

}
