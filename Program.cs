
//*****************************************************************************
//** 2419. Longest Subarray With Maximum Bitwise AND   leetcode              **
//*****************************************************************************

int longestSubarray(int* nums, int numsSize)
{
    int mx = INT_MIN;  // Initialize to a very small value
    int ans = 0, cnt = 0;

    // Find the maximum element in the array
    for (int i = 0; i < numsSize; i++)
    {
        if (nums[i] > mx)
        {
            mx = nums[i];
        }
    }

    // Now find the length of the longest subarray with the maximum element
    for (int i = 0; i < numsSize; i++)
    {
        if (nums[i] == mx)
        {
            ++cnt;
            if (cnt > ans)
            {
                ans = cnt;
            }
        }
        else
        {
            cnt = 0;
        }
    }

    return ans;
}