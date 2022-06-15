using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    private int m_amount;
    public int amount // ENCAPSULATION
    {
        get { return m_amount; } 
        set 
        {
            if (value < 0)
            {
                Debug.Log("Resource amount cannot be below 0!");
            }
            else
            {
                m_amount = value;
            }
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        //amount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void MakeResource()// POLYMORPHISM
    {
        AddAmount(1);
    }

    public void AddAmount(int value)// ABSTRACTION
    {
        amount += value;
    }

    public void ReduceAmount(int value)// ABSTRACTION
    {
        amount -= value;
    }
    
}
