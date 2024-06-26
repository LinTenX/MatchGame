﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEnoji = new List<string>()
            {
                "😀","😀",
                "😁","😁",
                "😂","😂",
                "🤣","🤣",
                "😃","😃",
                "😄","😄",
                "😅","😅",
                "😆","😆",
            };

            Random random = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEnoji.Count);
                string nextEmoji = animalEnoji[index];
                textBlock.Text = nextEmoji;
                animalEnoji.RemoveAt(index);
            }
            {
                
            }
        }
    }
}