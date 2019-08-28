using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionSort : MonoBehaviour
{
    public Text inputText;
    public Text outPutText;
    public string[] GetInputNumberArray(Text inputText)
    {
        string inputNumber;
        string[] inputNumberArray;

        inputNumber = inputText.text;
        inputNumberArray = inputNumber.Split(' ');

        return inputNumberArray;
    }

    public string[] Selection_Sort()
    {
        string[] outPutNumber;
        string[] inputNumberArray = GetInputNumberArray(inputText);

        for(int i=0;i<inputNumberArray.Length;i++)
        {
            int minIndex = i;
            string temp;
            
            for(int j=i+1;j<inputNumberArray.Length;j++)
            {
                if (string.Compare(inputNumberArray[minIndex], inputNumberArray[j]) > 0)
                {
                    minIndex = j;
                }            
            }
            temp = inputNumberArray[minIndex];
            inputNumberArray[minIndex] = inputNumberArray[i];
            inputNumberArray[i] = temp;
        }

        outPutNumber = (string[])inputNumberArray.Clone();

        return outPutNumber;
    }

    public void Output()
    {
        string[] outPutNmber = Selection_Sort();
        outPutText.text = string.Join(" ", outPutNmber);
        
        
    }
}
