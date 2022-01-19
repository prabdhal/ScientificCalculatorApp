﻿using System;
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

    private string Calculate()
    {
      string response = null;
      string result = null;

      ConvertInput();

      if (ErrorChecks(out response))
        return response;

      string val = null;
      string nextVal = null;
      string prevVal = null;

      // Solve all exponents

      // Solve all brackets first
      // Solve all multiplication/division

      inputs.Reverse();
      
      Stack<string> leftToRightStack = new Stack<string>(inputs);
      Stack<string> rightToLeftStack = new Stack<string>();
      List<string> output = new List<string>(inputs);
      int count = leftToRightStack.Count;
      bool goNext = false;

      while (response == null)
      {
        leftToRightStack = new Stack<string>(output);
        rightToLeftStack.Clear();
        prevVal = null;
        count = leftToRightStack.Count;

        if (leftToRightStack.Contains("*") || leftToRightStack.Contains("/"))
        {
          for (int i = 0; i < count; i++)
          {
            val = leftToRightStack.Pop();

            if (i == count - 1)
            {
              rightToLeftStack.Push(val);
              output.Clear();
              output = new List<string>(rightToLeftStack);
              count = output.Count;
              rightToLeftStack.Clear();
              continue;
            }
            if (rightToLeftStack.Count > 0)
              prevVal = rightToLeftStack.Peek();
            if (leftToRightStack.Count > 0)
              nextVal = leftToRightStack.Peek();

            if (val == "*" && IsNumber(nextVal) && prevVal == ")")
            {
              goNext = true;
              rightToLeftStack.Push(val);
            }
            else if (val == "*" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              if (goNext)
              {
                goNext = false;
                continue;
              }

              string nextValPop = leftToRightStack.Pop();   // pop out number besides the operator * or /

              if (i + 3 < count)
              {
                string checkForOperator = leftToRightStack.Peek();  // check if there is an operator next
                if (checkForOperator == "*" || checkForOperator == "/" || checkForOperator == "+" || checkForOperator == "-")
                {
                  string storeOperator = leftToRightStack.Pop();  // pop the operator

                  if (leftToRightStack.Peek() == "(")   // check if there is a bracket next
                  {
                    // push everything back to normal and skip the calculation part
                    leftToRightStack.Push(storeOperator);
                    leftToRightStack.Push(nextVal);
                    rightToLeftStack.Push(val);
                    continue;
                  }

                  leftToRightStack.Push(storeOperator);
                }
              }

              string sum = (float.Parse(rightToLeftStack.Pop()) * float.Parse(nextValPop)).ToString();
              rightToLeftStack.Push(sum);
              i++;

              if (i == count - 1)
              {
                output.Clear();
                output = new List<string>(rightToLeftStack);
                count = output.Count;
                rightToLeftStack.Clear();
                continue;
              }
            }
            else if (val == "/" && IsNumber(nextVal) && prevVal == ")")
            {
              goNext = true;
              rightToLeftStack.Push(val);
            }
            else if (val == "/" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              if (goNext)
              {
                goNext = false;
                continue;
              }

              string nextValPop = leftToRightStack.Pop();   // pop out number besides the operator * or /

              if (i + 3 < count)
              {
                string checkForOperator = leftToRightStack.Peek();  // check if there is an operator next
                if (checkForOperator == "*" || checkForOperator == "/" || checkForOperator == "+" || checkForOperator == "-")
                {
                  string storeOperator = leftToRightStack.Pop();  // pop the operator

                  if (leftToRightStack.Peek() == "(")   // check if there is a bracket next
                  {
                    // push everything back to normal and skip the calculation part
                    leftToRightStack.Push(storeOperator);
                    leftToRightStack.Push(nextVal);
                    rightToLeftStack.Push(val);
                    continue;
                  }

                  leftToRightStack.Push(storeOperator);
                }
              }

              string sum = (float.Parse(rightToLeftStack.Pop()) / float.Parse(nextValPop)).ToString();
              rightToLeftStack.Push(sum);
              i++;

              if (i == count - 1)
              {
                output.Clear();
                output = new List<string>(rightToLeftStack);
                count = output.Count;
                rightToLeftStack.Clear();
                continue;
              }
            }
            else
              rightToLeftStack.Push(val);
          }
        }

        leftToRightStack = new Stack<string>(output);
        prevVal = null;
        goNext = false;
        // Solve all addition/subtraction
        if (leftToRightStack.Contains("+") || leftToRightStack.Contains("-"))
        {
          for (int i = 0; i < count; i++)
          {
            val = leftToRightStack.Pop();

            if (i == count - 1)
            {
              rightToLeftStack.Push(val);
              output.Clear();
              output = new List<string>(rightToLeftStack);
              count = output.Count;
              rightToLeftStack.Clear();
              continue;
            }
            if (rightToLeftStack.Count > 0)
              prevVal = rightToLeftStack.Peek();
            if (leftToRightStack.Count > 0)
              nextVal = leftToRightStack.Peek();

            if (val == "+" && IsNumber(nextVal) && prevVal == ")")
            {
              goNext = true;
              rightToLeftStack.Push(val);
            }
            else if (val == "+" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              if (goNext)
              {
                goNext = false;
                continue;
              }

              string nextValPop = leftToRightStack.Pop();   // pop out number besides the operator * or /

              if (i + 3 < count)
              {
                string checkForOperator = leftToRightStack.Peek();  // check if there is an operator next
                if (checkForOperator == "*" || checkForOperator == "/" || checkForOperator == "+" || checkForOperator == "-")
                {
                  string storeOperator = leftToRightStack.Pop();  // pop the operator

                  if (leftToRightStack.Peek() == "(")   // check if there is a bracket next
                  {
                    // push everything back to normal and skip the calculation part
                    leftToRightStack.Push(storeOperator);
                    leftToRightStack.Push(nextVal);
                    rightToLeftStack.Push(val);
                    continue;
                  }

                  leftToRightStack.Push(storeOperator);
                }
              }

              string sum = (float.Parse(rightToLeftStack.Pop()) + float.Parse(nextValPop)).ToString();
              rightToLeftStack.Push(sum);
              i++;

              if (i == count - 1)
              {
                output.Clear();
                output = new List<string>(rightToLeftStack);
                count = output.Count;
                rightToLeftStack.Clear();
                continue;
              }
            }
            else if (val == "-" && IsNumber(nextVal) && prevVal == ")")
            {
              goNext = true;
              rightToLeftStack.Push(val);
            }
            else if (val == "-" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              if (goNext)
              {
                goNext = false;
                continue;
              }

              string nextValPop = leftToRightStack.Pop();   // pop out number besides the operator * or /

              if (i + 3 < count)
              {
                string checkForOperator = leftToRightStack.Peek();  // check if there is an operator next
                if (checkForOperator == "*" || checkForOperator == "/" || checkForOperator == "+" || checkForOperator == "-")
                {
                  string storeOperator = leftToRightStack.Pop();  // pop the operator

                  if (leftToRightStack.Peek() == "(")   // check if there is a bracket next
                  {
                    // push everything back to normal and skip the calculation part
                    leftToRightStack.Push(storeOperator);
                    leftToRightStack.Push(nextVal);
                    rightToLeftStack.Push(val);
                    continue;
                  }

                  leftToRightStack.Push(storeOperator);
                }
              }

              string sum = (float.Parse(rightToLeftStack.Pop()) - float.Parse(nextValPop)).ToString();
              rightToLeftStack.Push(sum);
              i++;

              if (i == count - 1)
              {
                output.Clear();
                rightToLeftStack.Reverse();
                output = new List<string>(rightToLeftStack);
                count = output.Count;
                rightToLeftStack.Clear();
                continue;
              }
            }
            else
              rightToLeftStack.Push(val);

          }
          // 11 + (15) + 72
        }

        // Remove Excess Brackets
        leftToRightStack = new Stack<string>(output);
        output.Clear();
        List<string> check = new List<string>(leftToRightStack);
        count = check.Count;
        goNext = false;

        for (int i = 0; i < check.Count; i++)
        {
          if (i < check.Count - 1 && i > 0)
          {
            if (check[i - 1] == "(" && IsNumber(check[i]) && check[i + 1] == ")")
            {
              output.RemoveAt(output.Count - 1);
              output.Add(check[i]);
              i++;
              continue;
            }
          }

          output.Add(check[i]);          
        }
        output.Reverse();

        if (output.Count == 1)
          response = output[0];
      }
      

      // Solve all within brackets 
      // 1+((8-6*9)+3*2-1)+2*(1+1-3)
      // 1+((8-54)+6-1)+2*(1+1-3) < multi/div forloop
      // 1+(-39)+2*(-1)


      Console.WriteLine("OK");
      return response;
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
      string result = Calculate();
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
