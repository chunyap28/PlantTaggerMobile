using System;

using Xamarin.Forms;
using Plant_Tagger.Libraries;

namespace Plant_Tagger.Views
{
    public class FontAwesomeLabel : Label
    {
        public static readonly string FontAwesomeName = "FontAwesome";

        //Parameterless constructor for XAML
        public FontAwesomeLabel()
        {
            FontFamily = FontAwesomeName;
        }

        public FontAwesomeLabel(string fontAwesomeLabel = null)
        {
            FontFamily = FontAwesomeName;
            Text = fontAwesomeLabel;
        }
    }
}

