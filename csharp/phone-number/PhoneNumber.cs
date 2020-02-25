using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string cleanedNum = Regex.Replace(phoneNumber, @"\D", "");

        if (cleanedNum.Length < 10 || 11 < cleanedNum.Length)
        {
            throw new ArgumentException("Too short to be a valid number");
        }
        else if (cleanedNum.Length == 11)
        {
            if (cleanedNum[0] != '1')
            {
                throw new ArgumentException("The country code is not 1");
            }

            // trim away country code
            cleanedNum = cleanedNum.Substring(1);
        }

        if (cleanedNum.Length == 10)
        {
            if (cleanedNum[0] == '0' || cleanedNum[0] == '1')
            {
                throw new ArgumentException("The area code is invalid");
            }
            if (cleanedNum[3] == '0' || cleanedNum[3] == '1')
            {
                throw new ArgumentException("The exchange code is invalid");
            }
        }

        return cleanedNum;
    }
}