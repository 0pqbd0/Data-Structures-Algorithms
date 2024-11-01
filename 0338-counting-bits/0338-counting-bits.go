func countBits(n int) []int {
    var res []int = make([]int, n + 1)
    for i := 0; i <= n; i++ {
        tmp := i
        for tmp != 0 {
            tmp &= (tmp - 1)
            res[i]++
        }
    }
    return res
}