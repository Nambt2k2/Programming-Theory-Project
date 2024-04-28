using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    private string nameAnimal;
    private float m_forceJump;
    public float forceJump
    {
        get { return m_forceJump; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative force jump!");
            }
            else
            {
                m_forceJump = value;
            }

        }
    }

    public void Jump()
    {
        Debug.Log(nameAnimal);
        Debug.Log("Jump: " + forceJump + "m");
    }

    public void Walk()
    {
        Debug.Log("Walk");
    }

    public virtual void Talk()
    {
        Debug.Log("Talk");
    }
}
