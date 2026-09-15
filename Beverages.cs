using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week3Assignment3._4
{
    enum SizeCoffee
    {
        Small,
        Medium,
        Large

    }
    enum Roast
    {
        Light,
        Medium,
        Dark

    }
    enum Milk
    {
        Whole,
        Skim,
        Oat,
        Almond,
        None

    }
    public abstract class Beverages
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public bool IsHot { get; set; }

    }

    public class Coffee : Beverages
    {
        public string Roast { get; set; }
        public string MilkType { get; set; }
        public bool HasSugar { get; set; }
    }
}
