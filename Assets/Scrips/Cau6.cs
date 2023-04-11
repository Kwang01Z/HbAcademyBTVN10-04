using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau6 : MonoBehaviour
{
    [SerializeField] float m_Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }
    void MoveCharacter()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.position += Vector3.right * m_Speed * Time.deltaTime * horizontal;
        transform.position += Vector3.up * m_Speed * Time.deltaTime * vertical;
    }
}
