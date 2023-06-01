using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Media;
using System.Runtime.Serialization.Formatters.Soap;

namespace app
{
    public class Kolo
    {
        public Bitmap wheelImg;
        public Bitmap tempWheelImg;
        public float angle;
        public int[] cost;
        public int stan;

        public Kolo()
        {
            tempWheelImg = new Bitmap(Properties.Resources.kolo);
            wheelImg = new Bitmap(Properties.Resources.kolo);
            cost = new int[] { 425, 225, 375, -1, 25, 275, 400, 325, 100, 0, 200, 50, 350, 3000, 175, 475, 300, 125, 75, 500 };
            angle = 0.0f;
        }

    }
    public class Player : IComparable
    {
        private string name;
        private int score;
        private int current_score;

        public Player(string _name)
        {
            name = _name;
        }
        public string Name
        {
            get { return name; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public int CurrentScore
        {
            get { return current_score; }
            set { current_score = value; }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Player))
            {
                throw new ArgumentException("Порівнюваний об'єкт не є гравцем.");
            }
            Player player = obj as Player;
            return Score.CompareTo(player.Score);
        }

        public void ResetScore()
        {
            score = 0;
        }
        public void ResetCurrentScore()
        {
            current_score = 0;
        }
    }


    // Клас питання
    public static class Questions
    {
        private static Dictionary<string, string> questions = new Dictionary<string, string>();
        private static string question;
        private static string answer;

        public static string Question
        {
            get { return question; }
        }
        public static string Answer
        {
            get { return answer; }
        }
        public static void LoadQuestions(string path)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    questions.Add(parts[0], parts[1]);
                }
            }
        }
        public static void ChooseQuestion()
        {
            Random random = new Random();
            int index = random.Next(questions.Count);
            KeyValuePair<string, string> randomQuestion = questions.ElementAt(index);
            question = randomQuestion.Key;
            answer = randomQuestion.Value;
            questions.Remove(question);
        }
    }

    public static class GameWheel
    {
        public static Kolo circule = new Kolo();
        private static float wheel_times;
        private static int points;

        public static float WheelTime
        {
            get { return wheel_times; }
            set { wheel_times = value; }
        }
        public static int Points
        {
            get { return points; }
            set { points = value; }
        }
        public static Bitmap RotateImage(Image image, float angle)
        {
            return RotateImage(image, new PointF((float)image.Width / 2, (float)image.Height / 2), angle);
        }
        public static Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));
            return rotatedBmp;
        }
    }
    public class Log
    {
        public List<string> log;

        public Log()
        {
            log = new List<string>();
        }
        public Log(List<string> _log)
        {
            log = _log;
        }

        public void AddNewRecord(string record)
        {
            log.Add(record);
        }
        internal static void StoreToTextFile(string fileName, List<string> log)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (string line in log)
                    writer.WriteLine(line);
            }
        }
        internal static void StoreToBinaryFile(string fileName, List<string> log)
        {
            IFormatter serializer = new BinaryFormatter();
            using (FileStream saveFile = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(saveFile, log);
            }
        }
        internal static void StoreToSoapFile(string fileName, List<string> log)
        {
            SoapFormatter serializer = new SoapFormatter();
            using (FileStream saveFile = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(saveFile, log.ToArray());
            }
        }

    }
    public class Game
    {
        private int player_index;
        private int current_round;
        private List<string> answer_array;
        private string level;
        private string file_path;
        private int current_score;
        private bool is_end_game;
        private List<Player> Players;
        private int unknown_letters;
        private bool is_end_round;
        public List<Log> logs;

        public int CurrentScore
        {
            get { return current_score; }
            set { current_score = value; }
        }
        public bool EndGame
        {
            get { return is_end_game; }
        }
        public bool EndRound
        {
            get { return is_end_round; }
            set { is_end_round = value; }
        }
        public int PlayerIndex
        {
            get { return player_index; }
        }
        public int CurrentRound
        {
            get { return current_round; }
        }
        public Player CurrentPlayer
        {
            get { return Players[player_index]; }
        }
        public List<string> AnswerArray
        {
            get { return answer_array; }
        }
        public List<Player> Player
        {
            get { return Players; }
        }
        public Game(string _level, List<Player> players)
        {
            logs = new List<Log>() { new Log(), new Log(), new Log() };
            current_round = 0;
            is_end_game = false;
            Players = players;
            switch (_level)
            {
                case "Легкий":
                    file_path = @"../../Questions/eassy.txt";
                    break;
                case "Середній":
                    file_path = @"../../Questions/middle.txt";
                    break;
                case "Важкий":
                    file_path = @"../../Questions/difficult.txt";
                    break;
            }
            Questions.LoadQuestions(file_path);
            Random rand = new Random();
            player_index = rand.Next(0, 3);
        }
        public void NewRound()
        {
            NewRoundPlay();
            NextPlayer();
            is_end_round = false;
            current_round += 1;
            Questions.ChooseQuestion();
            foreach (Player player in Players)
            {
                player.ResetCurrentScore();
            }
            answer_array = Questions.Answer.ToUpper().ToCharArray().Select(c => c.ToString()).ToList();
            unknown_letters = answer_array.Count();
            if (current_round == 3)
            {
                is_end_game = true;
            }
        }
        public string LetterClick(string letter)
        {
            bool guess = false;
            current_score = GameWheel.Points;
            int score = 0;
            foreach (string i in answer_array)
            {
                if (i == letter)
                {
                    score += current_score;
                    unknown_letters -= 1;
                    guess = true;
                }
            }
            if (unknown_letters == 0)
            {
                is_end_round = true;
            }
            if (guess)
            {
                GoodLetterPlay();
                Players[player_index].Score += score;
                Players[player_index].CurrentScore += score;
                AddNewRecord($"Літера {letter} є у слові");
                return $"Літера {letter} є у слові";
            }
            else
            {
                BadLetterPlay();
                AddNewRecord($"Літери {letter} немає у слові");
                NextPlayer();
                return $"Літери {letter} немає у слові";
            }

        }
        public bool CheckAnswer(string line)
        {
            current_score = GameWheel.Points;
            if (line == Questions.Answer)
            {
                GoodAnswerPlay();
                CurrentPlayer.Score += current_score * unknown_letters;
                CurrentPlayer.CurrentScore += current_score * unknown_letters;
                is_end_round = true;
                return true;
            }
            else
            {
                BadAnswerPlay();
                CurrentPlayer.ResetScore();
                CurrentPlayer.ResetCurrentScore();
                return false;
            }
        }
        public void NextPlayer()
        {
            if (player_index == 2)
            {
                player_index = 0;
            }
            else
            {
                player_index += 1;
            }
        }
        public void TakeCredit()
        {
            CurrentPlayer.CurrentScore -= 250;
            CurrentPlayer.Score -= 250;
        }
        public List<Player> Rating()
        {
            return Players.OrderByDescending(x => x).ToList();
        }
        public void AddNewRecord(string record)
        {
            logs[current_round - 1].AddNewRecord(record);
        }
        public Log CreateGeneralLog()
        {
            return new Log(logs[0].log.Concat(logs[1].log).Concat(logs[2].log).ToList());
        }
        private void NewRoundPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/NewRaund.wav");
            player.Play();
        }
        public void StopPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/Stop.wav");
            player.Play();
        }
        public void JackpotPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/Jeckpot.wav");
            player.Play();
        }
        private void GoodLetterPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/GoodLetter.wav");
            player.Play();
        }
        private void BadLetterPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/Bad.wav");
            player.Play();
        }
        private void GoodAnswerPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/GoodAnswer.wav");
            player.Play();
        }
        private void BadAnswerPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/BadAnswer.wav");
            player.Play();
        }
        public void GameOverPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/GameOver.wav");
            player.Play();
        }
        public void BankrutPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/Bankrut.wav");
            player.Play();
        }
        public void WheelSpinPlay()
        {
            SoundPlayer player = new SoundPlayer("../../Records/WheelSpin.wav");
            player.Play();
        }
    }
}
