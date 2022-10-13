using KArraySizeGreatestSum;

var GetKArraySizeGreatestSum = (int[] elements, int k) =>
{
    if (k > elements.Length)
    {
        throw new ArgumentException($"The sub array length cannot be greater then {nameof(elements)} length", nameof(k));
    }

    var firstSubArraySum = 0;

    for (var i = 0; i < k; i++)
    {
        firstSubArraySum += elements[i];
    }

    var greatestSum = firstSubArraySum;
    var lastSum = firstSubArraySum;
    for (int i = 1, j = k; j < elements.Length; j++, i++)
    {
        var minusOneIndexElement = elements[i - 1];
        var lastElementCurrentSubArray = elements[j];

        var currentSum = lastSum - minusOneIndexElement + lastElementCurrentSubArray;
        if (greatestSum < currentSum)
        {
            greatestSum = currentSum;
        }

        lastSum = currentSum;
    }

    return greatestSum;
};

foreach ((int[] elements, int k) in InputData.Get())
{
    var result = GetKArraySizeGreatestSum(elements, k);
    Console.WriteLine($"elements: [{string.Join(", ", elements)}]; k: {k}; result: {result}");
}