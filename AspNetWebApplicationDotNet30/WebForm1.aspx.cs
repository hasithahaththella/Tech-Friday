using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebApplicationDotNet30
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(txtNumber1.Text, out num1) && int.TryParse(txtNumber2.Text, out num2))
            {
                int sum = num1 + num2;
                lblResult.Text = $"The sum of {num1} and {num2} is: {sum}";
            }
            else
            {
                lblResult.Text = "Invalid input. Please enter valid integer numbers.";
            }
        }
    }
}