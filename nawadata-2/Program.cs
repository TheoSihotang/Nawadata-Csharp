// See https://aka.ms/new-console-template for more information

using nawadata_2;

// no 1
SentenceLength sentenceLength = new SentenceLength();
sentenceLength.LengthOfSentence("Halo, nama saya john doe");

// no 2
FindMaxNumber findMaxNumber = new FindMaxNumber();
// cara pertama
findMaxNumber.FindMaxNumbers([21, 23, 25, 87, 25, 35]);

// cara kedua
findMaxNumber.FindNumbers([21, 23, 25, 87, 25, 35]);

// no 3
SortArray sortArray = new SortArray();

// cara pertama
sortArray.ArraySort([2,1,4,3,5]);
// cara kedua
sortArray.SortArrayWithLoop([2,1,4,3,5]);

// no 4

FindLetter findLetter = new FindLetter();
findLetter.Letter("katakk");