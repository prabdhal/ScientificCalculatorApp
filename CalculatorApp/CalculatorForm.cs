using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalculatorApp
{
  public partial class calculatorForm : Form
  {
    private List<string> inputs = new List<string>();

    public calculatorForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Performs a complete calculation on the inputted values.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private string Calculate(List<string> input)
    {
      if (ErrorChecks(out string error))
        return error;

      input.Reverse();
      Stack<string> givenStack = new Stack<string>(input);
      
      List<string> outputList = new List<string>();
      List<string> tempList = new List<string>();
      
      int mainCount = givenStack.Count;

      bool startTempStore = false;
      bool noBrackets = false;

      while (givenStack.Count != 1)
      {
        // Check if input has any brackets
        if (NumberOfParenthesesPairs(new List<string>(givenStack)) <= 0)
          noBrackets = true;

        for (int i = 0; i < mainCount; i++)
        {
          string currVal = givenStack.Pop();

          // Initiates storing of values within parentheses
          if (currVal == "(")
          {
            startTempStore = true;

            // Adds all the values within the parentheses (including the parentheses)
            // into outputList to be calculated
            if (tempList.Count > 0)
            {
              for (int j = 0; j < tempList.Count; j++)
              {
                outputList.Add(tempList[j]);
              }
              tempList.Clear();
            }
          }

          // Stores all values within the parentheses (including the parentheses)
          if (startTempStore)
            tempList.Add(currVal);

          // Begins calculation of values within the parentheses
          if (currVal == ")" && startTempStore)
          {
            startTempStore = false;

            // Stores values in a stack and creates an empty stack
            List<string> list = new List<string>(tempList);

            // First do multiplication and division
            Stack<string> firstOutput = ApplyMultiplicationOrDivision(list);

            // Secondly do addition and subtraction
            Stack<string> finalOutput = ApplyAdditionOrSubtraction(firstOutput.ToList());

            // finished calculating the temp list (within bracket calculations)
            tempList.Clear();
            
            // Return the final result
            currVal = finalOutput.Pop();
          }
          else if (noBrackets)
          {
            givenStack.Push(currVal);

            List<string> list = new List<string>(givenStack);

            // First do multiplication and division
            Stack<string> firstOutput = ApplyMultiplicationOrDivision(list);

            // Secondly do addition and subtraction
            Stack<string> finalOutput = ApplyAdditionOrSubtraction(firstOutput.ToList());

            // Return the final result
            return finalOutput.Pop();
          }

          if (startTempStore)
            continue;

          outputList.Add(currVal);
        }

        outputList.Reverse();
        givenStack = new Stack<string>(outputList);
        mainCount = givenStack.Count;
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
    private int NumberOfParenthesesPairs(List<string> inputs)
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

    /// <summary>
    /// Outputs any errors due to invalid entries.
    /// </summary>
    /// <param name="error"></param>
    /// <returns></returns>
    private bool ErrorChecks(out string error)
    {
      error = null;
      if (inputs.Count <= 0) return true;
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
    /// Returns the stack of string values remaining after performing multiplication/division.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private Stack<string> ApplyMultiplicationOrDivision(List<string> input)
    {
      // Stores values in a stack and creates an empty stack
      input.Reverse();
      Stack<string> inputStack = new Stack<string>(input);
      Stack<string> outputStack = new Stack<string>();
      int count = inputStack.Count;
      string currVal;
      string nextVal;
      string prevVal;
      float sum;

      for (int j = 0; j < count; j++)
      {
        currVal = inputStack.Pop();

        // always will hit this code block!!!!
        if (currVal == "(" || currVal == ")")
        {
          if (currVal == "(")
            continue;

          return outputStack;
        }

        if (currVal == "*" || currVal == "/")
        {
          prevVal = outputStack.Pop();
          nextVal = inputStack.Pop();

          if (currVal == "*")
            sum = float.Parse(prevVal) * float.Parse(nextVal);
          else
            sum = float.Parse(prevVal) / float.Parse(nextVal);

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }

        outputStack.Push(currVal);
      }

      return outputStack;
    }

    /// <summary>
    /// Returns the stack of string values remaining after performing addition/subtraction.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private Stack<string> ApplyAdditionOrSubtraction(List<string> input)
    {
      Stack<string> inputStack = new Stack<string>(input);
      Stack<string> outputStack = new Stack<string>();
      int count = inputStack.Count;
      string currVal;
      string nextVal;
      string prevVal;
      float sum;

      for (int j = 0; j < count; j++)
      {
        currVal = inputStack.Pop();

        // always will hit this code block!!!!
        if (currVal == "(" || currVal == ")")
        {
          if (currVal == "(")
            continue;

          return outputStack;
        }

        if (currVal == "+" || currVal == "-")
        {
          if (outputStack.Count <= 0 || inputStack.Count <= 0)
          {
            outputStack.Push(currVal);
            continue;
          }

          prevVal = outputStack.Pop();
          nextVal = inputStack.Pop();

          if (currVal == "+")
            sum = float.Parse(prevVal) + float.Parse(nextVal);
          else
            sum = float.Parse(prevVal) - float.Parse(nextVal);

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }

        outputStack.Push(currVal);
      }

      return outputStack;
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
      string fragment = null;

      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] == '+' || input[i] == '-' || input[i] == '/' || input[i] == '*' || input[i] == '(' || input[i] == ')' || input[i] == '^')
        {
          if (fragment != null && fragment != "")
            result.Add(fragment);
          fragment = null;

          result.Add(input[i].ToString());
          continue;
        }

        fragment += input[i];
      }

      if (fragment != null && fragment != "")
        result.Add(fragment);
      return result;
    }

    /// <summary>
    /// Clears the inputs list and the values displayed on the calculator.
    /// </summary>
    private void ClearOutput()
    {
      outputTextBox.Text = "";
      inputs.Clear();
    }

    #region Helper Methods
    /// <summary>
    /// Returns true if the given string value is a number.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private bool IsNumber(string input)
    {
      return float.TryParse(input, out float r);
    }
    #endregion

    #region OnClick Events
    private void equalBtn_Click(object sender, EventArgs e)
    {
      string inputText = outputTextBox.Text;
      if (inputText.Length <= 0) return;

      string result = Calculate(SplitInput(inputText));

      ClearOutput();
      inputs.Add(result);
      outputTextBox.Text = result;
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
      ClearOutput();
    }
    private void periodBtn_Click(object sender, EventArgs e)
    {
      outputTextBox.Text += ".";
      inputs.Add(".");
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
    #endregion

  }
}
