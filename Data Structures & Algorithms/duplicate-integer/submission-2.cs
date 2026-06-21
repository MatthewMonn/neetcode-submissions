public class Solution {
    public bool hasDuplicate(int[] nums) {
    var HashSet = new HashSet<int>();
    foreach (var num in nums){
        if (HashSet.Add(num)){
            continue;
        }
        else{
            return true;
        }
    }
    return false;
    }
}
//100,100,200,200,300,500,600
// iterate through the array
// if you find duplicate, return true, else false. 
// simple would be something to hold the current value, run the whole array, 
// move to the i++ index , rinse and repeat
// I wonder if there is a check all array function to use
// take the number and see if there is a count greater than 1, that means duplicate