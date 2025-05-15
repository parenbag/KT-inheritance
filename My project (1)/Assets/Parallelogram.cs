using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallelogram : ConvexTetragon     // ֿאנאככוכמדנאלל
{
    private void OnValidate()
    {
        c = a;
        d = b;
        angle2 = 180 - angle;
    }

    public override float CountPerimeter()
    {
        return 2 * (a + b);
    }

    public override float CountArea()
    {
        float radAngle = angle * Mathf.Deg2Rad;
        return a * b * Mathf.Sin(radAngle);
    }

    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Vector3 pos = transform.position;
        Quaternion rot = Quaternion.Euler(0, angle, 0);

        Vector3 sideA = transform.right * a;
        Vector3 sideB = rot * transform.right * b;

        Gizmos.DrawLine(pos, pos + sideA);
        Gizmos.DrawLine(pos + sideA, pos + sideA + sideB);
        Gizmos.DrawLine(pos + sideA + sideB, pos + sideB);
        Gizmos.DrawLine(pos + sideB, pos);
    }
}
