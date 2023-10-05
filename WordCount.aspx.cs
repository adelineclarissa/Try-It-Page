using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt_AdelineTrisnobuwono
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string filePath = TextBox1.Text;
            if (string.IsNullOrEmpty(filePath))
            {
                // print out error message
                ResultLabel.Text = "Invalid input.";


            }
            else
            {
                WordCountService.Service1Client wordCountService = new WordCountService.Service1Client();
                string result = wordCountService.WordCount(filePath);
                ResultLabel.Text = result;
            }
        }
    }
}