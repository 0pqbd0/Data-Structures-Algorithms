func missingNumber(nums []int) int {
    sum1, sum2 := 0, 0
    for i:= 1; i <= len(nums); i++ {
        sum1 += nums[i - 1]
        sum2 += i
    }
    return sum2 - sum1
}