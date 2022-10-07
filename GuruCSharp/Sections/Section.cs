using System;
using System.Collections;
using System.Collections.Generic;
using GuruCSharp.Data;
using GuruCSharp.Interfaces;

namespace GuruCSharp.Sections;

public abstract class Section : IEnumerable<object>
{
    public SortedList<int, object> OrderList { get; protected set; } = new();

    public List<Test> Tests { get; protected set; }

    public List<Theory> Theory { get; protected set; }

    public List<CodeTest> CodeTests { get; protected set; }


    protected void InitOrderList()
    {
        PutEachElementToOrderList(Tests);
        PutEachElementToOrderList(Theory);
        PutEachElementToOrderList(CodeTests);
    }

    private void PutEachElementToOrderList<T>(List<T> collection) where T : IOrderly
    {
        foreach (var element in collection)
        {
            if (OrderList.ContainsKey(element.Order))
            {
                throw new ArgumentException("It order number already exists in order list");
            }
            
            OrderList.Add(element.Order, element);
        }
    }


    public IEnumerator<object> GetEnumerator()
    {
        foreach (var element in OrderList)
        {
            yield return element;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}