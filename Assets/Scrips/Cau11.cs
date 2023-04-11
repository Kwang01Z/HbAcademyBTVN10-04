using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau11 : MonoBehaviour
{
    [SerializeField] float m_Speed;
    public Vector3 m_Target;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                m_Target = hit.point;
                
            }
        }
        MoveToTarget(m_Target);
        if (Vector3.Distance(transform.position, m_Target) <= 0.5f)
        {
            Debug.Log("Complete");
        }

    }
    void MoveToTarget(Vector3 a_Target)
    {
        transform.position = Vector3.Lerp(transform.position, a_Target, m_Speed * Time.deltaTime);
    }
}
