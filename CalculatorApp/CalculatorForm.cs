using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorApp
{
  public partial class calculatorForm : Form
  {
    private List<string> inputs = new List<string>();
    private List<string> convertedInput = new List<string>();

    public calculatorForm()
    {
      InitializeComponent();
    }

    private string Calculate(List<string> input)
    {
      input = SplitInput(outputTextBox.Text);

      input.Reverse();
      Stack<string> givenStack = new Stack<string>(input);
      List<string> tempList = new List<string>();
      List<string> outputList = new List<string>();
      List<string> answerList = new List<string>();
      bool startTempStore = false;
      float tempSum = 0;
      int mainCount = givenStack.Count;
      int count = givenStack.Count;
      bool noBrackets = false;
      string ans = null;

      while (givenStack.Count != 1)
      {
        if (NumberOfParanthesisPairs(new List<string>(givenStack)) <= 0)
          noBrackets = true;

        for (int i = 0; i < mainCount; i++)
        {
          string currVal = givenStack.Pop();

          if (currVal == "(")
          {
            startTempStore = true;
            if (tempList.Count > 0)
            {
              for (int j = 0; j < tempList.Count; j++)
              {
                outputList.Add(tempList[j]);
                answerList.Add(tempList[j]);
              }
              tempList.Clear();
            }
          }

          if (startTempStore)
            tempList.Add(currVal);

          if (currVal == ")" && startTempStore)
          {
            startTempStore = false;

            tempList.Reverse();
            Stack<string> tempListStack = new Stack<string>(tempList);
            Stack<string> outputStack = new Stack<string>();
            count = tempListStack.Count;
            string prevVal = null;
            string nextVal = null;

            for (int j = 0; j < count; j++)
            {
              currVal = tempListStack.Pop();

              if (currVal == "(")
                continue;

              if (currVal == ")")
              {
                tempListStack.Clear();
                tempListStack = new Stack<string>(outputStack);
                tempListStack.Reverse();
                outputStack.Clear();
                count = tempListStack.Count;
                continue;
              }

              if (currVal == "*")
              {
                prevVal = outputStack.Pop();
                nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) * int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }
              else if (currVal == "/")
              {
                prevVal = outputStack.Pop();
                nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) / int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }

              outputStack.Push(currVal);
            }

            outputStack.Reverse();
            outputStack.Clear();

            for (int j = 0; j < count; j++)
            {
              currVal = tempListStack.Pop();

              if (currVal == "(")
                continue;

              if (currVal == ")")
              {
                tempListStack.Clear();
                tempListStack = new Stack<string>(outputStack);
                tempListStack.Reverse();
                outputStack.Clear();
                count = tempListStack.Count;
                continue;
              }

              if (currVal == "+")
              {
                prevVal = outputStack.Pop();
                nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) + int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }
              else if (currVal == "-")
              {
                prevVal = outputStack.Pop();
                nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) - int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }

              outputStack.Push(currVal);
            }

            tempList.Clear();
            currVal = outputStack.Pop();
          }
          else if (noBrackets)
          {
            givenStack.Push(currVal);
            List<string> list = new List<string>(givenStack);
            list.Reverse();
            Stack<string> tempListStack = new Stack<string>(list);
            Stack<string> outputStack = new Stack<string>();
            count = tempListStack.Count;

            for (int j = 0; j < count; j++)
            {
              currVal = tempListStack.Pop();

              if (currVal == "*")
              {
                string prevVal = outputStack.Pop();
                string nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) * int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }
              else if (currVal == "/")
              {
                string prevVal = outputStack.Pop();
                string nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) / int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }

              outputStack.Push(currVal);
            }
            givenStack = new Stack<string>(outputStack);
            list = new List<string>(givenStack);
            list.Reverse();
            tempListStack = new Stack<string>(list);
            count = tempListStack.Count;
            outputStack.Clear();

            for (int j = 0; j < count; j++)
            {
              currVal = tempListStack.Pop();

              if (currVal == "+")
              {
                string prevVal = outputStack.Pop();
                string nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) + int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }
              else if (currVal == "-")
              {
                string prevVal = outputStack.Pop();
                string nextVal = tempListStack.Pop();

                tempSum = int.Parse(prevVal) - int.Parse(nextVal);
                outputStack.Push(tempSum.ToString());
                j++;
                continue;
              }

              outputStack.Push(currVal);
            }

            return outputStack.Pop();
          }
          

          if (startTempStore)
            continue;

          outputList.Add(currVal);
          answerList.Add(currVal);
        }
        outputList.Reverse();
        givenStack = new Stack<string>(outputList);
        mainCount = givenStack.Count;
        answerList.Clear();
        outputList.Clear();
      }

      return givenStack.Pop();
    }

    /// <summary>
    /// Returns the number of paranthesis pairs as an int value within the given string values. 
    /// Returns Format Error if there is not a closing tag for each opening tag.
    /// </summary>
    /// <param name="inputs"></param>
    /// <returns></returns>
    private int NumberOfParanthesisPairs(List<string> inputs)
    {
      // Check if there are even amounts of "(" and ")" 
      if (inputs.Contains("(") && inputs.Contains(")"))
      {
        int openParaCount = inputs.FindAll(p => p == "(").Count;
        int closeParaCont = inputs.FindAll(p => p == ")").Count;

        if (openParaCount == closeParaCont)
        {
          Console.WriteLine("Paranthesis Pairs Count: " + openParaCount);
          return openParaCount;
        }
        else
          throw new FormatException("Each opening paranthesis should be closed with the closing paranthesis!");
      }
      else
        return 0;
    }

    private bool ErrorChecks(out string error)
    {
      error = null;
      if (inputs.Count <= 0) return true;
      if (IsNumber(inputs[0]) == false)
      {
        error = "Format Error - first input cannot be a non-number";
        return true;
      }
      if (inputs.Contains("(") || inputs.Contains(")"))
      {
        if (inputs.FindAll(x => x == "(").Count != inputs.FindAll(x => x == ")").Count)
        {
          error = "Format Error - missing bracket";
          return true;
        }
      }


      return false;
    }

    /// <summary>
    /// Returns the inputted values as fragments which can then be calculated.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private List<string> SplitInput(string input)
    {
      if (input.Length <= 0)
        return null;

      List<string> result = new List<string>();
      string fragment = "";

      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] == '+' || input[i] == '-' || input[i] == '/' || input[i] == '*' || input[i] == '(' || input[i] == ')' || input[i] == '^')
        {
          result.Add(fragment);
          result.Add(input[i].ToString());
          fragment = "";
          continue;
        }

        fragment += input[i];
      }

      result.Add(fragment);
      return result;
    }

    /// <summary>
    /// Returns true if the given string value is a number.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private bool IsNumber(string input)
    {
      return float.TryParse(input, out float r);
    }

    /// <summary>
    /// Merges consecutive single string numbers into one string number value.
    /// </summary>
    private void ConvertInput()
    {
      string currVal = "";
      bool canInput = false;

      for (int i = 0; i < inputs.Count; i++)
      {
        bool canParse = int.TryParse(inputs[i], out int num);

        if (canParse)
        {
          currVal += num.ToString();
          canInput = true;
        }
        else if (!canParse)
        {
          convertedInput.Add(currVal);
          convertedInput.Add(inputs[i]);
          currVal = "";
          canInput = false;
        }
        else
          Console.Error.WriteLine("Error input... can't have more than one symbol next to eachother.");
      }

      convertedInput.Add(currVal);
    }

    private string Addition(float valOne, float valTwo)
    {
      return (valOne + valTwo).ToString();
    }

    private string Addition(string valOne, string valTwo)
    {
      return valOne + valTwo;
    }

    private void Substraction()
    {

    }

    private void Division()
    {

    }

    private void Multiplication()
    {

    }

    //private void UpdateOutputDisplay()
    //{
    //  ClearOutput();

    //  for (int i = 0; i < inputs.Count; i++)
    //  {
    //    outputTextBox.Text += inputs[i];
    //  }
    //}

    private void ClearOutput()
    {
      outputTextBox.Text = "";
    }

    private void ClearEverything()
    {
      ClearOutput();
      inputs.Clear();
    }

    private void zeroBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "0";
      inputs.Add("0");
    }

    private void oneBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "1";
      inputs.Add("1");
    }

    private void twoBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "2";
      inputs.Add("2");
    }

    private void threeBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "3";
      inputs.Add("3");
    }

    private void fourBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "4";
      inputs.Add("4");
    }

    private void fiveBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "5";
      inputs.Add("5");
    }

    private void sixBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "6";
      inputs.Add("6");
    }

    private void sevenBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "7";
      inputs.Add("7");
    }

    private void eightBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "8";
      inputs.Add("8");
    }

    private void nineBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "9";
      inputs.Add("9");
    }

    private void leftBracketBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "(";
      inputs.Add("(");
    }

    private void rightBracketBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += ")";
      inputs.Add(")");
    }

    private void divisionBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "/";
      inputs.Add("/");
    }

    private void multiplicationBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "*";
      inputs.Add("*");
    }

    private void subtractionBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "-";
      inputs.Add("-");
    }

    private void additionBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "+";
      inputs.Add("+");
    }

    private void squareBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "^2";
      inputs.Add("^2");
    }

    private void squareRootBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "sqrt(";
      inputs.Add("sqrt(");
    }

    private void exponentBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "^";
      inputs.Add("^");
    }

    private void logBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "log";
      inputs.Add("log");
    }

    private void lnBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "ln";
      inputs.Add("ln");
    }

    private void equalBtn_Click(object sender, EventArgs e)
    {
      string result = Calculate(inputs);
      ClearEverything();
      inputs.Add(result);
      outputTextBox.Text = result;
    }

    private void shiftBtn_Click(object sender, EventArgs e)
    {

    }

    private void factorialBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "!";
      inputs.Add("!");
    }

    private void piBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "pi";
      inputs.Add("pi");
    }

    private void eBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += "e";
      inputs.Add("e");
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      ClearEverything();
    }

    private void backspaceBtn_Click(object sender, EventArgs e)
    {
      if (inputs.Count <= 0) return;

      inputs.RemoveAt(inputs.Count - 1);
      outputTextBox.Text = "";

      for (int i = 0; i < inputs.Count; i++)
      {
        outputTextBox.Text += inputs[i];
      }
    }
  }
}
