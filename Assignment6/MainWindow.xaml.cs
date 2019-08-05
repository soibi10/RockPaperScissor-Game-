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

namespace Assignment6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int human_choice;
        int computer_choice;
        static int human_score = 0;
        static int com_score = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Paper_button_Click(object sender, RoutedEventArgs e)
        {
            Paper.Visibility = Visibility.Visible;
            Rock.Visibility = Visibility.Hidden;
            Scissors.Visibility = Visibility.Hidden;
            human_choice = 2;
            Computer_choice();
            //checkwinner();
            winner();
        }

        private void Rock_button_Click(object sender, RoutedEventArgs e)
        {
            Rock.Visibility = Visibility.Visible;
            Paper.Visibility = Visibility.Hidden;
            Scissors.Visibility = Visibility.Hidden;
            human_choice =1 ;
            Computer_choice();
            //checkwinner();
            winner();
        }

        private void Scissors_button_Click(object sender, RoutedEventArgs e)
        {
            Scissors.Visibility = Visibility.Visible;
            Paper.Visibility = Visibility.Hidden;
            Rock.Visibility = Visibility.Hidden;
            human_choice = 0;
            Computer_choice();
            //checkwinner();
            winner();
        }

        public void Computer_choice()
        {
          computer_choice = random.Next(0, 3);

            switch (computer_choice)
            {
                case 0:
                    Scissors1.Visibility = Visibility.Visible;
                    Rock1.Visibility = Visibility.Hidden;
                    Paper1.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    Rock1.Visibility = Visibility.Visible;
                    Scissors1.Visibility = Visibility.Hidden;
                    Paper1.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    Paper1.Visibility = Visibility.Visible;
                    Scissors1.Visibility = Visibility.Hidden;
                    Rock1.Visibility = Visibility.Hidden;
                    break;
            }
        }

        public void checkwinner()
        {
            if (human_choice == computer_choice)
                lblwin.Content = "DRAW";

           

            if
             (human_choice == 1 && computer_choice == 0)
            {
                lblwin.Content = "Human Wins";
                human_score++;
                lblscorehu.Content = human_score.ToString();
            }
            if
                (human_choice == 0 && computer_choice == 2)
            { lblwin.Content = "Human Wins";
                human_score++;
                lblscorehu.Content = human_score.ToString();
            }

            if (human_choice == 2 && computer_choice == 1)
            {
                lblwin.Content = "Human Wins";
                human_score++;
                lblscorehu.Content = human_score.ToString();
            }

            if
                (human_choice == 0 && computer_choice == 1)
            {
                lblwin.Content = "Computer Wins";
                 com_score++;
                lblscorecom.Content = com_score.ToString();
            }

            if (human_choice == 2 && computer_choice == 0)
            {
                lblwin.Content = "Computer Wins";
                com_score++;
                lblscorecom.Content = com_score.ToString();
            }
            if
                (human_choice == 1 && computer_choice == 2)
            {
                lblwin.Content = "Computer Wins";
                com_score++;
                lblscorecom.Content = com_score.ToString();
            }            

        }
        public void winner()
        {
            checkwinner();
            if (com_score == 10)
            {
                MessageBox.Show("Computer wins!"); human_score = 0;
                com_score = 0;
                lblscorehu.Content = "0";
                lblscorecom.Content = "0";
                lblwin.Content = "Who Wins";
            }
            else if (human_score == 10)
            {
                MessageBox.Show("Human wins!");
                human_score = 0;
                com_score = 0;
                lblscorehu.Content = "0";
                lblscorecom.Content = "0";
                lblwin.Content = "Who Wins";
            }

        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            human_score = 0;
            com_score = 0;
            lblscorehu.Content = "0";
            lblscorecom.Content = "0";
            lblwin.Content = "Who Wins";
            Rock1.Visibility = Visibility.Hidden;
            Scissors1.Visibility = Visibility.Hidden;
            Paper1.Visibility = Visibility.Hidden;
            Rock.Visibility = Visibility.Hidden;
            Paper.Visibility = Visibility.Hidden;
            Scissors.Visibility = Visibility.Hidden;
        }
    }
}
