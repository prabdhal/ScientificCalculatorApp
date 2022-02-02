﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorApp
{
  public partial class calculatorForm : MaterialForm
  {
    private List<string> inputs = new List<string>();
    private string inputText;
    private List<string> splitInputs = new List<string>();
    private List<string> ansHistory = new List<string>();

    private string piValue = "3.141592653589793238";
    private string eValue = "2.718281828459045235";

    bool isInverse = false;
    bool isRad = true;
    bool errorCode = false;

    public calculatorForm()
    {
      InitializeComponent();

      var materialSkinManager = MaterialSkinManager.Instance;
      materialSkinManager.AddFormToManage(this);
      materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
      materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
    }

    /// <summary>
    /// Performs a complete calculation on the inputted values.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private string Calculate(List<string> input)
    {
      if (SecondaryErrorChecks(out string error))
      {
        inputTextBox.Text = error;
        return null;
      }

      input.Reverse();
      Stack<string> givenStack = new Stack<string>(input);

      PrepareCalculationHistory(input);

      List<string> outputList = new List<string>();
      List<string> tempList = new List<string>();

      int mainCount = givenStack.Count;

      bool startTempStore = false;
      bool noBrackets = false;

      if (givenStack.Count == 1 && givenStack.Peek() == "ans" && ansHistory.Count > 0)
        return ansHistory[ansHistory.Count - 1];

      while (givenStack.Count != 1 || givenStack.Peek().EndsWith('!') == true)
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
            // Stores values in a stack and creates an empty stack
            startTempStore = false;
            List<string> list = new List<string>(tempList);

            // First, do exponent calculation
            Stack<string> firstOutput = ApplyLogAndLn(list.ToList());
            // Secondly, do logarithms and ln 
            Stack<string> secondOutput = ApplyExponentOrSquareRoot(firstOutput.ToList());
            // Thirdly, do cosine, sine and tangent
            Stack<string> thirdOutput = ApplyCosSinTan(secondOutput.ToList());
            // Fourthly, do multiplication and division
            Stack<string> fourthOutput = ApplyMultiplicationOrDivision(thirdOutput.ToList());
            // Finally, do addition and subtraction
            Stack<string> finalOutput = ApplyAdditionOrSubtraction(fourthOutput.ToList());

            // finished calculating the temp list (within bracket calculations)
            tempList.Clear();

            // Return the final result
            currVal = finalOutput.Pop();
          }
          else if (noBrackets)
          {
            givenStack.Push(currVal);
            List<string> list = new List<string>(givenStack);

            // First, do exponent calculation
            Stack<string> firstOutput = ApplyLogAndLn(list.ToList());
            // Secondly, do logarithms and ln 
            Stack<string> secondOutput = ApplyExponentOrSquareRoot(firstOutput.ToList());
            // Thirdly, do cosine, sine and tangent
            Stack<string> thirdOutput = ApplyCosSinTan(secondOutput.ToList());
            // Fourthly, do multiplication and division
            Stack<string> fourthOutput = ApplyMultiplicationOrDivision(thirdOutput.ToList());
            // Finally, do addition and subtraction
            Stack<string> finalOutput = ApplyAdditionOrSubtraction(fourthOutput.ToList());

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
      double sum;

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
            sum = double.Parse(prevVal) + double.Parse(nextVal);
          else
            sum = double.Parse(prevVal) - double.Parse(nextVal);

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }

        outputStack.Push(currVal);
      }

      return outputStack;
    }

    /// <summary>
    /// Returns the stack of string values remaining after performing multiplication/division.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private Stack<string> ApplyMultiplicationOrDivision(List<string> input)
    {
      // Stores values in a stack and creates an empty stack
      Stack<string> inputStack = new Stack<string>(input);
      Stack<string> outputStack = new Stack<string>();
      int count = inputStack.Count;
      string currVal;
      string nextVal;
      string prevVal;
      double sum;

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

          if (prevVal.EndsWith('!'))
            prevVal = ApplyFactorialCalculation(prevVal).ToString();
          if (nextVal.EndsWith('!'))
            nextVal = ApplyFactorialCalculation(nextVal).ToString();

          if (currVal == "*")
            sum = double.Parse(prevVal) * double.Parse(nextVal);
          else
            sum = double.Parse(prevVal) / double.Parse(nextVal);

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }
        else if (currVal.EndsWith('!'))
        {
          sum = ApplyFactorialCalculation(currVal);

          outputStack.Push(sum.ToString());
          continue;
        }

        outputStack.Push(currVal);
      }

      return outputStack;
    }

    /// <summary>
    /// Returns the stack of string values remaining after performing log and ln.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private Stack<string> ApplyLogAndLn(List<string> input)
    {
      ApplyPercentage(input);

      // Stores values in a stack and creates an empty stack
      input.Reverse();
      Stack<string> inputStack = new Stack<string>(input);
      Stack<string> outputStack = new Stack<string>();
      int count = inputStack.Count;
      string currVal;
      string nextVal;
      double sum;

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

        if (currVal == "log" || currVal == "ln")
        {
          nextVal = inputStack.Pop();

          if (currVal == "log")
            sum = Math.Log10(double.Parse(nextVal));
          else
            sum = Math.Log(double.Parse(nextVal));

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }

        outputStack.Push(currVal);
      }

      return outputStack;
    }

    /// <summary>
    /// Returns the stack of string values remaining after performing cos, sin and tan calculations.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private Stack<string> ApplyCosSinTan(List<string> input)
    {
      // Stores values in a stack and creates an empty stack
      Stack<string> inputStack = new Stack<string>(input);
      Stack<string> outputStack = new Stack<string>();
      int count = inputStack.Count;
      string currVal;
      string nextVal;
      double sum;

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

        if (currVal == "sin" || currVal == "cos" || currVal == "tan" ||
          currVal == "arcsin" || currVal == "arccos" || currVal == "arctan")
        {
          nextVal = inputStack.Pop();

          if (nextVal.EndsWith('!'))
            nextVal = ApplyFactorialCalculation(nextVal).ToString();

          if (currVal == "sin")
            sum = MathF.Sin(float.Parse(nextVal));
          else if (currVal == "cos")
            sum = MathF.Cos(float.Parse(nextVal));
          else if (currVal == "tan")
            sum = MathF.Tan(float.Parse(nextVal));
          else if (currVal == "arcsin")
            sum = MathF.Asin(float.Parse(nextVal));
          else if (currVal == "arccos")
            sum = MathF.Acos(float.Parse(nextVal));
          else
            sum = MathF.Atan(float.Parse(nextVal));

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }

        outputStack.Push(currVal);
      }

      return outputStack;
    }

    /// <summary>
    /// Returns the stack of string values remaining after performing exponent calculations.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private Stack<string> ApplyExponentOrSquareRoot(List<string> input)
    {
      // Stores values in a stack and creates an empty stack
      Stack<string> inputStack = new Stack<string>(input);
      Stack<string> outputStack = new Stack<string>();
      int count = inputStack.Count;
      string currVal;
      string nextVal;
      string prevVal;
      double sum;

      for (int j = 0; j < count; j++)
      {
        currVal = inputStack.Pop();

        if (currVal == "ans" && ansHistory.Count > 0)
          currVal = ansHistory[ansHistory.Count - 1];

        // always will hit this code block!!!!
        if (currVal == "(" || currVal == ")")
        {
          if (currVal == "(")
            continue;

          return outputStack;
        }

        if (currVal == "^")
        {
          prevVal = outputStack.Pop();
          nextVal = inputStack.Pop();

          if (prevVal.EndsWith('!'))
            prevVal = ApplyFactorialCalculation(prevVal).ToString();
          if (nextVal.EndsWith('!'))
            nextVal = ApplyFactorialCalculation(nextVal).ToString();

          sum = Math.Pow(double.Parse(prevVal), double.Parse(nextVal));

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }
        else if (currVal == "sqrt")
        {
          nextVal = inputStack.Pop();

          sum = Math.Sqrt(double.Parse(nextVal));

          outputStack.Push(sum.ToString());
          j++;
          continue;
        }

        outputStack.Push(currVal);
      }

      return outputStack;
    }

    /// <summary>
    /// Returns the decimal value of the percentage value.
    /// </summary>
    /// <param name="input"></param>
    private void ApplyPercentage(List<string> input)
    {
      if (input.Contains("%"))
      {
        for (int i = 0; i < input.Count; i++)
        {
          if (input[i] == "%" && i - 1 >= 0)
          {
            double val = double.Parse(input[i - 1]);
            input[i - 1] = (val / 100d).ToString();
            input.RemoveAt(i);
            i--;
          }
        }
      }
    }

    /// <summary>
    /// Returns the value after performing factorial calculations.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private double ApplyFactorialCalculation(string input)
    {
      string trim = input.Trim('!');

      double val = double.Parse(trim);

      if (val <= 1) return val;

      return val * ApplyFactorialCalculation((val - 1).ToString());
    }

    private bool PrimaryErrorCheck(List<string> input, out string error)
    {
      error = null;
      if (input[0].Equals("+") || input[0].Equals("*") || input[0].Equals("/") || input[0].Equals("^"))
      {
        errorCode = true;
        error = "Format Error - cannot start calculation with operators";
        return true;
      }
      if (input[0].Equals("-") && input.Count <= 1)
      {
        errorCode = true;
        error = "Format Error - need to insert values";
        return true;
      }
      return false;
    }

    /// <summary>
    /// Outputs any errors due to invalid entries.
    /// </summary>
    /// <param name="error"></param>
    /// <returns></returns>
    private bool SecondaryErrorChecks(out string error)
    {
      error = null;

      bool hasNumber = false;
      bool unevenBrackets = false;
      bool startsWithOperator = false;
      bool noFollowingValueAfterOperator = false;
      int needClosingBracket = 0;

      int leftBracCount = inputs.FindAll(x => x == "(").Count + inputs.FindAll(x => x == "sqrt(").Count +
          inputs.FindAll(x => x == "log(").Count + inputs.FindAll(x => x == "ln(").Count +
          inputs.FindAll(x => x == "cos(").Count + inputs.FindAll(x => x == "sin(").Count +
          inputs.FindAll(x => x == "tan(").Count + inputs.FindAll(x => x == "arccos(").Count +
          inputs.FindAll(x => x == "arcsin(").Count + inputs.FindAll(x => x == "arctan(").Count;
      int rightBracCount = inputs.FindAll(x => x == ")").Count;
      bool isOperator = false;


      // ensures input is not empty
      if (splitInputs.Count <= 0) return true;
      if (IsOperator(splitInputs[0]))
        startsWithOperator = true;
      if (splitInputs.Contains("(") || splitInputs.Contains(")"))
        if (leftBracCount != rightBracCount)
          unevenBrackets = true;
      for (int i = 0; i < splitInputs.Count; i++)
      {
        if (IsNumber(splitInputs[i]) && splitInputs[i] != "pi" && splitInputs[i] != "e" || splitInputs[i] == "ans")
        {
          hasNumber = true;
          isOperator = false;
        }
        if (IsOperator(splitInputs[i]))
        {
          if (isOperator)
            noFollowingValueAfterOperator = true;
          if (i < splitInputs.Count - 1)
            isOperator = true;
        }
        if (IsNumber(splitInputs[i]) || splitInputs[i] == "(" || splitInputs[i] == ")")
          isOperator = false;
        if (splitInputs[i] == "(")
        {
          needClosingBracket++;
          if (i + 1 >= splitInputs.Count)
          {
            errorCode = true;
            error = "Format Error - must contain number(s) between brackets";
            return true;
          }
          if (splitInputs[i + 1] == ")")
          {
            errorCode = true;
            error = "Format Error - must contain number(s) between brackets";
            return true;
          }
        }
        if (splitInputs[i] == ")" && needClosingBracket <= 0)
        {
          errorCode = true;
          error = "Format Error - need an opening bracket for each closing bracket";
          return true;
        }
        if (splitInputs[i] == ")" && needClosingBracket > 0)
          needClosingBracket--;
      }



      if (!hasNumber)
      {
        errorCode = true;
        error = "Format Error - must contain numbers";
        return true;
      }
      else if (startsWithOperator)
      {
        errorCode = true;
        error = "Format Error - cannot start calculation with an operator";
        return true;
      }
      else if (unevenBrackets || needClosingBracket > 0)
      {
        errorCode = true;
        error = "Format Error - missing bracket(s)";
        return true;
      }
      else if (noFollowingValueAfterOperator || isOperator)
      {
        errorCode = true;
        error = "Format Error - need a valid value after an operator";
        return true;
      }

      return false;
    }

    private void DisplayOutputText()
    {
      outputTextBox.Clear();
      StringBuilder sb = new StringBuilder();

      for (int i = 0; i < ansHistory.Count; i++)
      {
        sb.AppendLine(ansHistory[i]);
      }

      outputTextBox.Text = sb.ToString();
    }

    #region Helper Methods
    /// <summary>
    /// Returns true if the given string value is a number.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    private bool IsNumber(string input)
    {
      bool check = float.TryParse(input, out float r);
      return check;
    }

    /// <summary>
    /// Returns true if the given string value is an operator.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    private bool IsOperator(string val)
    {
      if (val == "+" || val == "-" || val == "/" || val == "*" || val == "^" || val == "%")
        return true;
      return false;
    }

    /// <summary>
    /// Returns the inputted values as fragments which can then be calculated.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    /// 
    private List<string> SplitInput(string input)
    {
      if (input.Length <= 0)
        return null;

      string fragment = null;

      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] == '+' || input[i] == '-' || input[i] == '/' || input[i] == '*' || input[i] == '(' || input[i] == ')' || input[i] == '^' || input[i] == '%')
        {
          if (fragment != null && fragment != "")
          {
            splitInputs.Add(fragment);
            fragment = null;
          }

          splitInputs.Add(input[i].ToString());
          continue;
        }

        if (IsNumber(input[i].ToString()) && i + 1 < input.Length)
        {
          if (IsNumber(input[i + 1].ToString()) == false && input[i + 1].ToString() != "." && input[i + 1].ToString() != "!")
          {
            fragment += input[i];
            splitInputs.Add(fragment);
            fragment = null;
            continue;
          }
        }

        fragment += input[i];

        // Case: when single input of pi or e
        if (fragment == "pi" || fragment == "e")
        {
          splitInputs.Add(fragment);
          fragment = null;
        }
      }

      if (fragment != null && fragment != "")
        splitInputs.Add(fragment);


      return splitInputs;
    }

    /// <summary>
    /// Adds multiplication symbol in between variable/numbers with missing operators. Ex. pipi => pi*pi
    /// </summary>
    /// <param name="inputList"></param>
    private void ReformatInput(List<string> inputList)
    {
      for (int i = 0; i < inputList.Count; i++)
      {
        // adds * before
        if (inputList[i] == "pi" && i - 1 >= 0
          || inputList[i] == "sqrt" && i - 1 >= 0
          || inputList[i] == "e" && i - 1 >= 0
          || inputList[i] == "ln" && i - 1 >= 0
          || inputList[i] == "log" && i - 1 >= 0
          || inputList[i] == "sin" && i - 1 >= 0
          || inputList[i] == "cos" && i - 1 >= 0
          || inputList[i] == "tan" && i - 1 >= 0
          || inputList[i] == "arcsin" && i - 1 >= 0
          || inputList[i] == "arccos" && i - 1 >= 0
          || inputList[i] == "arctan" && i - 1 >= 0)
        {
          if (!IsOperator(inputList[i - 1]) && inputList[i - 1] != "(")
            inputList.Insert(i, "*");
        }
        if (inputList[i] == "(" && i - 1 >= 0)
        {
          if (inputList[i - 1] != "sqrt" && inputList[i - 1] != "ln" && inputList[i - 1] != "log"
            && inputList[i - 1] != "cos" && inputList[i - 1] != "sin" && inputList[i - 1] != "tan"
            && inputList[i - 1] != "arccos" && inputList[i - 1] != "arcsin" && inputList[i - 1] != "arctan")
            inputList.Insert(i, "*");
        }
        // adds * after
        if (inputList[i] == "pi" && i + 1 < inputList.Count
          || inputList[i] == "e" && i + 1 < inputList.Count
          || inputList[i] == ")" && i + 1 < inputList.Count)
        {
          if (!IsOperator(inputList[i + 1]) && inputList[i + 1] != ")")
            inputList.Insert(i + 1, "*");
        }
        if (inputList[0] == "-" && i + 1 < inputList.Count)
        {
          if (IsNumber(inputList[1]))
          {
            inputList[0] = "-" + inputList[1];
            inputList.RemoveAt(1);
          }

        }
      }
    }

    /// <summary>
    /// Converts all constant values into their number values to prepare for calculation.
    /// </summary>
    /// <param name="inputList"></param>
    private void ConvertConstantToNumbers(List<string> inputList)
    {
      for (int i = 0; i < inputList.Count; i++)
      {
        if (inputList[i] == "pi")
          inputList[i] = piValue;
        else if (inputList[i] == "e")
          inputList[i] = eValue;
      }
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
    /// Clears the inputs list and the values displayed on the calculator.
    /// </summary>
    private void ClearOutput()
    {
      errorCode = false;
      inputTextBox.Text = "";
      inputs.Clear();
      splitInputs.Clear();
    }

    private void PrepareCalculationHistory(List<string> input)
    {
      inputText = null;
      for (int i = input.Count - 1; i >= 0; i--)
      {
        if (input[i] == eValue)
        {
          inputText += "e";
          continue;
        }
        if (input[i] == piValue)
        {
          inputText += "pi";
          continue;
        }
        inputText += input[i];
      }
    }

    #endregion

    #region OnClick Events

    private void equalBtn_Click(object sender, EventArgs e)
    {
      string inputText = inputTextBox.Text;
      if (inputText.Length <= 0) return;

      List<string> input = SplitInput(inputText);

      ReformatInput(input);
      ConvertConstantToNumbers(input);
      if (PrimaryErrorCheck(input, out inputText))
      {
        inputTextBox.Text = inputText;
        return;
      }

      string result = Calculate(input);

      if (result == null)
        return;

      ClearOutput();

      string calculation = new StringBuilder(this.inputText + " = " + result).ToString();

      //inputs.Add(calculation);

      if (ansHistory.Count >= 5)
      {
        ansHistory.RemoveAt(0);
      }
      ansHistory.Add(calculation);

      DisplayOutputText();
    }

    private void zeroBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "0";
      inputs.Add("0");
    }

    private void oneBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "1";
      inputs.Add("1");
    }

    private void twoBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "2";
      inputs.Add("2");
    }

    private void threeBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "3";
      inputs.Add("3");
    }

    private void fourBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "4";
      inputs.Add("4");
    }

    private void fiveBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "5";
      inputs.Add("5");
    }

    private void sixBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "6";
      inputs.Add("6");
    }

    private void sevenBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "7";
      inputs.Add("7");
    }

    private void eightBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "8";
      inputs.Add("8");
    }

    private void nineBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "9";
      inputs.Add("9");
    }

    private void leftBracketBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "(";
      inputs.Add("(");
    }

    private void rightBracketBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += ")";
      inputs.Add(")");
    }

    private void divisionBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "/";
      inputs.Add("/");
    }

    private void multiplicationBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "*";
      inputs.Add("*");
    }

    private void subtractionBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "-";
      inputs.Add("-");
    }

    private void additionBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "+";
      inputs.Add("+");
    }

    private void radDegBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      isRad = !isRad;

      if (isRad)
        radDegBtn.Text = "Rad";
      else
        radDegBtn.Text = "Deg";
    }

    private void shiftBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      isInverse = !isInverse;

      if (isInverse)
      {
        sinBtn.Text = "arcsin";
        cosBtn.Text = "arccos";
        tanBtn.Text = "arctan";
        lnBtn.Text = "eˣ";
        logBtn.Text = ("10ˣ");
        squareRootBtn.Text = "x^2";
        exponentBtn.Text = "√x";
      }
      else
      {
        sinBtn.Text = "sin";
        cosBtn.Text = "cos";
        tanBtn.Text = "tan";
        lnBtn.Text = "ln";
        logBtn.Text = "log";
        squareRootBtn.Text = "sqrt";
        exponentBtn.Text = "xy";
      }
    }

    private void squareRootBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (isInverse)
      {
        inputTextBox.Text += "^2";
        inputs.Add("^2");
      }
      else
      {
        inputTextBox.Text += "sqrt(";
        inputs.Add("sqrt(");
      }
    }

    private void exponentBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (isInverse)
      {
        inputTextBox.Text += ")^(1/";
        inputs.Add(")^(1/");
      }
      else
      {
        inputTextBox.Text += "^";
        inputs.Add("^");
      }
    }

    private void logBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (isInverse)
      {
        inputTextBox.Text += "10^";
        inputs.Add("10^");
      }
      else
      {
        inputTextBox.Text += "log(";
        inputs.Add("log(");
      }
    }

    private void lnBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (isInverse)
      {
        inputTextBox.Text += "e^";
        inputs.Add("e^");
      }
      else
      {
        inputTextBox.Text += "ln(";
        inputs.Add("ln(");
      }
    }

    private void sinBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (isInverse)
      {
        inputTextBox.Text += "arcsin(";
        inputs.Add("arcsin(");
      }
      else
      {
        inputTextBox.Text += "sin(";
        inputs.Add("sin(");
      }
    }

    private void cosBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (isInverse)
      {
        inputTextBox.Text += "arccos(";
        inputs.Add("arccos(");
      }
      else
      {
        inputTextBox.Text += "cos(";
        inputs.Add("cos(");
      }
    }

    private void tanBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (isInverse)
      {
        inputTextBox.Text += "arctan(";
        inputs.Add("arctan(");
      }
      else
      {
        inputTextBox.Text += "tan(";
        inputs.Add("tan(");
      }
    }

    private void factorialBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "!";
      inputs.Add("!");
    }

    private void piBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "pi";
      inputs.Add("pi");
    }

    private void eBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "e";
      inputs.Add("e");
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      ClearOutput();
    }

    private void periodBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += ".";
      inputs.Add(".");
    }

    private void backspaceBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      if (inputs.Count <= 0) return;

      inputs.RemoveAt(inputs.Count - 1);
      inputTextBox.Text = "";

      for (int i = 0; i < inputs.Count; i++)
      {
        inputTextBox.Text += inputs[i];
      }
    }

    private void expBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "E";
      inputs.Add("E");
    }

    private void ansBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      // retrieve last answer from history
      if (ansHistory.Count <= 0) return;
      inputTextBox.Text += "ans";
      string ans = ansHistory[ansHistory.Count - 1];
      inputs.Add(ans);
    }

    private void percentBtn_Click(object sender, EventArgs e)
    {
      if (errorCode)
        ClearOutput();

      inputTextBox.Text += "%";
      inputs.Add("%");
    }
    #endregion

    #region Design Methods


    #endregion

    private void inputTextBox_TextChanged(object sender, EventArgs e)
    {

    }
  }
}