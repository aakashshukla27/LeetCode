public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        List<IList<int>> returnResult = new();
        Array.Sort(nums);
        backTrack(returnResult, new List<int>(), nums, 0);
        return returnResult;
    }
    
    private void backTrack(List<IList<int>> answer, List<int> tempList, int[] nums, int start){
        answer.Add(new List<int>(tempList));
        for(int i = start; i<nums.Length; i++){
            if(i > start && nums[i] == nums[i-1]) 
                continue;
            tempList.Add(nums[i]);
            backTrack(answer, tempList, nums, i+1);
            tempList.Remove(nums[i]);
        }
    }
}
