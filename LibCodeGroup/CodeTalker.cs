using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Text;

namespace LibCodeGroup
{
    public static class CodeTalker
    {
        private static string AddWhiteSpace(string code)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < code.Length; i++)
            {
                sb.Append(code[i] + " ");
            }

            return sb.ToString();
        }

        private static string Split5(string code)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < code.Length; i++)
            {
                if (i % 10 == 0  && i != 0)
                    sb.Append(code[i] + ", ");
                else
                    sb.Append(code[i]);
            }

            return sb.ToString();
        }

        public static void Speak(string code)
        {
            code = AddWhiteSpace(code);
            code = Split5(code);

            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Rate = -4;
            speech.SpeakAsync(code);

            Console.ReadLine();
        }
    }
}
