func hammingWeight(n int) int {
    var res int = 0
    for n != 0 {
        res += n & 1
        n >>= 1
    }
    return res
}