using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau2 : MonoBehaviour
{
    [SerializeField] Vector3 m_Point1;
    [SerializeField] Vector3 m_Point2;
    [SerializeField] float m_Speed;
    void Start()
    {
        transform.position = m_Point1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, m_Point2,m_Speed*Time.deltaTime);
        if (Vector3.Distance(transform.position, m_Point2) <= 0.5f)
        {
            transform.position = m_Point1;
        }
    }
}
