using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhombus : Parallelogram  // Ромб
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
        float radAngle = angle * Mathf.Deg2Rad;
        return a * a * Mathf.Sin(radAngle);
    }
}
