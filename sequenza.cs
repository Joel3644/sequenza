using System;
using System.Collections.Generic;
using System.Linq;

public static class Sequenza
{
    public static int[] Verifica( int N ) 
    {
        int sum = 0, num = 0, count = 0;
        int[] nums;

        for(int i = 0; i <= N; i++) sum += i;
        nums = new int[sum];

        for(int i = 0; i < sum; i++){
            if(count == num){ count = 0; num++; }
            nums[i] = num;
            if(count < num) count++;
        }

        return nums;
    }
}