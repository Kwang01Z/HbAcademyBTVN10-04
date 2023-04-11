using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau4 : MonoBehaviour
{
    [SerializeField] Vector3 m_Target;
    [SerializeField] float m_Speed;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, m_Target, m_Speed * Time.deltaTime);
    }
}
