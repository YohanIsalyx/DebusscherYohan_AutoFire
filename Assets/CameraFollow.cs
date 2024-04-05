using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 m_offSet;

    [SerializeField]
    Transform m_target;

    private void Start()
    {
        //m_offSet = m_target.position - transform.position;
    }

    private void LateUpdate()
    {
        //transform.LookAt(m_target);
        //transform.Translate((m_target.position - transform.position) - m_offSet);
    }

}
