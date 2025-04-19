using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MarkdownEditor.Models
{
    public class PageSettings
    {
        public double Width { get; set; } = 794; // A4 page width
        public double Height { get; set; } = 1123; // A4 page height
        public Thickness Margins { get; set; } = new Thickness(50); // Default 50px margins
    }
}
