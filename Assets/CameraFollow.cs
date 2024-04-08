using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Vector3 m_offset;

    [SerializeField]
    Transform m_target;

    [SerializeField]
    float m_smoothTime;

    private void Start()
    {
        m_offset =  transform.position - m_target.position;
    }

    private void LateUpdate()
    {
        Vector3 newPosition = m_target.position + m_offset;
        newPosition = Vector3.Lerp(transform.position, newPosition, m_smoothTime * Time.deltaTime);
        transform.position = newPosition;
    }

}
