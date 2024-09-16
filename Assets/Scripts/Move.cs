using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public struct VectorXYZ
    {
        public float x;
        public float y;
        public float z;

        public VectorXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // ����� ��� ���������� ����� �������
        public float Length()
        {
            return Mathf.Sqrt(x * x + y * y + z * z);
        }

        // ����� ��� ��������� ������� ��������� �����
        public VectorXYZ ToUnitVector()
        {
            float length = Length();
            return new VectorXYZ(x / length, y / length, z / length);
        }

        // ����� ��� ���������� ������������
        public float Dot(VectorXYZ other)
        {
            return x * other.x + y * other.y + z * other.z;
        }

        // ����� ��� ���������� ������������
        public VectorXYZ Cross(VectorXYZ other)
        {
            return new VectorXYZ(
                y * other.z - z * other.y,
                z * other.x - x * other.z,
                x * other.y - y * other.x
            );
        }
    }
}
