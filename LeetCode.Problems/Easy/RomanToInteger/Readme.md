# Roman to Integer Conversion

## Overview

1. **Initialization**: Begin by initializing a `total` variable to `0`. This variable will be used to store the integer
   representation of the Roman numeral.

2. **Iterate Over String**:
    - For each character in the Roman numeral string:
        - Retrieve its integer value.
        - If this character isn't the last one and its value is less than that of the next character:
            - Subtract the value of the current character from the next one and add the result to `total`.
            - Skip the next character as it's been processed.
        - If the value of the current character is equal to or greater than the next one (or if it's the last
          character), just add its value to `total`.

3. **Return the Result**: Once the iteration is complete, the total is returned.

> **Note**: This solution assumes that a valid Roman numeral is provided as input. A predefined dictionary is used to
> map Roman characters to their corresponding integer values.

## Time Complexity Analysis

The solution processes each character of the Roman numeral string exactly once. This results in the main loop's
complexity being **O(n)**, where `n` is the length of the input string. The operations within the loop, such as
dictionary lookups and basic arithmetic, are **O(1)** - constant time operations.

Overall, the time complexity of the solution is **O(n)**.

> **Note**: The dictionary used for Roman character-to-value mapping is designed to offer O(1) average time complexity
> for lookups. This ensures that the operations inside the loop remain constant time.

## Memory Analysis

1. **Constant Space**:
    - The `romanToValue` dictionary occupies constant space, as its size remains unchanged regardless of the input size.
    - Variables like `total`, `currentRomanCharacter`, `currentValue`, `nextRomanCharacter`, and `nextValue` all occupy
      constant space.

2. **Input Space**:
    - The main variable determining the input size is the `value` string, which represents the Roman numeral. Its size
      is denoted by `n`.

3. **Overhead**:
    - The for-loop and the associated logic within don't create any additional data structures that increase with the
      input size.

**Conclusion**:
The space complexity is mainly determined by the input string (`n`) and a constant amount for the dictionary and the
variables. This results in a space complexity of **O(n) + O(1)**, which simplifies to **O(n)**.
