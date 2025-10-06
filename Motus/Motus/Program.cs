using System;
using System.Collections.Generic;

string wordToFind = "APPLE";
string encodedWordToFind = "";
string playerAnswer;
int lives = 10;

void WordEncoder()
{
    encodedWordToFind = "";
    for (int i = 0; i < wordToFind.Length; i++)
    {
        encodedWordToFind += "_";
    }
}

void WordAnalizer(string answer)
{
    char[] temp = encodedWordToFind.ToCharArray();

    for (int i = 0; i < wordToFind.Length && i < answer.Length; i++)
    {
        if (wordToFind[i] == answer[i])
        {
            temp[i] = wordToFind[i];
        }
    }

    encodedWordToFind = new string(temp);
}

WordEncoder();

while (lives > 0 && encodedWordToFind.Contains("_"))
{
    Console.WriteLine($"Word: {encodedWordToFind}");
    Console.Write("Answer: ");
    playerAnswer = Console.ReadLine().ToUpper();

    if (playerAnswer == wordToFind)
    {
        encodedWordToFind = wordToFind;
        break;
    }
    else
    {
        WordAnalizer(playerAnswer);
        lives--;
        Console.WriteLine($"Lives: {lives}");
    }
}

if (encodedWordToFind == wordToFind)
    Console.WriteLine($"Victory! {wordToFind}");
else
    Console.WriteLine($"Defeat! {wordToFind}");
