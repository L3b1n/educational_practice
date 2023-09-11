# Calculations

## Task description ##

- Implement a [GetSumOne](Calculations/Calculator.cs#L12) method to calculate the following sum $`1/1+1/2+...+1/n`$ of $`n > 0`$ elements.
- Implement a [GetSumTwo](Calculations/Calculator.cs#L23) method to calculate the following sum $`1/(1\cdot 2)-1/(2\cdot 3)+...+(-1)^{n+1}/(n\cdot (n+1))`$ of $`n > 0`$ elements. Don't use `if`-statement, `?:` conditional operator and `Math.Pow`- method.
- Implement a [GetSumThree](Calculations/Calculator.cs#L34) method to calculate the following sum $`1/1^5+1/2^5+...+1/n^5`$ of $`n > 0`$ elements.
- Implement a [GetSumFour](Calculations/Calculator.cs#L45) method to calculate the following sum $`1/3^2+1/5^2+...+1/(2\cdot n + 1)^2`$ of $`n > 0`$ elements. Don't use `if`-statement or `?:` conditional operator.
- Implement a [GetProductOne](Calculations/Calculator.cs#L56) method to calculate the following product $`(1+1/1^2)\cdot(1+1/2^2)\cdot...\cdot(1+1/n^2)`$ of $`n > 0`$ elements.
- Implement a [GetSumFive](Calculations/Calculator.cs#L67) method to calculate the following sum $`-1/3+1/5+...+(-1)^n/(2\cdot n+1)`$ of $`n > 0`$ elements. Don't use `if`-statement, `?:` conditional operator and `Math.Pow`- method.
- Implement a [GetSumSix](Calculations/Calculator.cs#L78) method to calculate the following sum $`1/1+1·2/(1+1/2)+...+1·2·...·n/(1+1/2+...+1/n)`$ of $`n > 0`$ elements. 
- Implement a [GetSumSeven](Calculations/Calculator.cs#L89) method to calculate the following sum $`\sqrt{2+\sqrt{2+...+\sqrt{2}}}`$ of $`n > 0`$-roots.
- Implement a [GetSumEight](Calculations/Calculator.cs#L100) method to calculate the following sum $`1/sin1° + 1/(sin1°+sin2°)+...+1/(sin1°+sin2°+...+sinn°)`$ of $`n > 0`$ elements. See [Math.Sin](https://docs.microsoft.com/en-us/dotnet/api/system.math.sin?view=netcore-3.1). To get the value of the argument in radians use  the following formula $`α_{rad}=π α°/180°`$.