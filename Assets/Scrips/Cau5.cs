using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau5 : MonoBehaviour
{
    [SerializeField] Vector3 m_Target;
    [SerializeField] float m_Speed;
    Vector3 m_OriginPos;
    Vector3 m_CurrentTarget;
    bool isReturn;
    
    void Start()
    {
        m_OriginPos = transform.position;
        m_CurrentTarget = m_Target;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, m_CurrentTarget, m_Speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, m_CurrentTarget) <= 0.5f)
        {
            isReturn = !isReturn;
            if (isReturn)
            {
                m_CurrentTarget = m_OriginPos;
            }
            else
            {
                m_CurrentTarget = m_Target;
            }
        }
    }
}
