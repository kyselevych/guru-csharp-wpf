using System;
using System.Collections;
using System.Collections.Generic;
using GuruCSharp.Data;
using GuruCSharp.Interfaces;

namespace GuruCSharp.Sections;

public abstract class Section : IEnumerable<object>
{
    public SortedList<int, object> OrderList { get; protected set; } = new();

    public int CurrentPoints { get; set; } = 0;
    
    public int MaxPoints { get; set; }

    protected List<Test> Tests { get; init; }

    protected List<Theory> Theory { get; init; }

    protected List<CodeTest> CodeTests { get; init; }


    protected void InitializeSection()
    {
        AddCollectionToSection(Tests);
        AddCollectionToSection(Theory);
        AddCollectionToSection(CodeTests);
    }

    private void AddCollectionToSection<T>(List<T> collection) where T : IOrderly
    {
        foreach (var element in collection)
        {
            if (OrderList.ContainsKey(element.Order))
            {
                throw new ArgumentException("It order number already exists in order list");
            }

            if (element is IQuestion)
            {
                MaxPoints += 1;
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