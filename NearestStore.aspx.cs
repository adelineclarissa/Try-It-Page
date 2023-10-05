using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt_AdelineTrisnobuwono
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void SearchButton_ClickAsync(object sender, EventArgs e)
        {
            string storeName = storeNameField.Value;
            string location = locationField.Value;

            // Invoke the service
            NearestStoreService.Service1Client searchStoreService = new NearestStoreService.Service1Client();
            string result = await searchStoreService.FindNearestStoreAsync(location, storeName);

            // convert \n to <br> using regex
            result = Regex.Replace(result, @"\n", "<br />");

            resultLabel.Text = result;

        }
    }
}