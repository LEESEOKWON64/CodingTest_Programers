using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        List<int> list = new List<int>();
            int[] answer = new int[] { };
            switch (direction)
            {
                case "right":
                    list.Add(numbers[numbers.Length - 1]);
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        list.Add(numbers[i]);
                    }
                    answer = list.ToArray();
                    break;
                case "left":
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        list.Add(numbers[i]);
                    }
                    list.Add(numbers[0]);
                    answer = list.ToArray();
                    break;
            }
            return answer;
    }
}