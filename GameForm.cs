using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{

    public partial class GameForm : Form
    {
        private bool wheelIsMoved;
        private System.Windows.Forms.Timer wheelTimer;
        private Random rand;
        private List<Letter> alphabet;
        private List<Letter> answer;
        private Game game;
        private List<Label> scores;
        private List<Label> current_scores;


        public GameForm(List<Player> players, string level)
        {
            rand = new Random();
            InitializeComponent();
            game = new Game(level, players);
            scores = new List<Label>() { player1_score, player2_score, player3_score };
            current_scores = new List<Label>() { player1_current_score, player2_current_score, player3_current_score };
            wheelIsMoved = false;
            wheelTimer = new System.Windows.Forms.Timer();
            wheelTimer.Interval = 10;
            wheelTimer.Tick += WheelTimer_Tick;
            alphabet = new List<Letter>();
            answer = new List<Letter>();
            alphabet_panel.Enabled = false;
            tool_panel.Enabled = false;
            player1_name.Text = players[0].Name;
            player2_name.Text = players[1].Name;
            player3_name.Text = players[2].Name;
            UpdateAll();
            NewRound();
        }
        private void NewRound()
        {
            if (game.EndGame)
            {
                EndGame();
            }
            else
            {
                game.NewRound();
                UpdateAll();
                round_lb.Text = "Раунд " + game.CurrentRound;
                labelScoreInt.Text = "0";
                status.Text = $"Почався раунд {game.CurrentRound}";
                alphabet_panel.Controls.Clear();
                CreateAlphabet();
                question.Text = "Питання: " + Questions.Question;
                answer_panel.Controls.Clear();
                CreateAnswer();
                status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
                pictureBox1.Enabled = true;
            }
        }
        private void RotateImage(PictureBox pb, Image img, float angle)
        {
            if (img == null || pb.Image == null)
                return;

            Image oldImage = pb.Image;
            pb.Image = GameWheel.RotateImage(img, angle);
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }
        private void WheelTimer_Tick(object sender, EventArgs e)
        {

            if (wheelIsMoved && GameWheel.WheelTime > 0)
            {
                GameWheel.circule.angle += GameWheel.WheelTime / 10;
                GameWheel.circule.angle = GameWheel.circule.angle % 360;
                RotateImage(pictureBox1, GameWheel.circule.wheelImg, GameWheel.circule.angle);
                GameWheel.WheelTime--;
            }
            GameWheel.circule.stan = Convert.ToInt32(Math.Ceiling(GameWheel.circule.angle / 18));
            if (GameWheel.circule.stan == 0)
            {
                GameWheel.circule.stan = 0;
            }
            else
            {
                GameWheel.circule.stan -= 1;
            }
            labelScoreInt.Text = GameWheel.circule.cost[GameWheel.circule.stan].ToString();
            if (GameWheel.WheelTime == 0)
            {
                GameWheel.Points = int.Parse(labelScoreInt.Text);
                wheelIsMoved = false;
                wheelTimer.Stop();
                alphabet_panel.Enabled = true;
                tool_panel.Enabled = true;
                if (alphabet.Count(button => button.Active) > 0)
                {
                    buttonBuy.Enabled = true;
                }
                if (GameWheel.Points == 0)
                {
                    game.BankrutPlay();
                    MessageBox.Show($"{game.CurrentPlayer.Name} ви банкрут.", "Банкрут", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    game.AddNewRecord($"{game.CurrentPlayer.Name} банкрут");
                    status.Text = $"{game.CurrentPlayer.Name} банкрут";
                    game.CurrentPlayer.ResetScore();
                    game.CurrentPlayer.ResetCurrentScore();
                    UpdateScore(game.CurrentPlayer, game.PlayerIndex);
                    UpdateCurrentScore(game.CurrentPlayer, game.PlayerIndex);
                    game.NextPlayer();
                    alphabet_panel.Enabled = false;
                    tool_panel.Enabled = false;
                    pictureBox1.Enabled = true;
                    labelScoreInt.Text = "0";
                    status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";

                }
                else if (GameWheel.Points == -1)
                {
                    game.StopPlay();
                    MessageBox.Show($"{game.CurrentPlayer.Name} ви пропускаєте хід.", "Пропуск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    game.AddNewRecord($"{game.CurrentPlayer.Name} пропускає хід");
                    status.Text = $"{game.CurrentPlayer.Name} пропускає хід";
                    game.NextPlayer();
                    alphabet_panel.Enabled = false;
                    tool_panel.Enabled = false;
                    pictureBox1.Enabled = true;
                    labelScoreInt.Text = "0";
                    status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
                }
                else if (GameWheel.Points == 3000)
                {
                    game.JackpotPlay();
                }
                else
                {
                    game.AddNewRecord($"Гравцеві {game.CurrentPlayer.Name} випало {GameWheel.Points} балів");
                    status.Text = $"Гравцеві {game.CurrentPlayer.Name} випало {GameWheel.Points} балів";
                    status_lb.Text = game.CurrentPlayer.Name + " обирайте літеру";
                }
            }
        }
        private void CreateAlphabet()
        {
            List<string> letters = new List<string>() { "А", "Б", "В", "Г", "Ґ", "Д", "Е", "Є", "Ж", "З", "И",
            "І", "Ї", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ь",
            "Ю", "Я"};
            for (int i = 0; i < 33; ++i)
            {
                Letter letter = new Letter(letters[i], false);
                letter.Click += letter_Click;
                alphabet_panel.Controls.Add(letter);
                alphabet.Add(letter);
            }
        }
        private void CreateAnswer()
        {
            foreach (string i in game.AnswerArray)
            {
                Letter letter = new Letter(i, true);
                answer_panel.Controls.Add(letter);
                answer.Add(letter);
            }
        }
        private void FindLetter(Letter letter)
        {
            foreach (Letter i in answer)
            {
                if (letter == i)
                {
                    i.GuessedLetter();
                }
            }
        }
        private void letter_Click(object sender, EventArgs e)
        {
            Letter letter = sender as Letter;
            game.AddNewRecord($"{game.CurrentPlayer.Name} обрав літеру {letter.Current_letter}");
            status.Text = $"{game.CurrentPlayer.Name} обрав літеру {letter.Current_letter}";
            status.Text = game.LetterClick(letter.Current_letter);
            FindLetter(letter);
            letter.BackColor = Color.Khaki;
            letter.Enabled = false;
            letter.Active = false;
            alphabet_panel.Enabled = false;
            tool_panel.Enabled = false;
            pictureBox1.Enabled = true;
            if (letter.Vowel)
            {
                alphabet = alphabet.Where(l => l.Vowel && l.Active).Select(l => { l.Enabled = false; return l; }).ToList();
            }
            UpdateScore(game.CurrentPlayer, game.PlayerIndex);
            UpdateCurrentScore(game.CurrentPlayer, game.PlayerIndex);
            if (game.EndRound == true)
            {
                MessageBox.Show("Раунд " + game.CurrentRound.ToString() + " завершено.", "Завершення раунду", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                status.Text = $"Раунд {game.CurrentRound} завершено";
                NewRound();
            }
            else labelScoreInt.Text = "0"; status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            game.WheelSpinPlay();
            game.AddNewRecord($"{game.CurrentPlayer.Name} крутить колесо");
            status.Text = $"{game.CurrentPlayer.Name} крутить колесо";
            wheelIsMoved = true;
            Random rand = new Random();
            GameWheel.WheelTime = rand.Next(150, 200);
            wheelTimer.Start();
            pictureBox1.Enabled = false;
        }
        private void BuyVowel()
        {
            if (game.CurrentPlayer.Score >= 250)
            {
                game.AddNewRecord($"{game.CurrentPlayer.Name} купив голосну літеру");
                status.Text = $"{game.CurrentPlayer.Name} купив голосну літеру";
                game.CurrentPlayer.Score -= 250;
                game.CurrentPlayer.CurrentScore -= 250;
                UnlockVowel();
                UpdateScore(game.CurrentPlayer, game.PlayerIndex);
                UpdateCurrentScore(game.CurrentPlayer, game.PlayerIndex);
            }
            else
            {
                DialogResult result = MessageBox.Show($"{game.CurrentPlayer.Name}, на жаль, у вас замало балів для цієї покупки. Бажаєте взяти кредит?", "Купівля голосних літер",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    game.TakeCredit();
                    game.AddNewRecord($"{game.CurrentPlayer.Name} взяв кредит");
                    status.Text = $"{game.CurrentPlayer.Name} взяв кредит";
                    UnlockVowel();
                    UpdateScore(game.CurrentPlayer, game.PlayerIndex);
                    UpdateCurrentScore(game.CurrentPlayer, game.PlayerIndex);
                }
            }
        }
        private void UnlockVowel()
        {
            alphabet = alphabet.Where(l => l.Vowel && l.Active).Select(l => { l.Enabled = true; return l; }).ToList();
        }
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            buttonBuy.Enabled = false;
            BuyVowel();
        }
        private void EndGame()
        {
            game.GameOverPlay();
            LogForm logForm = new LogForm(game.Rating(), game.logs[0], game.logs[1], game.logs[2], game.CreateGeneralLog());
            DialogResult result = logForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            logForm.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Player player = game.CurrentPlayer;
            int index = game.PlayerIndex;
            if (game.CheckAnswer(answerBox.Text))
            {
                UpdateScore(player, index);
                UpdateCurrentScore(player, index);
                MessageBox.Show($"Правильна відповідь! Вітаємо. {game.CurrentRound} раунд завершено", "Повна відповідь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game.AddNewRecord($"{game.CurrentPlayer.Name} вгадав повне слово. Раунд {game.CurrentRound} завершено");
                status.Text = $"{game.CurrentPlayer.Name} вгадав повне слово. Раунд {game.CurrentRound} завершено";
                answerBox.Clear();
                NewRound();
            }
            else
            {
                UpdateScore(player, index);
                UpdateCurrentScore(player, index);
                answerBox.Clear();
                MessageBox.Show($"На жаль, це неправильна відповідь {game.CurrentPlayer.Name}. Ваші бали обнулено", "Повна відповідь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game.AddNewRecord($"{game.CurrentPlayer.Name} не вгадав слово. Його бали обнулено");
                status.Text = $"{game.CurrentPlayer.Name} не вгвдав слово. Його бали обнулено";
                game.NextPlayer();
                pictureBox1.Enabled = true;
                labelScoreInt.Text = "0";
                status_lb.Text = game.CurrentPlayer.Name + " крутіть колесо";
            }
            alphabet_panel.Enabled = false;
            tool_panel.Enabled = false;
        }
        private void UpdateScore(Player player, int index)
        {
            scores[index].Text = "Рахунок: " + player.Score.ToString();
        }
        private void UpdateCurrentScore(Player player, int index)
        {
            current_scores[index].Text = player.CurrentScore.ToString();
        }

        private void stop_game_bt_Click(object sender, EventArgs e)
        {
            EndGame();
        }
        private void UpdateAll()
        {
            for (int i = 0; i < 3; ++i)
            {
                UpdateScore(game.Player[i], i);
                UpdateCurrentScore(game.Player[i], i);
            }
        }
    }
    public class Letter : Button
    {
        private bool is_answer_letter;
        private string current_letter;
        private bool is_vowel;
        private bool is_active;
        public string Current_letter
        {
            get { return current_letter; }
        }
        public bool Active
        {
            get { return is_active; }
            set { is_active = value; }
        }
        public bool Vowel
        {
            get { return is_vowel; }
        }
        public Letter(string l, bool answer_letter)
        {
            if (answer_letter)
            {
                is_answer_letter = true;
                this.BackgroundImage = global::app.Properties.Resources._1676636867_catherineasquithgallery_com_p_zelenie_polosi_fon_9;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.Enabled = false;
            }
            else
            {
                is_answer_letter = false;
                if (l == "Е" || l == "А" || l == "Є" || l == "И" || l == "І" || l == "Ї" || l == "О" || l == "У" || l == "Ю" || l == "Я")
                {
                    is_vowel = true;
                    this.Enabled = false;
                    this.BackColor = Color.Khaki;
                }
                else
                {
                    is_vowel = false;
                    this.BackColor = Color.Gold;
                }
                this.Margin = new Padding(7, 15, 7, 15);
                this.Text = l;
                is_active = true;
            }
            current_letter = l;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Size = new Size(31, 43);
        }
        public void GuessedLetter()
        {
            if (is_answer_letter)
            {
                this.BackgroundImage = null;
                this.BackColor = Color.GhostWhite;
                this.Text = Current_letter;
            }
        }
        public static bool operator ==(Letter first, Letter second)
        {
            return first.Current_letter == second.Current_letter;
        }
        public static bool operator !=(Letter first, Letter second)
        {
            return !(first == second);
        }
    }
}
