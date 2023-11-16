using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_MF_BHX.CustomControl
{
    public class CustomButton : Button
    {
        public CustomButton(string text, EventHandler eventHandler)
        {
            Text = text;
            Click += eventHandler;
        }
    }
}
