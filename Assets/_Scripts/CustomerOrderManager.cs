using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrderManager : MonoBehaviour
{
    public List<CustomerData> customerData;
    public List<CustomerData> inOrder;

    public float timerToOrder;
    [SerializeField] float timer;

    private void Update()
    {
        //timer -= Time.deltaTime;
        //if (timer < 0)
        //{
        //    timer = timerToOrder;
        //    AddInOrder(customerData[RandomIndex()]);
        //}
    }

    public int RandomIndex()
    {
        int rand = Random.Range(0, customerData.Count);
        return rand;
    }

    private void AddInOrder(CustomerData cstData)
    {
        if (!inOrder.Contains(cstData))
        {
            inOrder.Add(cstData);
        }
        else
        {
            //Reset Timer 
            timer = 1;
        }
    }
}
