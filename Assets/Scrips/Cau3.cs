using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau3 : MonoBehaviour
{
    [SerializeField] List<Vector3> m_Points;
    [SerializeField] float m_Speed;
    int idPoint = 0;
    void Start()
    {
        idPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move() 
    {
        if (m_Points.Count <= 2) return;
        MoveToTarget(m_Points[idPoint + 1]);
        if (Vector3.Distance(transform.position, m_Points[idPoint + 1]) <= 0.5f)
        {
            if (idPoint + 1 >= m_Points.Count - 1)
            {
                idPoint = -1;
            }
            else
            {
                idPoint++;
            }
        }
        
    }
    void MoveToTarget(Vector3 a_Target)
    {
        transform.position = Vector3.Lerp(transform.position, a_Target, m_Speed * Time.deltaTime);
    }
}
