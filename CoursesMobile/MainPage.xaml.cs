using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoursesMobile
{
    public partial class MainPage : ContentPage
    {
        int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void DemoButton_Clicked(object sender, EventArgs e)
        {
            counter++;
            DemoButton.Text = "I was clicked";
            Layout1.Text = $"Demo button was clicked {counter} times";
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            counter = 0;
            Layout1.Text = "Welcome on Courses Mobile App";
            DemoButton.Text = "Click and start the magic";
        }
    }
}
