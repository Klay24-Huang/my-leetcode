using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All._2491._Divide_Players_Into_Teams_of_Equal_Skill
{
    public class Solution
    {
        public long DividePlayers(int[] skill)
        {
            Array.Sort(skill);

            long standardValue = skill[0] + skill[^1];
            long answer = skill[0] * skill[^1];
            //Console.WriteLine(standardValue);
            for (int i = 1; i < skill.Length/2; i++)
            {
                long tempValue = skill[i] + skill[skill.Length-1-i];
                //Console.WriteLine(tempValue);
                if (tempValue != standardValue)
                {
                    return -1;
                }
                else
                {
                    answer += skill[i] * skill[skill.Length - 1 - i];
                }
            }
            return answer;
        }
    }
}
