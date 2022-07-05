using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesLab
{
    internal class Circle
    {
        public double Radius;


        public Circle(double _radius)
        {
            Radius = _radius;
        }

        public double CalculateCircumference()
        {
            double circumference = (2 * Math.PI * Radius);           
            return circumference;
        }

        public double CalculateArea()
        {
            double area = (Math.PI * (Radius * Radius));            
            return area;
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
            //can put in Calc circumference, area, etc 
        }

        public string CalculateFormattedCircumference()
        {
            string formattedCircumference = FormatNumber(CalculateCircumference());
            return formattedCircumference;
        }

        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }
    }
}
