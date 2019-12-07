using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : Character {

    public override void special(float direction)
    {
        Debug.Log(direction);
        if (direction != 0)
        {

        }
        else
        {
            Instantiate(specialNeutral, transform);
        }
    }

}
