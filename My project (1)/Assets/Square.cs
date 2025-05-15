using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Rectangle  //  вадрат
{
    private void OnValidate()
    {
        a = b;
        b = a;
        c = a;
        d = a;
    }

    public override float CountPerimeter()
    {
        return 4 * a;
    }

    public override float CountArea()
    {
        return a * a;
    }
}
