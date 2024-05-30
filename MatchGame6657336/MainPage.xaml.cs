namespace MatchGame6657336
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐶","🐶",
                "🐵","🐵",
                "🦐","🦐",
                "🐘","🐘",
                "🦓","🦓",
                "🦒","🦒",
                "🐍","🐍",
                "🐬","🐬"
            };
            Random random = new Random();
            foreach (Button view in Grid1.Children)
            {
                int index = random.Next(animalEmoji.Count);

                string nextEmoji = animalEmoji[index];

                view.Text = nextEmoji;

                animalEmoji.RemoveAt(index);
            }
        }

        Button ultimoButtonClicked;
        bool encontrandoMatch = false;

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (encontrandoMatch == false)
            {
                button.IsVisible = false;
                ultimoButtonClicked = button;
                encontrandoMatch = true;
            }else if(button.Text == ultimoButtonClicked.Text)
            {
                button.IsVisible = false;
                encontrandoMatch = false;
            }
            else
            {
                ultimoButtonClicked.IsVisible = true;
                encontrandoMatch = false; 
            }
        }
    }
}