# Mathematics Unity Script
Made by Asdonaur.

- You can use this code in any project you want, just give the creator some credit :)
- How to use: https://asdonaur.itch.io/asdoblog/devlog/281913/basic-calculations-mathematics-script

## Documentation
### Statics Methods
Average
```cs
// Gets the average between the array NUMBERS
public static float Average(float[] NUMBERS);
```
```cs
// Gets the average between the array NUMBERS
public static float Average(List<float> NUMBERS);
```
Percentage
```cs
///Calcule the porcentage
///Return the porcentage
public static float Percentage(float ENTIRE, float NUMBER);
```
Probabilities
```cs
///Randomly chooses a number between 1 and the variable BETWEEN.
///Returns true if the number got is equal or less than the variable PROB
public static bool Probability(int PROB = 1, int BETWEEN = 2);
```
Randoms
```cs
public static float Range(float ONE, float TWO = 0);
```