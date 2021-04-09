using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerBettingSite
{
    public class Bet
    {

        public static void Main(String[] args)
        {
            String[] result = { "2-2", "2-0", "0-1", "3-3", "2-1" };
            String[] bet = { "2-2", "3-1", "4-1", "0-1", "4-4" };
            Console.WriteLine(getPrizeWon(result, bet));
        }

        public static String getPrizeWon(String[] result, String[] bet)
        {
            if (bet.Length < result.Length)
            {
                return "You lost the bet";
            }

            String[] betSplit = new String[2];
            String[] resultSplit = new String[2];
            int countValidScores = 0;
            int countValidMatchWinners = 0;

            for (int i = 0; i < result.Length; i++)
            {
                betSplit = bet[i].Split("-");
                resultSplit = result[i].Split("-");
                if ((betSplit[0] == resultSplit[0]) && (betSplit[1] == resultSplit[1]))
                {
                    countValidScores++;
                }

                int res1 = Int32.Parse(betSplit[0]) - Int32.Parse(betSplit[1]);
                int res2 = Int32.Parse(resultSplit[0]) - Int32.Parse(resultSplit[1]);
                if ((res1 > 0 && res2 > 0) || (res1 == 0 && res2 == 0) || (res1 < 0 && res2 < 0))
                {
                    countValidMatchWinners++;
                }
            }

            if (countValidScores == result.Length)
            {
                return "You won the Jackpot";
            }

            if (countValidMatchWinners == result.Length)
            {
                return "You won a Consolation Prize";
            }

            return "You lost the bet";
        }
    }
}
