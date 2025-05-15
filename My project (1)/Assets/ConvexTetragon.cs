using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvexTetragon : Tetragon  // Выпуклый четырехугольник
{
    [SerializeField] protected float c = 1f;
    [SerializeField] protected float d = 1f;
    [SerializeField][Range(0, 180)] protected float angle2 = 90f;

    public override float CountPerimeter()
    {
        return a + b + c + d;
    }

    public override float CountArea()
    {
        float radAngle1 = angle * Mathf.Deg2Rad;
        float radAngle2 = angle2 * Mathf.Deg2Rad;

        float area1 = a * b * Mathf.Sin(radAngle1) / 2;
        float area2 = c * d * Mathf.Sin(radAngle2) / 2;

        return area1 + area2;
    }

    protected override void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;

        Vector3 pos = transform.position;
        Quaternion rot1 = Quaternion.Euler(0, angle, 0);
        Quaternion rot2 = Quaternion.Euler(0, angle2, 0);

        Vector3 sideA = transform.right * a;
        Vector3 sideB = rot1 * transform.right * b;
        Vector3 sideC = rot2 * transform.right * c;
        Vector3 sideD = transform.right * d;

        Gizmos.DrawLine(pos, pos + sideA);
        Gizmos.DrawLine(pos + sideA, pos + sideA + sideB);
        Gizmos.DrawLine(pos + sideA + sideB, pos + sideD + sideC);
        Gizmos.DrawLine(pos + sideD + sideC, pos + sideD);
        Gizmos.DrawLine(pos + sideD, pos);
    }
}