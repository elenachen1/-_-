/*
Задача. 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
*/

using System;
using static System.Console;

Clear();

string[] array = Array();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int n) {
    string[] output = new string[Count(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int Count(string[] input, int n) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}

string[] Array() {
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}