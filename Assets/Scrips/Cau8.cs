using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau8 : MonoBehaviour
{
    [SerializeField] Vector3 m_Target;
    [SerializeField] float m_Timer;
    private float m_StartTime;
    private Vector3 m_StartPosition;
    void Start()
    {
        m_StartPosition = transform.position;
        m_StartTime = Time.time;
    }

    private void FixedUpdate()
    {
        float timeElapsed = (Time.time - m_StartTime) / m_Timer;
        transform.position = Vector3.Lerp(m_StartPosition, m_Target, timeElapsed);
    }
}
