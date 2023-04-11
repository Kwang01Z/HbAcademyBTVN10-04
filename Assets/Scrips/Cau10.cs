using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau10 : MonoBehaviour
{
    MeshRenderer m_Myrenderer;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    m_Myrenderer = hit.transform.GetComponentInChildren<MeshRenderer>();
                    Color newColor = Random.ColorHSV();
                    m_Myrenderer.material.color = newColor;
                }
            }
        }
    }
}
