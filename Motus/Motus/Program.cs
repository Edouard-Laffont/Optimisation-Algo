// See https://aka.ms/new-console-template for more information

Console.WriteLine("TEST");

string wordToFind = "APPLE";
string playerAnswer;
string encodedWordToFind;

int lives = 10;
int rightCharacters;

List<char> answerCharacterList = new List<char>();

void WordEncoder()
{
    for (int i = 0; i < encodedWordToFind.Length; i++)
    {
        encodedWordToFind.Replace(encodedWordToFind[i], '_');
    }
}
void AnswerReader()
{
    playerAnswer = Console.ReadLine();
    foreach (char c in playerAnswer)
    {
        answerCharacterList.Add(c);
    }
    WordAnalizer(wordToFind);
    
}

void WordAnalizer(string _wordToAnalyze)
{
    for (int i = 0; i < _wordToAnalyze.Length; i++)
    {
        if (_wordToAnalyze[i] == answerCharacterList[i])
        {
            rightCharacters++;
            encodedWordToFind.Replace(encodedWordToFind[i], _wordToAnalyze[i]);
        }
    }

    if (rightCharacters > wordToFind.Length)
    {
        Console.WriteLine($"{_wordToAnalyze} is right");
    }
    rightCharacters = 0;
}