using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosquito : Enemy
{

    public override void move()
    {
        Vector2Int vector2 = random_move_vector();

        if (tile_move_check(this.current_tile_position + vector2))
        {
            StartCoroutine(Tile_move(new Vector3(vector2.x, vector2.y, 0)));
            this.change_current_tile_position(vector2);
            return;
        }
        return;

    }

    Vector2Int random_move_vector()
    {
        float f1 = Mathf.Round(Random.Range(-1.0f, 1.0f));
        float f2 = Mathf.Round(Random.Range(-1.0f, 1.0f));

        if (f1 > 0.0f)
        {
            f1 = 1.0f;
        }
        else
        {
            f1 = -1.0f;
        }

        if (f2 > 0.0f)
        {
            return new Vector2Int((int)f1, 0);
        }
        else
        {
            return new Vector2Int(0, (int)f1);
        }

    }

}
