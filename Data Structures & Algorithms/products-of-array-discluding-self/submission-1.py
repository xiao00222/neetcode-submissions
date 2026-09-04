class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        res=[1]*(len(nums))
        n=len(nums)
        for i in range (1,n):
            res[i]=res[i-1]*nums[i-1]
        postfix=1
        for i in range(n-1,-1,-1):
            res[i]*=postfix
            postfix*=nums[i]
        return res
            
        
        