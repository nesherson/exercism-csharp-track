using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
		var phoneNumSplit = phoneNumber.Split('-');
        
        return (Int32.Parse(phoneNumSplit[0]) == 212, Int32.Parse(phoneNumSplit[1]) == 555, phoneNumSplit[2]);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.Item2;
    }
}
