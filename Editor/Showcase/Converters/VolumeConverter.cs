#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UnitConverter
{
    public class VolumeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (parameter == null)
                return value;
			 if (value == null)
            {
                return null;
            }
            double _value = Double.Parse(value.ToString());

            if (parameter.Equals("CM"))
            {
                return Math.Round(_value  * 1.6387064E-5,2);
            }
            else if (parameter.Equals("CY"))
            {
                return Math.Round(_value  * 2.14334705075446E-5,2);
            }
            else if (parameter.Equals("L"))
            {
                return Math.Round(_value  * 0.016387,2);
            }
            else if (parameter.Equals("CF"))
            {
                return Math.Round(_value  * 0.000579,2);
            }
            else
            {
                return Decimal.Parse(value.ToString());
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (parameter == null)
                return value;
			 if (value == null)
            {
                return null;
            }
            double _value = Double.Parse(value.ToString());

            if (parameter.Equals("CM"))
            {
                return Math.Round(_value  / 1.6387064E-5,2);
            }
            else if (parameter.Equals("CY"))
            {
                return Math.Round(_value  / 2.14334705075446E-5,2);
            }
            else if (parameter.Equals("L"))
            {
                return Math.Round(_value  / 0.016387,2);
            }
            else if (parameter.Equals("CF"))
            {
                return Math.Round(_value  / 0.000579,2);
            }
            else
            {
                return Decimal.Parse(value.ToString());
            }
        }
    }
}
