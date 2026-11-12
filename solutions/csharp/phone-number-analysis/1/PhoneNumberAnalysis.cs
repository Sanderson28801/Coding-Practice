public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNewYork;
        if (phoneNumber.AsSpan().Slice(0, 3) is "212") {
            isNewYork = true;
        } else {
            isNewYork = false;
        }
        bool isFake;
        if (phoneNumber.AsSpan().Slice(4,3) is "555") {
            isFake = true;
        } else {
            isFake = false;
        }

        return (isNewYork, isFake, phoneNumber.Substring(8, 4));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
