using System;
//It should have 9 digits.
//It should be divided into 3 parts by hyphen (-).
//The first part should have 3 digits and should not be 000, 666, or between 900 and 999.
//The second part should have 2 digits and it should be from 01 to 99.
//The third part should have 4 digits and it should be from 0001 to 9999.
namespace SSN_
{
    public class Digits
    {
        public string value;

        public Digits(string val)
        {
            value = val;
        }
        public string Magnitud()
        {
            string result = "";
            int cont = 0;
            for (int i = 0; i < value.Length; i++)
            {
                bool pass = char.IsDigit(value[i]);
                if (pass)
                {
                    cont++;
                }
            }
            if (cont != 9)
            {
                result = "Your SSN is incorrect. \nIt should have 9 digits.";
            }
            else
            {
                result = "Your SSN is correct.";
            }
            return result;
        }
        public string Separate()
        {
            string result = "";
            if (value[3] != '-' || value[6] != '-')
            {
                result = "Your SSN is incorrect. \nIt should be divided into 3 parts by hyphen (-).";
            }
            else
            {
                result = "Your SSN is correct.";
            }
            return result;
        }
        public string FirstPart()
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                result += value[i];
            }
            if (result == "000" || result == "666" || (int.Parse(result) > 900 && int.Parse(result) < 999))
            {
                result = "Your SSN is incorrect. \nThe first part should have 3 digits and should not be 000, 666, or between 900 and 999.";
            }
            else
            {
                result = "Your SSN is correct.";
            }
            return result;
        }
        public string SecondPart()
        {
            string result = "";
            for (int i = 4; i < 6; i++)
            {
                result += value[i];
            }
            if (int.Parse(result) < 01 || int.Parse(result) > 99)
            {
                result = "Your SSN is incorrect. \nThe second part should have 2 digits and it should be from 01 to 99.";
            }
            else
            {
                result = "Your SSN is correct.";
            }
            return result;
        }
        public string ThirdPart()
        {
            string result = "";
            for (int i = 7; i < 10; i++)
            {
                result += value[i];
            }
            if (int.Parse(result) < 0001 || int.Parse(result) > 9999)
            {
                result = "Your SSN is incorrect. \nThe second part should have 4 digits and it should be from 0001 to 9999.";
            }
            else
            {
                result = "Your SSN is correct.";
            }
            return result;
        }
    }
}
