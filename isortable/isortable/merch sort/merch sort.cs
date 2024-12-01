namespace isortable.merch_sort
{
    internal class MergeSort : ISortable
    {
        public void Sort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                Sort(array, left, mid);
                Sort(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }

        private void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                R[j] = array[mid + 1 + j];

            int k = left, iIndex = 0, jIndex = 0;

            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex] <= R[jIndex])
                {
                    array[k] = L[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = R[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
                array[k++] = L[iIndex++];

            while (jIndex < n2)
                array[k++] = R[jIndex++];
        }
    }
}
