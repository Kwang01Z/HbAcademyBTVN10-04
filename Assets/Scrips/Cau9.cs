using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau9 : MonoBehaviour
{
    [SerializeField] Vector3 m_Target;
    [SerializeField] float m_MaxSpeed;
    Vector3 m_OriginPos;
    Vector3 m_CurrentTarget;
    bool m_IsReturn;
    float m_Speed;
    void Start()
    {
        m_OriginPos = transform.position;
        m_CurrentTarget = m_Target;
        m_Speed = m_MaxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveAndWait();
    }
    void MoveAndWait()
    {
        transform.position = Vector3.MoveTowards(transform.position, m_CurrentTarget, m_Speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, m_CurrentTarget) <= 0.5f)
        {
            m_IsReturn = !m_IsReturn;
            if (m_IsReturn)
            {
                m_CurrentTarget = m_OriginPos;
            }
            else
            {
                m_CurrentTarget = m_Target;
            }
            StartCoroutine(WaitATime());
        }
    }
    IEnumerator WaitATime()
    {
        m_Speed = 0;
        yield return new WaitForSeconds(Random.Range(1,3));
        m_Speed = m_MaxSpeed; 
    }
}
