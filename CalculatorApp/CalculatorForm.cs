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
      input.Reverse();
      Stack<string> givenStack = new Stack<string>(input);
      List<string> tempList = new List<string>();
      List<string> outputList = new List<string>();
      bool startTempStore = false;
      float tempSum = 0;
      int count = givenStack.Count;

      while (givenStack.Count != 1)
      {
        for (int i = 0; i < count; i++)
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

          if (startTempStore)
            continue;

          outputList.Add(currVal);
          count = givenStack.Count;
        }
      }
      return "Hello";
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

    private void UpdateOutputDisplay()
    {
      ClearOutput();

      for (int i = 0; i < inputs.Count; i++)
      {
        outputTextBox.Text += inputs[i];
      }
    }

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
      inputs.Add("0");
      UpdateOutputDisplay();
    }

    private void oneBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("1");
      UpdateOutputDisplay();
    }

    private void twoBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("2");
      UpdateOutputDisplay();
    }

    private void threeBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("3");
      UpdateOutputDisplay();
    }

    private void fourBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("4");
      UpdateOutputDisplay();
    }

    private void fiveBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("5");
      UpdateOutputDisplay();
    }

    private void sixBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("6");
      UpdateOutputDisplay();
    }

    private void sevenBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("7");
      UpdateOutputDisplay();
    }

    private void eightBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("8");
      UpdateOutputDisplay();
    }

    private void nineBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("9");
      UpdateOutputDisplay();
    }

    private void leftBracketBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("(");
      UpdateOutputDisplay();
    }

    private void rightBracketBtn_Click(object sender, EventArgs e)
    {
      inputs.Add(")");
      UpdateOutputDisplay();
    }

    private void divisionBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("/");
      UpdateOutputDisplay();
    }

    private void multiplicationBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("*");
      UpdateOutputDisplay();
    }

    private void subtractionBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("-");
      UpdateOutputDisplay();
    }

    private void additionBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("+");
      UpdateOutputDisplay();
    }

    private void squareBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("^2");
      UpdateOutputDisplay();
    }

    private void squareRootBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("sqrt(");
      UpdateOutputDisplay();
    }

    private void exponentBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("^");
      UpdateOutputDisplay();
    }

    private void logBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("log");
      UpdateOutputDisplay();
    }

    private void lnBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("ln");
      UpdateOutputDisplay();
    }

    private void equalBtn_Click(object sender, EventArgs e)
    {
      string result = Calculate(inputs);
      ClearEverything();
      outputTextBox.Text = result;
    }

    private void shiftBtn_Click(object sender, EventArgs e)
    {

    }

    private void factorialBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("!");
      UpdateOutputDisplay();
    }

    private void piBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("pi");
      UpdateOutputDisplay();
    }

    private void eBtn_Click(object sender, EventArgs e)
    {
      inputs.Add("e");
      UpdateOutputDisplay();
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      ClearEverything();
    }

    private void backspaceBtn_Click(object sender, EventArgs e)
    {
      if (inputs.Count <= 0) return;

      int lastIndex = inputs.Count - 1;

      inputs.RemoveAt(lastIndex);
      UpdateOutputDisplay();
    }
  }
}
