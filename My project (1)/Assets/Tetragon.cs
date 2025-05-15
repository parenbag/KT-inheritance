using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetragon : MonoBehaviour
{
    [SerializeField] protected float a = 1f;
    [SerializeField] protected float b = 1f;
    [SerializeField][Range(0, 180)] protected float angle = 90f;

    public virtual float CountPerimeter()
    {
        return 2 * (a + b);
    }

    public virtual float CountArea()
    {
        float radAngle = angle * Mathf.Deg2Rad;
        return a * b * Mathf.Sin(radAngle);
    }

    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        Vector3 pos = transform.position;
        Quaternion rot = Quaternion.Euler(0, angle, 0);

        Vector3 sideA = transform.right * a;
        Vector3 sideB = rot * transform.right * b;

        Gizmos.DrawLine(pos, pos + sideA);
        Gizmos.DrawLine(pos + sideA, pos + sideA + sideB);
        Gizmos.DrawLine(pos + sideA + sideB, pos + sideB);
        Gizmos.DrawLine(pos + sideB, pos);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 300, 20), $"{GetType().Name}: P={CountPerimeter():F2}, S={CountArea():F2}");
    }
}
