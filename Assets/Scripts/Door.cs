using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool m_isOpen;
    bool m_isClosing;
    bool m_askToOpenAgain;

    [SerializeField]
    float m_timeToClose;

    [SerializeField]
    Vector3 m_doorMovement;

    float m_currentTime;


    private void Update()
    {
        if(m_currentTime <= m_timeToClose)
        {
            m_currentTime += Time.deltaTime;
        }
        else
        {
            if(m_isClosing && m_askToOpenAgain)
            {
                m_currentTime = 0f;
                m_askToOpenAgain = false;
            }
            else if(m_isClosing &&  !m_askToOpenAgain)
            {
                CloseDoor();
            }
        }


    }

    public void OpenDoor()
    {
        if (!m_isOpen)
        {
            m_isOpen = true;
            m_isClosing = false;
            m_askToOpenAgain = false;
            m_currentTime = 0f;
            transform.Translate(m_doorMovement);
        }
        else
        {
            m_askToOpenAgain = true;
        }
    }

    public void AskToCloseDoor()
    {
        if (m_isOpen && !m_isClosing)
        {
            m_isClosing = true;
        }
    }

    private void CloseDoor()
    {
        transform.Translate(-m_doorMovement);
        m_isOpen = false;
        m_isClosing = false;
        m_askToOpenAgain = false;
        m_currentTime = 0f;
    }
}
