using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Parallelogram  // Прямоугольник
{
    private void OnValidate()
    {
        angle = 90;
        angle2 = 90;
    }

    public override float CountArea()
    {
        return a * b;
    }
}