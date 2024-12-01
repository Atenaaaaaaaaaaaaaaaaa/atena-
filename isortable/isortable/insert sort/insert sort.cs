namespace isortable.insert_sort
{
    internal class InsertSort : ISortable
    {
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int y = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > y)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = y;
            }
        }
    }
}
