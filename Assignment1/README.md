# Green Exercises

## Exercise 1.1

Write a function `sqr : int -> int` that given an integer `x` returns `x` squared.

## Exercise 1.2

Write a function `pow : float -> float -> float` that given two floating point numbers `x` and `n` returns `x` to the power of `n`.

## Exercise 1.3 (based on 1.4 from HR)

Write a recursive function `sum : int -> int` such that given an integer `n` such that `n >= 0` returns the sum of all integers from 0 to `n` inclusive.

`sum n = 0 + 1 + 2 + 3 + ... + n`

## Exercise 1.4 (based on 1.5 from HR)

The sequence $F_0, F_1, F_2, \ldots$ of Fibonacci numbers is defined by:

$$
F_0 = 0
$$
$$
F_1 = 1
$$
$$
F_n = F_{n-1} + F_{n-2}
$$

Thus, the first members of the sequence are 0, 1, 1, 2, 3, 5, 8, 13, ...

Write a function `fib : int -> int` that given an integer `n` such that `n >= 0` computes $F_n$. Use a declaration with three clauses, where the patterns correspond to the three cases of the above definition.

## Exercise 1.5

Write a function `dup : string -> string` that given a string `s` concatenates `s` with itself. You can either use `+` to concatenate strings.

Example: `dup "Hi " = "Hi Hi "`

## Exercise 1.6

Write a function `dupn : string -> int -> string` that given a string `s` and an integer `n` concatenates `s` with itself `n` times.

Example: `dupn "Hi " 3 = "Hi Hi Hi "`



____


## Exercise 1.7 (based on 2.8 from HR)

The following figure gives the first part of Pascal's triangle:

```
    1
   1 1
  1 2 1
 1 3 3 1
1 4 6 4 1
```

The entries of the triangle are called binomial coefficients. The k'th binomial coefficient of the n'th row is denoted $\binom{n}{k}$, for $n \geq 0$ and $k \leq n$. For example, $\binom{2}{1} = 2$ and $\binom{4}{2} = 6$ (note that we start counting at 0). The first and last binomial coefficients, that is, $\binom{n}{0}$ and $\binom{n}{n}$, of row n are both 1. Binomial coefficient inside a row is the sum of the two binomial coefficients immediately above it. These properties can be expressed as follows:

$$\binom{n}{0} = 1$$
$$\binom{n}{n} = 1$$
$$\binom{n}{k} = \binom{n-1}{k-1} + \binom{n-1}{k}$$ if $n \neq 0$, $k \neq 0$, and $n > k$

Declare a function `bin : int * int -> int` that given a pair $(n, k)$ computes $\binom{n}{k}$.
