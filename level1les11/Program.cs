using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string MassVote(int N, int[] Votes)
        {
            string Not = "Initial conditions is not correct";
            foreach (int v in Votes)
            {
                if (v < 0) return Not;

            }
            if (Votes.Length < 1) return Not;
            if (N != Votes.Length)
            {
               return Not;
            }
            int Big = Votes[0];
            int BigIndex = 0;
            bool big = true;
            bool maj = true;
            int sum = 0;
            int EqualCheck = 0;
            string MajorityString = "majority winner ";
            string MinorityString = "minority winner ";
            string NoWin = "no winner";
            foreach (int v in Votes)
            {
                sum = sum + v;
            }

            for (int i = 1; i < Votes.Length; i++)
            {

                if (Big < Votes[i])
                {
                    Big = Votes[i];
                    BigIndex = i;

                }
            }

            for (int i = 0; i < Votes.Length; i++)
            {

                if (Big == Votes[i])
                {
                    EqualCheck++;
                }
            }

            if (EqualCheck == 1) big = true;
            if (EqualCheck > 1) big = false;

            double test2 = (double)Big / sum;
            double test = Math.Round(((double)Big * 100 / sum), 2);
            if (big)
            {
                BigIndex = BigIndex + 1;

                if (Math.Round(((double)Big * 100 / sum), 2) > 50)
                {
                    maj = true;
                    MajorityString = MajorityString.Insert(MajorityString.Length, Convert.ToString(BigIndex));
                    return MajorityString;
                }
                else
                {
                    maj = false;
                    MinorityString = MinorityString.Insert(MinorityString.Length, Convert.ToString(BigIndex));
                    return MinorityString;
                }
            }
            else return NoWin;
        }

        //static void Main(string[] args)
        //{
        //    int[] Votes = {5001,5001, 4999 };
        //    int N = Votes.Length;
        //    string otv = MassVote(N, Votes);
        //    Console.WriteLine(otv);
        //    Console.WriteLine(otv[otv.Length-1]);
         
        //}
    }
}
