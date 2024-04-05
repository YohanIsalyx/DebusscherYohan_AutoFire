using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclenchorTrigger : MonoBehaviour
{

    [SerializeField]
    Material m_onMaterial;

    [SerializeField]
    Material m_offMaterial;

    [SerializeField]
    Renderer m_renderer;

    [SerializeField]
    Door m_door;


    [SerializeField]
    Vector3 m_declenchorUpDown;



    private void OnTriggerEnter(Collider other)
    {
        transform.Translate(-m_declenchorUpDown);
        m_renderer.material = m_onMaterial;
        m_door.OpenDoor();
    }

    private void OnTriggerExit(Collider other)
    {
        transform.Translate(m_declenchorUpDown);
        m_renderer.material = m_offMaterial;
        m_door.AskToCloseDoor();
    }
}
