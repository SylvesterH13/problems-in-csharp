namespace KArraySizeGreatestSum
{
    public static class InputData
    {
        public static IEnumerable<(int[] elements, int k)> Get()
        {
            yield return (elements: new int[] { 1, 2, 3, 4 }, k: 1);
            yield return (elements: new int[] { 1, 2, 3, 4 }, k: 2);
            yield return (elements: new int[] { 1, 2, 3, 4 }, k: 3);
            yield return (elements: new int[] { 1, 2, 3, 4 }, k: 4);

            yield return (elements: new int[] { 2, 4, 3, 1 }, k: 1);
            yield return (elements: new int[] { 2, 4, 3, 1 }, k: 2);
            yield return (elements: new int[] { 2, 4, 3, 1 }, k: 3);
            yield return (elements: new int[] { 2, 4, 3, 1 }, k: 4);
        }
    }
}
