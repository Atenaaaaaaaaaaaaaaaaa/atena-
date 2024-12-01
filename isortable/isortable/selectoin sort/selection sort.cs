namespace isortable.selection_sort
{
    internal class SelectionSort : ISortable
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int k = array[minIndex];
                array[minIndex] = array[i];
                array[i] = k;
            }
        }
    }
}
