class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    //public int this[int index]
    //{
    //    get
    //    {
    //        if (index >= 0 && index < array.Length)
    //            return array[index];
    //        else
    //            return 0;
    //    }
    //    set
    //    {
    //        if (index >= 0 && index < array.Length)
    //            array[index] = value;
    //    }
    //}

    public int this[int i]
    {
        get
        {
            return array[i];
        }
        set
        {
            array[i] = value;
        }
    }
}