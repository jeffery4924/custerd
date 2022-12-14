/// The text of the script.
using System;
using System.Text;
namespace cust
{
    class ext
    {
    public static string GetCurrentTime()
    {
        // We use the Now property of the DateTime class to get the current date and time
        DateTime now = DateTime.Now;

        // We use the ToString method of the DateTime class to format the date and time as a string
        return now.ToString("hh:mm:ss tt");
    }
        public struct Time
{
    // We define a private field called "seconds" that will hold the time value in seconds
    private int seconds;

    // We define a constructor for the Time struct that takes an integer value representing the time in seconds
    public void Set(int ti)
    {
        this.seconds = ti;
    }

    // We define a function called "GetHours" that returns the number of hours in the time value
    public int GetHours()
    {
        // We divide the total number of seconds by 3600 (the number of seconds in one hour) to get the number of hours
        return this.seconds / 3600;
    }

    // We define a function called "GetMinutes" that returns the number of minutes in the time value
    public int GetMinutes()
    {
        // We divide the total number of seconds by 60 (the number of seconds in one minute) and take the remainder to get the number of minutes
        return this.seconds % 60;
    }

    // We define a function called "GetSeconds" that returns the number of seconds in the time value
    public int GetSeconds()
    {
        // We use the modulo operator to get the number of seconds
        return this.seconds % 60;
    }
}
        public double Average(int[] array) {
  int sum = 0;
  for (int i = 0; i < array.Length; i++) {
    sum += array[i];
  }
  return (double)sum / array.Length;
}
        public static string AskQuestion(string question)
    {
        // We use a switch statement to check the input question and return a corresponding answer
        switch (question)
        {
            // If the question is "What is your name?", we return "I am Assistant"
            case "What is your name?":
                return "I am Assistant";
                break;
            // If the question is "What is the meaning of life?", we return "42"
            case "What is the meaning of life?":
                return "42";
                break;
            // If the question is "What is your favorite color?", we return "I don't have a favorite color"
            case "What is your favorite color?":
                return "I don't have a favorite color";
                break;
            // If the question is "What is your favorite food?", we return "I don't have a favorite food"
            case "What is your favorite food?":
                return "I don't have a favorite food";
                break;
            // If the question is anything else, we return "I'm sorry, I don't know the answer to that"
            default:
                return "I'm sorry, I don't know the answer to that";
                break;
        }
    }
        public static string ScrambleString(string o)
        {
            string input = o;

            // Convert the string into a character array
            char[] characters = input.ToCharArray();

            // Scramble the characters using the Fisher-Yates shuffle algorithm
            Random rng = new Random();
            int n = characters.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = characters[k];
                characters[k] = characters[n];
                characters[n] = value;
            }

            // Convert the scrambled characters back into a string and print it
            string scrambled = new string(characters);
            return scrambled;
        }
        private static long ToLongInside(string o, string message, long error_value)
        {
            bool first = false;
            long o2 = (long)(0);
            first = long.TryParse(o, out o2);
            if (!first)
            {
                Writeln(message);
                return error_value;
            }
            else
            {
                return o2;
            }
        }
        private static double ToDoubleInside(string o, string message, double error_value)
        {
            bool first = false;
            double o2 = (double)(0);
            first = double.TryParse(o, out o2);
            if (!first)
            {
                Writeln(message);
                return error_value;
            }
            else
            {
                return o2;
            }
        }
        public static string bin2ascii(string o)
        {
            string binaryString = o;

// Convert the binary string to a byte array
byte[] binaryAsBytes = Enumerable.Range(0, binaryString.Length)
                                 .Where(x => x % 8 == 0)
                                 .Select(x => Convert.ToByte(binaryString.Substring(x, 8), 2))
                                 .ToArray();

// Convert the byte array to a string using the ASCII encoding
string ascii = Encoding.ASCII.GetString(binaryAsBytes);
return ascii;



        }
        public static object Conv(object o, string t)
        {
            Type p = o.GetType();
            if (t == "string")
            {
                if (p.Equals(typeof(int)))
                {

                    return ((int)o).ToString();
                }
                if (p.Equals(typeof(long)))
                {
                    return ((long)o).ToString();
                }
                if (p.Equals(typeof(float)))
                {
                    return ((float)o).ToString();
                }
                if (p.Equals(typeof(float)))
                {

                }
                if (p.Equals(typeof(char)))
                {
                    return ((char)o).ToString();
                }
                if (p.Equals(typeof(double)))
                {
                    return ((double)o).ToString();
                }
                if (p.Equals(typeof(bool)))
                {
                    bool o2 = (bool)o;
                    if (o2)
                    {
                        return "true";
                    }
                    else
                    {
                        return "false";
                    }
                }
            }
            if (t == "int")
            {
                if (p.Equals(typeof(string)))
                {
                    return String2IntInside((string)o, "failed to convert type string to int", 0);
                }
                if (p.Equals(typeof(int)))
                {
                    Writeln("unnecessary conversion from type int to int");
                    return (int)o;
                }
                if (p.Equals(typeof(long)))
                {
                    return (int)(o);
                }
                if (p.Equals(typeof(bool)))
                {
                    bool o2 = (bool)o;
                  if (o2)
                  {
                    return 1;
                  }
                  else
                  {
                    return -1;
                  }
                }
                if (p.Equals(typeof(char)))
                {
                    return String2IntInside(o.ToString(), "failed to convert type char to int will return 0", 0);

                }
                if (p.Equals(typeof(float)))
                {
                    return (int)(Math.Round((float)o));
                }
                if (p.Equals(typeof(Double)))
                {
                    return (int)(Math.Round((Double)o));
                }
                Writeln("failed to find a type to convert is it an array?");
                return 0;
            }
            if (t == "long")
            {
              if (p.Equals(typeof(string)))
              {
                return ToLongInside((string)o,"failed to convert type string to long",0);
              }
              if (p.Equals(typeof(int)))
              {
                return (long)((int)o);
              }
              if (p.Equals(typeof(long)))
              {
                return (long)o;
              }
              if(p.Equals(typeof(float)))
              {
                return (long)(Math.Round((float)o));
              }
              if (p.Equals(typeof(double)))
              {
                return (long)(Math.Round((double)o));
              }
              if (p.Equals(typeof(char)))
              {
                char o2 = (char)o;
                return ToLongInside(o2.ToString(),"failed to convert type char to long",0);
              }
            }
            if (t == "double")
            {
                if  (p.Equals(typeof(double)))
                {
                    return (double)o;
                }
                if (p.Equals(typeof(string)))
                {
                    return ToDoubleInside((string)o,"failed to convert type string to double",0);
                }
                if (p.Equals(typeof(long)))
                {
                    return ToDoubleInside(((long)o).ToString(),"failed to convert type long to double",0);
                }
                if (p.Equals(typeof(float)))
                {
                    return ToDoubleInside(((float)o).ToString(),"failed to convert type float to double",0);
                }
                if (p.Equals(typeof(int)))
                {
                    return ToDoubleInside(((int)o).ToString(),"failed to convert int to double",0);
                }
                if (p.Equals(typeof(char)))
                {
                    return ToDoubleInside(((char)o).ToString(),"failed to convert type char to double",0);
                }
                if (p.Equals(typeof(bool)))
                {
                    bool o2 = (bool)o;
                    if (o2)
                    {
                        return (double)1;
                    }
                    else
                    {
                        return (double)-1;
                    }
                }
            }
            if (t == "float")
            {
                if (p.Equals(typeof(string)))
                {
                    bool first = false;
                    float o2 = 0f;
                    first = float.TryParse((string)o,out o2);
                    if (!first)
                    {
                        Writeln("failed to convert string to float");
                        return 0;
                    }
                    return o2;
                }
                if (p.Equals(typeof(int)))
                {
                    bool first = false;
                    float o2 = 0f;
                    first = float.TryParse(((int)o).ToString(),out o2);
                    if (!first)
                    {
                        Writeln("failed to convert int to float");
                        return 0;
                    }
                    return o2;
                }
                if (p.Equals(typeof(long)))
                {
                    bool first = false;
                    float o2 = 0f;
                    first = float.TryParse(((long)o).ToString(),out o2);
                    if (!first)
                    {

                        Writeln("failed to convert long to float");
                        return 0; 
                }
                    return o2;
                }
                if (p.Equals(typeof(double)))
                {
                    bool first = false;
                    float o2 = 0f;
                    first = float.TryParse(((double)o).ToString(),out o2);
                    if (!first)
                    {
                        Writeln("failed to convert double to float");
                        return 0;
                    }
                    return o2;
                }
                if (p.Equals(typeof(char)))
                {
                    bool first = false;
                    float o2 = 0f;
                    first = float.TryParse(((char)o).ToString(),out o2);
                    if (!first)
                    {
                        Writeln("failed to convert char to float");
                        return 0;
                    }
                    return o2;
                }
                if (p.Equals(typeof(bool)))
                {
                    bool o2 = (bool)o;
                    if (o2)
                    {
                        return (float)1;
                    }
                    return (float)-1;
                }
                if (p.Equals(typeof(float)))
                {
                    return (float)o;
                }
            }
            if (t == "char")
        {
                if (p.Equals(typeof(string)))
                {
                    bool first = false;
                    char o2 = '\0';
                    first = char.TryParse((string)o,out o2);
                    if (!first)
                    {
                        Writeln("failed to convert string to char");
                        return 0;
                    }
                    return o2;
                }
                if (p.Equals(typeof(int)))
                {
                    bool first = false;
                    char o2 = '\0';
                    first = char.TryParse(((int)o).ToString(),out o2);
                    if (!first)
                    {
                        Writeln("failed to convert int to char");
                        return 0;
                    }
                    return o2;
                }
                if (p.Equals(typeof(long)))
                {
                    bool first = false;
                    char o2 = '\0';
                    first = char.TryParse(((long)o).ToString(),out o2);
                    if (!first)
                    {
                        Writeln("failed to convert long to char");
                        return 0;
                    }
                    return o2;
                }
                if (p.Equals(typeof(double)))
                {

                bool first = false;
                char o2 = '\0';
                first = char.TryParse(((double)o).ToString(),out o2);
                if (!first)
                {
                    Writeln("failed to convert double to char");
                    return 0;
                }
                return o2;
                }
            }
            if (t == "bool")
            {
                if (p.Equals(typeof(string)))
                {
                    string o2 = (string)o;
                    if (o2 == "true")
                    {
                        return true;
                    }
                    if (o2 == "false")
                    {
                        return false;
                    }
                    return 0;
                }
                if (p.Equals(typeof(int)))
                {
                    int o2 = (int)o;
                    if (o2 == 1)
                    {
                        return true;
                    }
                    if (o2 == 0)
                    {
                        return false;
                    }
                }
                if (p.Equals(typeof(long)))
                {
                    long o2 = (long)o;
                    if (o2 == 1)
                    {
                        return true;
                    }
                    if (o2 == 0)
                    {
                        return false;
                    }
                }
                if (p.Equals(typeof(double)))
                {
                    double o2 = (double)o;
                    if (o2 == 1)
                    {
                        return true;
                    }
                    if (o2 == 0)
                    {
                        return false;
                    }
                    return false;
                }
                if (p.Equals(typeof(float)))
                {
                    float o2 = (float)o;
                    if (o2 == 1)
                    {
                        return true;
                    }
                    if (o2 == 0)
                    {
                        return false;
                    }
                    return false;
                }
                if (p.Equals(typeof(bool)))
                {
                    return (bool)o;
                }
                if (p.Equals(typeof(char)))
                {
                    char o2 = (char)o;
                    if (o2 == '1')
                    {
                        return true;
                    }
                    if (o2 == '0')
                    {
                        return false;
                    }
                    if (o2 == 't')
                    {
                        return true;
                    }
                    if (o2 == 'f')
                    {
                        return false;
                    }
                    if (o2 == 'n')
                    {
                        return false;
                    }
                    if (o2 == 'y')
                    {
                        return true;
                    }
                }
            }
            Writeln("failed to find a type to convert to");
            return "err";
        }
        public static void BinaryTemplate()
        {
            string ch = "";
            while (true)
            {
                Writeln("dec2bin(1) bin2dec(2) encrypt(3) decript(4)");
                ch = Read();
                if (ch == "1")
                {
                    Writeln("enter the decimal number");
                    Writeln(Decimal2Binary(Read()));
                }
                if (ch == "2")
                {
                    Writeln("enter the binary number");
                    Writeln(Binary2Decimal(Read()));
                }
                if (ch == "3")
                {
                    Writeln("enter the the letters to encrypt");
                    Writeln(decry(Read()));
                }
                if (ch == "4")
                {
                    Writeln("enter the the letters to decrypt");
                    Writeln(encry(Read()));
                }
            }
        }
        public static int Len(object o)
        {
            Type t = o.GetType();
            if (t.Equals(typeof(string)))
            {
                return ((string)o).Length;
            }
            if (t.Equals(typeof(int)))
            {
                return ((int)o).ToString().Length;
            }
            if (t.Equals(typeof(long)))
            {
                return ((long)o).ToString().Length;
            }
            if (t.Equals(typeof(float)))
            {
                return ((float)o).ToString().Length;
            }
            if (t.Equals(typeof(Double)))
            {
                return ((Double)o).ToString().Length;
            }
            if (t.Equals(typeof(bool)))
            {
                Writeln("cant convert type bool to length");
                return 0;
            }
            if (t.Equals(typeof(char)))
            {
                return ((char)o).ToString().Length;
            }
            return 0;
        }
        public static bool Boolify(object o)
        {
            Type t = o.GetType();
            if (t.Equals(typeof(string)))
            {
                string o2 = (string)o;
                if (o2 == "true")
                {
                    return true;
                }
                else if (o2 == "false")
                {
                    return false;
                }
            }
            if (t.Equals(typeof(int)))
            {
                int o2 = (int)o;
                if (o2 == 0)
                {
                    return false;
                }
                if (o2 == 1)
                {
                    return true;
                }
            }
            if (t.Equals(typeof(char)))
            {
                char o2 = (char)o;
                if (o2 == 'y')
                {
                    return true;
                }
                if (o2 == 'n')
                {
                    return false;
                }
                if (o2 == 't')
                {
                    return true;
                }
                if (o2 == 'f')
                {
                    return false;
                }
            }
            return false;
        }
        private static int String2IntInside(string o, string message, int fail_value)
        {
            float o2 = 0;
            int o3 = 0;
            bool first = float.TryParse(o, out o2);
            if (!first)
            {
                o3 = fail_value;
                Writeln(message + "1");
                return o3;
            }
            first = Int32.TryParse((Math.Round((Double)o2)).ToString(), out o3);
            if (!first)
            {
                o3 = fail_value;
                Writeln(message + "2");
                return o3;
            }
            return o3;
        }
        public static int Intify(object o)
        {
            Type t = o.GetType();
            if (t.Equals(typeof(string)))
            {
                return String2IntInside((string)o, "failed to convert type string to int", 0);
            }
            if (t.Equals(typeof(int)))
            {
                Writeln("unnecessary conversion from type int to int");
                return (int)o;
            }
            if (t.Equals(typeof(long)))
            {
                return (int)(o);
            }
            if (t.Equals(typeof(bool)))
            {
                Writeln("canot convert type bool to int will return 0");
                return 0;
            }
            if (t.Equals(typeof(char)))
            {
                return String2IntInside(o.ToString(), "failed to convert type char to int will return 0", 0);

            }
            if (t.Equals(typeof(float)))
            {
                return (int)(Math.Round((float)o));
            }
            if (t.Equals(typeof(Double)))
            {
                return (int)(Math.Round((Double)o));
            }
            Writeln("failed to find a type to convert is it an array?");
            return 0;
        }
        public static string Read()
        {
            return Console.ReadLine();
        }
        public static void Write(object o)
        {
            Console.Write(o);
        }
        public static void Writeln(object o)
        {
            Type t = o.GetType(); // detects type of "place" object
            if (t.Equals(typeof(string)))
            {

            }
            Console.Write(o + "\n");
        }
        public static string Decimal2Binary(string o)
        {
            int num = String2Int(o);
            string str = "";
            while (num > 0)
            {
                if ((num & 1) == 1) // 1
                    str += '1';
                else // 0
                    str += '0';
                num >>= 1; // Right Shift by 1
            }
            return reverse(str);
        }
        public static string reverse(string o)
        {
            string fin = "";
            for (int i = o.Length - 1; i >= 0; i--)
            {
                fin = fin + o[i];
            }
            return fin;
        }
        public static int Binary2Decimal(string o)
        {
            int[] bins = IntArray(o);
            int fin = 0;
            for (int i = 0; i < bins.Length; i++)
            {
                if (bins[i] == 1)
                {
                    bins[i] = (int)(Math.Pow(2, bins.Length - i - 1)) * 1;
                }
                if (bins[i] == 0)
                {
                    bins[i] = (int)(Math.Pow(2, bins.Length - i)) * 0;
                }
            }
            for (int i = 0; i < bins.Length; i++)
            {
                fin = fin + bins[i];
            }
            return fin;

        }
        public static int[] Con2IntArray()
        {
            return IntArray(Console.ReadLine());
        }
        public static int[] IntArray(object o)
        {
            Type t = o.GetType();
            if (t.Equals(typeof(string)))
            {
                string[] o2 = StringArray(o);
                int[] ofin = new int[o2.Length];
                for (int i = 0; i < o2.Length; i++)
                {
                    ofin[i] = String2Int(o2[i]);
                }
                return ofin;
            }
            if (t.Equals(typeof(int)))
            {
                int o2 = (int)o;
                char[] o3 = o2.ToString().ToCharArray();
                int[] fin = new int[o2.ToString().Length];
                for (int i = 0; i < o3.Length; i++)
                {
                    fin[i] = Intify(o3[i].ToString());
                }
                return fin;
            }
            return new int[1];
        }
        public static string encry(string inp)
        {
            string[] abc = ABC();
            string diti = inp;
            string[] data = diti.Split("-");
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != " ")
                {
                    int exisop;
                    bool TRuel = Int32.TryParse(data[i], out exisop);
                    if (!TRuel)
                    {
                        exisop = new Random().Next(abc.Length - 1);
                    }
                    data[i] = abc[exisop];
                    if (!TRuel)
                    {
                        data[i] = data[i] + "\n\n you fucking dumbass stop typeing manualy just copy paste from the decryptor or mabye you copy and pasted more accidently if so sorry i guess just kidding you can die in a burning orphiage for all i care but what i do know is this pro";
                    }
                }
            }
            string fin = "";
            for (int i = 0; i < data.Length; i++)
            {
                fin = fin + data[i];
            }
            return fin;
        }
        public static string decry(string inp)
        {
            string[] abc = ABC();
            string[] data = StringArray(inp);
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if (data[i] == " ")
                    {
                        data[i] = " " + "-";
                    }
                    if (abc[j] == data[i])
                    {
                        data[i] = j.ToString();
                        if (i + 1 != data.Length)
                        {
                            data[i] = data[i] + "-";
                        }
                    }
                }
            }
            string fin = "";
            for (int i = 0; i < data.Length; i++)
            {
                fin = fin + data[i];
            }
            return fin;
        }
        public static string Input(string message)
        {
            Write(message);
            return Console.ReadLine();
        }
        public static string[] StringArray(object o)
        {
            Type t = o.GetType();
            if (t.Equals(typeof(char)))
            {
                Writeln("cant convert type char to string[]");
            }
            if (t.Equals(typeof(int)))
            {
                string dkn = (string)o.ToString();
                char[] jfipo = dkn.ToCharArray();
                string[] jfipo_dkn_fin = new String[jfipo.Length];
                for (int i = 0; i < jfipo.Length; i++)
                {
                    jfipo_dkn_fin[i] = jfipo[i].ToString();
                }
                return jfipo_dkn_fin;
            }
            if (t.Equals(typeof(string)))
            {
                string dkn = (string)o;
                char[] jfipo = dkn.ToCharArray();
                string[] jfipo_dkn_fin = new String[jfipo.Length];
                for (int i = 0; i < jfipo.Length; i++)
                {
                    jfipo_dkn_fin[i] = jfipo[i].ToString();
                }
                return jfipo_dkn_fin;
            }
            return new string[1];
        }
        public static void WriteArray(string[] WriteArray_i)
        {
            for (int i = 0; i < WriteArray_i.Length; i++)
            {
                Console.Write(WriteArray_i[i]);
            }
            Console.Write("\n");
        }
        public static string[] ABC()
        {
            string ABC_ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz`1234567890-=~!@#$%^&*()_+[]{};':\",./<>?'|\\";
            string[] ABC_abc = StringArray(ABC_ABC);
            return ABC_abc;
        }
        public static string[] ConArray()
        {
            string ConArray_datatataORigin = Console.ReadLine();
            string[] ConArray_datatata = StringArray(ConArray_datatataORigin);
            return ConArray_datatata;
        }
        private static int String2Int(string o)
        {
            int o2 = 0;
            bool o2Bool = Int32.TryParse(o, out o2);
            if (!o2Bool)
            {
                Console.WriteLine("failed to convert int to string");
            }
            return o2;
        }
    }
}