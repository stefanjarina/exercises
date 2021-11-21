using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var splittedPhoneNumber = phoneNumber.Split('-');

        return (splittedPhoneNumber[0] == "212", splittedPhoneNumber[1] == "555", splittedPhoneNumber[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
