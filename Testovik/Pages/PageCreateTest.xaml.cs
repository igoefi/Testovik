using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Testovik.Classes.Helpers;
using Testovik.Classes.Helpers.JSON;

namespace Testovik.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCreateTest.xaml
    /// </summary>
    public partial class PageCreateTest : Page
    {
        private Test _test;
        private int _lastQuestionIndex = 0;
        private int _lastAnswerIndex = 0;

        public PageCreateTest()
        {
            InitializeComponent();
            _test = new Test();
            btnClickAddQuestion(null, null);
        }

        private void BtnClickBack(object sender, RoutedEventArgs e) =>
            FrameNav.Frame.GoBack();

        private void BtnClickEndDoing(object sender, RoutedEventArgs e)
        {
            JsonHelper.SaveTest(_test);
            BtnClickBack(null, null);
        }

        private void btnClickAddAnswer(object sender, RoutedEventArgs e)
        {
            var index = FindQuestionIndex();
            _test.Answers[index].Add("answer");

            UpdateSources();
            cmbBoxAnwsers.SelectedIndex = _test.Answers[FindQuestionIndex()].Count - 1;
        }

        private void btnClickAddQuestion(object sender, RoutedEventArgs e)
        {
            _test.Questions.Add("question");
            _test.Answers.Add(new List<string>() { "answer" });

            cmbBoxQuestions.SelectedIndex = _test.Questions.Count - 1;
            UpdateSources();
        }

        private void CmbBoxQuestionChanged(object sender, SelectionChangedEventArgs e) =>
            SetQuestionText();

        private void CmbBoxAnswersChanged(object sender, SelectionChangedEventArgs e) =>
            SetAnswerText();


        private void SetQuestionText()
        {
            SetAnswerText(_lastQuestionIndex);
            var index = FindQuestionIndex();
            _test.Questions[_lastQuestionIndex] = txbQuestion.Text;
            txbQuestion.Text = _test.Questions[index];

            UpdateSources();
        }

        private void SetAnswerText(int questionIndex = -1)
        {
            if(questionIndex == -1)
                questionIndex = FindQuestionIndex();
            _test.Answers[questionIndex][_lastAnswerIndex] = txbAnswer.Text;
            txbAnswer.Text = _test.Answers[FindQuestionIndex(out int indexA)][indexA];

            UpdateSources();
        }

        private void btnClickDeleteAnswer(object sender, RoutedEventArgs e)
        {
            if (_test.Answers.Count <= 1)
                return;

            _test.Answers[FindQuestionIndex(out int indexA)].RemoveAt(indexA);
            _lastAnswerIndex = 0;

            UpdateSources();
        }

        private void btnClickDeleteQuestion(object sender, RoutedEventArgs e)
        {
            if (_test.Questions.Count <= 1)
                return;

            var index = FindQuestionIndex();
            _test.Questions.RemoveAt(index);
            _test.Answers.RemoveAt(index);

            UpdateSources();
        }

        private int FindQuestionIndex()
        {
            var text = cmbBoxQuestions.Text;
            for (int i = 0; i < _test.Questions.Count; i++)
                if (_test.Questions[i] == text)
                    return i;
            return -1;
        }

        private int FindQuestionIndex(out int indexAnswer)
        {
            var index = -1;
            indexAnswer = -1;

            var text = cmbBoxQuestions.Text;
            for (int i = 0; i < _test.Questions.Count; i++)
                if (_test.Questions[i] == text)
                    index = i;

            for (int i = 0; i < _test.Answers[index].Count; i++)
                if (_test.Answers[index][i] == cmbBoxAnwsers.Text)
                    indexAnswer = i;

            return index;
        }

        private void UpdateSources()
        {
            cmbBoxQuestions.ItemsSource = _test.Questions;

            cmbBoxAnwsers.ItemsSource = _test.Answers[_lastQuestionIndex];
        }
    }
}
