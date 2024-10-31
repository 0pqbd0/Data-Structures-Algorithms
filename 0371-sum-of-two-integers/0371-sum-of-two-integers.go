func getSum(a int, b int) int {
    res := a ^ b
    carry := (a & b) << 1
    for carry != 0 {
        tmp := res
        res = res ^ carry
        carry = (tmp & carry) << 1
    }
    return res
}
