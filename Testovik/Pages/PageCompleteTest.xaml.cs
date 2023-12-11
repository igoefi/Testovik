using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Testovik.Classes.Helpers;

namespace Testovik.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCompleteTest.xaml
    /// </summary>
    public partial class PageCompleteTest : Page
    {
        private RadioButton _radio;

        private int _questionIndex = -1;
        private List<string> _questions;
        private readonly List<string> _answers;
        public PageCompleteTest()
        {
            InitializeComponent();
            _answers = new List<string>();
        }

        private void btnChecked(object sender, RoutedEventArgs e)
        {
            var btn = (RadioButton)sender;
            if (_radio != null)
                _radio.IsChecked = false;
            _radio = btn;

        }

        private void btnClickStartTest(object sender, RoutedEventArgs e)
        {
            var tag = txblTestTag.Text;
            var test = JsonHelper.LoadTest(tag);
            if (test == null) return;

            _questions = test.Questions;

            stcpSelectTest.Visibility = Visibility.Hidden;
            grpbxTest.Visibility = Visibility.Visible;

            SetNewQuestion();
        }

        private void SetNewQuestion()
        {
            _questionIndex++;
            GridTest.ItemsSource = _questions[_questionIndex];
            txblTestTag.Text = $"{_questionIndex}/{_questions.Count - 1}";

            if (_questionIndex == _questions.Count - 1)
                btnNextQuestion.Content = "Завершить тест";
            else if (_questionIndex == _questions.Count)
                FrameNav.Frame.GoBack();
        }

        private void btnClickNextQuestion(object sender, RoutedEventArgs e)
        {
            _answers.Add(_radio.FontFamily.ToString());
            _radio = null;
            SetNewQuestion();
        }
    }
}
