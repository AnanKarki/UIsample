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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UITest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            }

        private void ChannelsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle channel selection change here
            ListBox listBox = (ListBox)sender;
            ListBoxItem selectedItem = (ListBoxItem)listBox.SelectedItem;
            string selectedChannel = selectedItem?.Content.ToString();

            //
        }

        private void PeopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle channel selection change here
            ListBox listBox = (ListBox)sender;
            ListBoxItem selectedItem = (ListBoxItem)listBox.SelectedItem;
            string selectedChannel = selectedItem?.Content.ToString();

            //
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string messageText = messageTextBox.Text;
            if (!string.IsNullOrWhiteSpace(messageText))
            {
                AddChatMessage(messageText);
                messageTextBox.Clear();
            }
        }

        private void AddChatMessage(string messageText)
        {
            StackPanel messagePanel = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Margin = new Thickness(0, 0, 0, 10)
            };

            TextBlock messageTextBlock = new TextBlock
            {
                Text = messageText,
                Background = System.Windows.Media.Brushes.LightBlue,
                Padding = new Thickness(10),
                MaxWidth = 300,
                TextWrapping = TextWrapping.Wrap
            };

            messagePanel.Children.Add(messageTextBlock);
            ChatMessagesStackPanel.Children.Add(messagePanel);
        }
        }
    }
