/**
 * @param {number[]} arr
 * @param {number[][]} queries
 * @return {number[]}
 */
var xorQueries = function (arr, queries) {
    let ans = []
    let prefixSumArr = [0, arr[0]]
    let prev = arr[0]
    for (let index = 1; index < arr.length; index++) {
        prev = prev ^ arr[index]
        prefixSumArr.push(prev)
    }

    queries.forEach(q => {
        let left = q[0] + 1
        let right = q[1] + 1
        ans.push(prefixSumArr[right] ^ prefixSumArr[left - 1])
    });
    return ans
};