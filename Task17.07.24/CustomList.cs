using System.Collections;

namespace Task17._07._24;

public class CustomList<T> :IEnumerable<T>
{
    public T[] CList;

    public CustomList()
    {
        CList = new T[0];
    }
    public T this[int i]
    {
        get { return CList[i]; }
        set { CList[i] = value; }
    }
    public void RemoveAll()
    {
        Array.Resize(ref CList, 0);
    }
    public void Add(T item)
    {
        Array.Resize(ref CList, CList.Length + 1);
        CList[CList.Length-1] = item;
    }
    public void Remove(T item)
    {
        for (int i = 0; i > CList.Length; i++)
        {
            if (CList[i].Equals(item))
            {
                for (int j=i+1; j < CList.Length-1; j++)
                {
                    CList[j] = CList[j+1];

                }
                Array.Resize(ref CList, CList.Length - 1);
            }
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in CList)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (T item in CList)
        {
            yield return item;
        }
    }
}
