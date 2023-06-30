using System;

namespace StaticClass_Demo
{
    public static class HeightConvertor
    {
        public static double InchsToCentimeters(string HeightInInchs)
        {
            double inchs = Double.Parse(HeightInInchs);
            double Centimeters = (inchs * 2.54);
            return Centimeters;
        }

        public static double CentimetesToInchs(string HeightInCentimeters)
        {
            double centimeters = Double.Parse(HeightInCentimeters);
            double Inchs = (centimeters / 2.54);
            return Inchs;
        }
    }
}