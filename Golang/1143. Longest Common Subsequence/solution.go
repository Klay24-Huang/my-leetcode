package main

func longestCommonSubsequence(text1 string, text2 string) int {
	l1, l2 := len(text1), len(text2)
	dp := make([][]int, l1+1)
	for i := range dp {
		dp[i] = make([]int, l2+1)
	}

	for i := 1; i < l1+1; i++ {
		for j := 1; j < l2+1; j++ {
			// fmt.Println(i, j)
			if text1[i-1] != text2[j-1] {
				dp[i][j] = max(dp[i-1][j], dp[i][j-1])
				continue
			}
			dp[i][j] = 1 + dp[i-1][j-1]
		}
	}

	return dp[l1][l2]
}

func max(num1, num2 int) int {
	if num1 > num2 {
		return num1
	}
	return num2
}
