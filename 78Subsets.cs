public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> returnResult = new List<IList<int>>();
        Array.Sort(nums);
        backTrack(nums, 0, returnResult, new List<int>());
        return returnResult;
    }
    
    public void backTrack(int[] nums, int index, List<IList<int>> answer, List<int> tempList){
        answer.Add(new List<int>(tempList));
        for(int i = index; i < nums.Length; i++){
            tempList.Add(nums[i]);
            backTrack(nums, i+1, answer, tempList);
            tempList.Remove(nums[i]);
        }
    }
}
