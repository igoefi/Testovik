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

        private void btnClickAddQuestion(object sender, RoutedEventArgs e)
        {
            _test.Questions.Add("question");
            _test.Answers.Add(new List<string>() { "answer" });

            UpdateSources();
            cmbBoxQuestions.SelectedIndex = _test.Questions.Count - 1;
            cmbBoxAnwsers.SelectedIndex = 0;
        }

        private void btnClickAddAnswer(object sender, RoutedEventArgs e)
        {
            var index = FindQuestionIndex();
            _test.Answers[index].Add("answer");

            UpdateSources();
            cmbBoxAnwsers.SelectedIndex = _test.Answers[FindQuestionIndex()].Count - 1;
        }

        private void CmbBoxQuestionChanged(object sender, SelectionChangedEventArgs e) =>
            SetQuestionText();

        private void CmbBoxAnswersChanged(object sender, SelectionChangedEventArgs e) =>
            SetAnswerText();


        private void SetQuestionText()
        {
            _test.Questions[_lastQuestionIndex] = txbQuestion.Text;
            _test.Answers[_lastQuestionIndex][_lastAnswerIndex] = txbAnswer.Text;

            UpdateSources();
            txbQuestion.Text = _test.Questions[FindQuestionIndex()];
            txbAnswer.Text = _test.Answers[FindQuestionIndex()][0];
            cmbBoxAnwsers.SelectedIndex = 0;

            _lastQuestionIndex = FindQuestionIndex();
            _lastAnswerIndex = 0;
        }

        private void SetAnswerText()
        {
            _test.Answers[FindQuestionIndex()][_lastAnswerIndex == -1 ? 0 : _lastQuestionIndex] = txbAnswer.Text;

            UpdateSources();
            txbAnswer.Text = _test.Answers[FindQuestionIndex(out int indexA)][indexA];
            _lastAnswerIndex = cmbBoxAnwsers.SelectedIndex;
        }

        private void btnClickDeleteAnswer(object sender, RoutedEventArgs e)
        {
            _test.Answers[FindQuestionIndex(out int indexA)].RemoveAt(indexA);
            UpdateSources();
            cmbBoxAnwsers.SelectedIndex = 0;
        }

        private void btnClickDeleteQuestion(object sender, RoutedEventArgs e)
        {
            if (_test.Questions.Count <= 1)
                return;

            var index = FindQuestionIndex();
            _test.Questions.RemoveAt(index);
            _test.Answers.RemoveAt(index);

            UpdateSources();
            cmbBoxQuestions.SelectedIndex = 0;
            cmbBoxAnwsers.SelectedIndex = 0;
        }

        private int FindQuestionIndex() =>
            cmbBoxQuestions.SelectedIndex == -1 ? 0 : cmbBoxQuestions.SelectedIndex;

        private int FindQuestionIndex(out int indexAnswer)
        {
            indexAnswer = cmbBoxAnwsers.SelectedIndex == -1 ? 0 : cmbBoxAnwsers.SelectedIndex;
            return cmbBoxQuestions.SelectedIndex == -1 ? 0 : cmbBoxQuestions.SelectedIndex;
        }

        private void UpdateSources()
        {
            cmbBoxQuestions.ItemsSource = _test.Questions.ToArray();
            cmbBoxAnwsers.ItemsSource = _test.Answers[FindQuestionIndex()].ToArray();
        }
    }
}
