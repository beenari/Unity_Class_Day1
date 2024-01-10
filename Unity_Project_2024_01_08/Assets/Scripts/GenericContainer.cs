using System.Collections.Generic;

public class GenericContainer<T>
{
    private T[] items;                          //���ʸ� �迭 ����
    //private List<T> itemList;
    private int currentIndex = 0;               //�迭 Index ����

    public GenericContainer(int capacity)       //������ �� �� ���ڸ� �޾ƿͼ� �迭 ������ �����
    {
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if(currentIndex < items.Length)
        {
            items[currentIndex] = item; 
            currentIndex++;
        }
    }

    public T[] GetItems()
    {
        return items;
    }

}
