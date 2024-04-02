using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ToDo
{
    /// <summary>
    /// Логика взаимодействия для Mainwin.xaml
    /// </summary>
    public partial class Mainwin : Window
    {
        public Mainwin()
        {
            InitializeComponent();
            Listbox.Items.Add(Todo());
        }

        public Grid Todo()
        {
            Grid grid = new Grid();
            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = new GridLength(4, GridUnitType.Star);

            grid.ColumnDefinitions.Add(col1);
            grid.ColumnDefinitions.Add(col2);

            Image image = new Image();
            image.Source = new BitmapImage(new Uri("/image/icons/images.png", UriKind.Relative));
            image.Width = 40;
            image.Height = 40;

            TextBlock textBlock = new TextBlock();
            textBlock.Text = "моя заметка";
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.VerticalAlignment = VerticalAlignment.Center;

            Grid.SetColumn(textBlock, 1);

            grid.Children.Add(image);
            grid.Children.Add(textBlock);
            return grid;
        }
    }
}
