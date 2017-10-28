using System;

namespace TimeConversion
{
    class Program
    {
        static string TimeConversion(string s1)
        {
           // if (s1 == string.Format("hh:mm:ssPM") || s1 == string.Format("hh:mm:ssAM"))
            //{
                string s = s1;
                //char[] charArray = new char[s.Length];
                //charArray = s.ToCharArray();
                int res = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'P')
                    {
                    char a1 = s[0];
                    char a2 = s[1];
                    res= Convert.ToInt32(string.Concat(a1, a2));
                       // res = Convert.ToInt32(s[0]+ s[1]);
                        //    res = Convert.ToInt32(charArray[0].ToString() + charArray[1].ToString());
                        res += 12;
                        if (res < 23)
                        {
                            char h1 = Convert.ToChar(res / 10);
                            char h2 = Convert.ToChar(res % 10);
                            s.Replace(s[0], h1);
                            s.Replace(s[1], h2);

                        }
                        else if (res > 23)
                        {
                            res = res - 12;
                            char h1 = Convert.ToChar(res / 10);
                            char h2 = Convert.ToChar(res % 10);
                            s.Replace(s[0], h1);
                            s.Replace(s[1], h2);

                        }
                    }
                    else
                    if (s[i] == 'A')
                    {
                        if (s[0] == '1' && s[1] == '2')
                        {
                            s.Replace(s[0], '0');
                            s.Replace(s[1], '0');
                        }

                    }
                }
                // string result = new string(charArray);

                return s;
                //string hour = (s[0] + s[1]).ToString(),res=null;
                //int hr = Convert.ToInt32(hour);
                //if (s.Contains("PM"))
                //{
                //    hr = hr + 12;
                //    s.Trim('P', 'M');
                //    res =s.Replace(hour, hr.ToString());
                //   // (s[0]+s[1]) = hr.ToString();
                //}
                //return res;
           // }
            //else 
       // return "Wrong format string bro!!";

        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = TimeConversion(s);
            Console.WriteLine(result);
        }
    }
}
