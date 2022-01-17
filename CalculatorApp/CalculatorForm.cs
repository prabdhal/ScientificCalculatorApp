using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorApp
{
  public partial class calculatorForm : Form
  {
    private List<string> output = new List<string>();

    public calculatorForm()
    {
      InitializeComponent();
    }
    // 1 + (2 + 2 + 1) + 1 + 4
    private float Calculate()
    {
      float currVal = 0;
      float sum = 0;
      List<string> calculations = new List<string>();
      bool isAdd = false;
      bool isSub= false;
      bool isDiv = false;
      bool isMulti = false;
      bool isFirst = true;

      for (int i = 0; i < output.Count; i++)
      {
        Console.WriteLine("TryParsing Value: " + output[i]);
        if (int.TryParse(output[i], out int val))
        {
          Console.WriteLine("Value of " + output[i] + " is an int.");

          if (currVal == 0)
            currVal = val;
          else
            currVal = int.Parse(currVal.ToString() + output[i]);

        }
        else
        {
          Console.WriteLine("Value of " + output[i] + " is NOT an int.");

          calculations.Add(currVal.ToString());
          calculations.Add(output[i]);
          currVal = 0;
        }
      }
      calculations.Add(currVal.ToString());


      // Calculate final value
      int result;
      for (int i = 0; i < calculations.Count; i++)
      {
        if (int.TryParse(calculations[i], out result) && !isAdd
           && !isSub && !isDiv && !isMulti)
        {
          currVal = result;
          if (isFirst)
          {
            sum = currVal;
            isFirst = false;
          }
        }
        else if (int.TryParse(calculations[i], out result) && isAdd ||
          int.TryParse(calculations[i], out result) && isSub ||
          int.TryParse(calculations[i], out result) && isDiv ||
          int.TryParse(calculations[i], out result) && isMulti)
        {
          if (isAdd)
          {
            sum += result;
            isAdd = false;
          }
          else if (isSub)
          {
            sum -= result;
            isSub = false;
          }
          else if (isDiv)
          {
            sum /= result;
            isDiv = false;
          }
          else if (isMulti)
          {
            sum *= result;
            isMulti = false;
          }
        }
        else
        {
          switch (calculations[i])
          {
            case "+":
              isAdd = true;
              break;
            case "-":
              isSub = true;
              break;
            case "/":
              isDiv = true;
              break;
            case "*":
              isMulti = true;
              break;
          }
        }
      }

      return sum;
    }

    private void Addition()
    {

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

      for (int i = 0; i < output.Count; i++)
      {
        outputTextBox.Text += output[i];
      }
    }

    private void ClearOutput()
    {
      outputTextBox.Text = "";
    }

    private void ClearEverything()
    {
      ClearOutput();
      output.Clear();
    }

    private void oneBtn_Click(object sender, EventArgs e)
    {
      output.Add("1");
      UpdateOutputDisplay();
    }

    private void twoBtn_Click(object sender, EventArgs e)
    {
      output.Add("2");
      UpdateOutputDisplay();
    }

    private void threeBtn_Click(object sender, EventArgs e)
    {
      output.Add("3");
      UpdateOutputDisplay();
    }

    private void fourBtn_Click(object sender, EventArgs e)
    {
      output.Add("4");
      UpdateOutputDisplay();
    }

    private void fiveBtn_Click(object sender, EventArgs e)
    {
      output.Add("5");
      UpdateOutputDisplay();
    }

    private void sixBtn_Click(object sender, EventArgs e)
    {
      output.Add("6");
      UpdateOutputDisplay();
    }

    private void sevenBtn_Click(object sender, EventArgs e)
    {
      output.Add("7");
      UpdateOutputDisplay();
    }

    private void eightBtn_Click(object sender, EventArgs e)
    {
      output.Add("8");
      UpdateOutputDisplay();
    }

    private void nineBtn_Click(object sender, EventArgs e)
    {
      output.Add("9");
      UpdateOutputDisplay();
    }

    private void leftBracketBtn_Click(object sender, EventArgs e)
    {
      output.Add("(");
      UpdateOutputDisplay();
    }

    private void rightBracketBtn_Click(object sender, EventArgs e)
    {
      output.Add(")");
      UpdateOutputDisplay();
    }

    private void factorialBtn_Click(object sender, EventArgs e)
    {
      output.Add("!");
      UpdateOutputDisplay();
    }

    private void piBtn_Click(object sender, EventArgs e)
    {
      output.Add("pi");
      UpdateOutputDisplay();
    }

    private void eBtn_Click(object sender, EventArgs e)
    {
      output.Add("e");
      UpdateOutputDisplay();
    }

    private void clearBtn_Click(object sender, EventArgs e)
    {
      ClearEverything();
    }

    private void backspaceBtn_Click(object sender, EventArgs e)
    {
      if (output.Count <= 0) return;

      int lastIndex = output.Count - 1;

      output.RemoveAt(lastIndex);
      UpdateOutputDisplay();
    }

    private void divisionBtn_Click(object sender, EventArgs e)
    {
      output.Add("/");
      UpdateOutputDisplay();
    }

    private void multiplicationBtn_Click(object sender, EventArgs e)
    {
      output.Add("*");
      UpdateOutputDisplay();
    }

    private void subtractionBtn_Click(object sender, EventArgs e)
    {
      output.Add("-");
      UpdateOutputDisplay();
    }

    private void additionBtn_Click(object sender, EventArgs e)
    {
      output.Add("+");
      UpdateOutputDisplay();
    }

    private void equalBtn_Click(object sender, EventArgs e)
    {
      string result = Calculate().ToString();
      ClearEverything();
      outputTextBox.Text = result;
    }

    private void shiftBtn_Click(object sender, EventArgs e)
    {

    }

    private void squareBtn_Click(object sender, EventArgs e)
    {
      output.Add("^2");
      UpdateOutputDisplay();
    }

    private void squareRootBtn_Click(object sender, EventArgs e)
    {
      output.Add("sqrt(");
      UpdateOutputDisplay();
    }

    private void exponentBtn_Click(object sender, EventArgs e)
    {
      output.Add("^");
      UpdateOutputDisplay();
    }

    private void logBtn_Click(object sender, EventArgs e)
    {
      output.Add("log");
      UpdateOutputDisplay();
    }

    private void lnBtn_Click(object sender, EventArgs e)
    {
      output.Add("ln");
      UpdateOutputDisplay();
    }

    private void calculatorForm_Load(object sender, EventArgs e)
    {

    }
  }
}
