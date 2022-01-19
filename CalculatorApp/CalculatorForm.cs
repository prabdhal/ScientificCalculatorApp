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

      Stack<string> leftToRightStack = new Stack<string>(inputs);
      Stack<string> rightToLeftStack = new Stack<string>();
      List<string> dummy = new List<string>();
      int count = leftToRightStack.Count;

      while (response == null)
      {
        if (dummy.Count > 1)
        {
          leftToRightStack = new Stack<string>(dummy);
          rightToLeftStack.Clear();
          prevVal = null;
          count = leftToRightStack.Count;
        }

        if (leftToRightStack.Contains("*") || leftToRightStack.Contains("/"))
        {
          for (int i = 0; i < count; i++)
          {
            val = leftToRightStack.Pop();

            if (i == count - 1)
            {
              rightToLeftStack.Push(val);
              continue;
            }
            if (rightToLeftStack.Count > 0)
              prevVal = rightToLeftStack.Peek();
            nextVal = leftToRightStack.Peek();

            if (val == "*" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              string sum = (float.Parse(leftToRightStack.Pop()) * float.Parse(rightToLeftStack.Pop())).ToString();
              rightToLeftStack.Push(sum);
              i++;
            }
            else if (val == "/" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              string sum = (float.Parse(leftToRightStack.Pop()) / float.Parse(rightToLeftStack.Pop())).ToString();
              rightToLeftStack.Push(sum);
              i++;
            }
            else
              rightToLeftStack.Push(val);
          }
        }

        if (rightToLeftStack.Count > 0 && leftToRightStack.Count <= 0)
          leftToRightStack = new Stack<string>(rightToLeftStack);
        else if (dummy.Count > 0)
          leftToRightStack = new Stack<string>(dummy);
        rightToLeftStack.Clear();
        count = leftToRightStack.Count;
        prevVal = null;
        // Solve all addition/subtraction
        if (leftToRightStack.Contains("+") || leftToRightStack.Contains("-"))
        {
          for (int i = 0; i < count; i++)
          {
            val = leftToRightStack.Pop();

            if (i == count - 1)
            {
              rightToLeftStack.Push(val);
              continue;
            }
            if (rightToLeftStack.Count > 0)
              prevVal = rightToLeftStack.Peek();
            nextVal = leftToRightStack.Peek();

            if (val == "+" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              string sum = (float.Parse(leftToRightStack.Pop()) + float.Parse(rightToLeftStack.Pop())).ToString();
              rightToLeftStack.Push(sum);
              i++;
            }
            else if (val == "-" && IsNumber(nextVal) && IsNumber(prevVal))
            {
              string sum = (float.Parse(leftToRightStack.Pop()) - float.Parse(rightToLeftStack.Pop())).ToString();
              rightToLeftStack.Push(sum);
              i++;
            }
            else
              rightToLeftStack.Push(val);

          }
          // 11 + (15) + 72
        }

        // Remove Excess Brackets
        List<string> check = new List<string>(rightToLeftStack);
        count = check.Count;
        dummy.Clear();
        bool removedBrackey = false;

        for (int i = 0; i < check.Count; i++)
        {
          if (i < check.Count - 1 && i > 0)
          {
            if (check[i - 1] == "(" && IsNumber(check[i]) && check[i + 1] == ")")
            {
              dummy.RemoveAt(dummy.Count - 1);
              dummy.Add(check[i]);
              i++;
              continue;
            }
          }

          dummy.Add(check[i]);          
        }

        if (dummy.Count == 1)
          response = dummy[0];
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
        else if (!canParse && canInput)
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
