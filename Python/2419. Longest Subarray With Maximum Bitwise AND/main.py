class Solution:
    def longestSubarray(self, nums: List[int]) -> int:
        ans = 0
        tempCount = 0
        maxNum = 0
        for num in nums:
            if num > maxNum:
                maxNum = num
                ans = 1
                tempCount = 1
            elif num == maxNum:
                tempCount = tempCount + 1
                if(tempCount > ans):
                    ans = tempCount
            else:
                tempCount = 0
        
        return ans