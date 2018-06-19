using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Plant_Tagger.Libraries;

namespace Plant_Tagger.Views
{
    public partial class TextBoxWithImage : ContentView
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", 
                                                                                       typeof(string), 
                                                                                       typeof(TextBoxWithImage), 
                                                                                       (object)null, 
                                                                                       BindingMode.TwoWay);

        public TextBoxWithImage()
        {
            InitializeComponent();
        }

        public String Text
        {
            get => xEntry.Text;
            set => xEntry.Text = value;
        }

        public bool IsPassword
        {
            get => xEntry.IsPassword;
            set => xEntry.IsPassword = value;
        }

        public string Placeholder
        {
            get => xEntry.Placeholder;
            set => xEntry.Placeholder = value;
        }

        public string FontAwesomeLabel
        {
            get => xLabel.Text;

            set => xLabel.Text = value;
        }
    }
}
