namespace CasinoSim
{
    public partial class bJack : Form
    {

        private static int staticMoney()
        {
            return Money.buck;
        }


        int money = staticMoney();
        private void moneyEqual()
        {
            //Money.buck = money;
            cMoney.Text = "Money: " + Money.buck.ToString();

        }
        private void addMoney(int money)
        {
            Money.buck += money;
            cMoney.Text = "Money: " + Money.buck.ToString();
        }
        private void loseMoney(int money)
        {
            Money.buck -= money;
            cMoney.Text = "Money: " + Money.buck.ToString();


        }



        List<Cards> deck = new List<Cards>();
        List<Cards> hand = new List<Cards>();
        List<Cards> splitHand = new List<Cards>();
        List<Cards> dealerhand = new List<Cards>();
        bool boolSplitHand = false;
        bool boolStand = false;
        int dealerhandValue;
        int handValue;
        int splitHandValue;
        int betAmount;

        public enum TurnCount
        {
            PlayerTurn,
            EnemyTurn
        }
        TurnCount turn = TurnCount.PlayerTurn;


        public bJack()
        {
            InitializeComponent();
            moneyEqual();

            for (int i = 1; i < 14; i++)
            {
                Cards card = new Cards(i, "h");
                deck.Add(card);
            }
            for (int i = 1; i < 14; i++)
            {
                Cards card = new Cards(i, "d");
                deck.Add(card);
            }
            for (int i = 1; i < 14; i++)
            {
                Cards card = new Cards(i, "c");
                deck.Add(card);
            }
            for (int i = 1; i < 14; i++)
            {
                Cards card = new Cards(i, "s");
                deck.Add(card);
            }

            addToDelearHand(2);
            addToHand(2);

        }
        private void nextTurn()
        {
            if (Money.buck>=0)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            blackjacLlabel.Text = "";

            moneyEqual();
            if (turn.Equals(TurnCount.EnemyTurn))
            {

                foreach (Cards item in dealerhand)
                {
                    if (item.ToString().Equals("1"))
                    {
                        item.Ace = true;
                    }
                    int aceTotal = dealerhandValue + 10;
                    if (item.Ace == true && aceTotal > 22)
                    {
                        dealerhandValue += 10;
                    }

                }


                if (dealerhandValue < 17)
                {
                    addToDelearHand(1);
                    turn = TurnCount.PlayerTurn;
                }
                else if (dealerhandValue > 21)
                {
                    winner();

                }
                else if (dealerhandValue == 21)
                {
                    loser();
                }

            }

            else if (turn.Equals(TurnCount.PlayerTurn))
            {
                foreach (Cards item in hand)
                {
                    if (item.ToString().Equals("1"))
                    {
                        item.Ace = true;
                    }
                    int aceTotal = handValue + 10;

                    if (item.Ace == true && aceTotal > 22)
                    {
                        handValue += 10;
                    }
                }

                if (boolStand && dealerhandValue > handValue)
                {
                    loser();
                }

                if (handValue > 21)
                {
                    loser();
                }
                if (handValue < 21 && hand.Count >= 5)
                {
                    winner();
                }
                if (handValue == 21)
                {
                    winner();
                }

                if (boolSplitHand)
                {
                    {
                        foreach (Cards item in splitHand)
                        {
                            if (item.ToString().Equals("1"))
                            {
                                item.Ace = true;
                            }
                            int aceTotal = splitHandValue + 10;

                            if (item.Ace == true && aceTotal > 22)
                            {
                                splitHandValue += 10;
                            }
                        }

                        if (boolStand && dealerhandValue > splitHandValue)
                        {
                            loser();
                        }

                        if (splitHandValue > 21)
                        {
                            loser();
                        }
                        if (splitHandValue < 21 && splitHand.Count >= 5)
                        {
                            winner();
                        }
                        if (splitHandValue == 21)
                        {
                            winner();
                        }
                    }
                }

                Console.WriteLine("Your hand value: " + handValue + " dealer hand value: " + dealerhandValue);
            }
        }


        public void winner()
        {
            addMoney(betAmount * 2);
            betAmount = 0;


        }
        public void winner(string blackjack)
        {
            addMoney(betAmount * 3);
            blackjacLlabel.Text = "BlackJack!!!";
            betAmount = 0;

        }
        public void loser()
        {
            betAmount = 0;
        }


        private void bJack_Load(object sender, EventArgs e)
        {

        }

        private void DDBtn_Click(object sender, EventArgs e)
        {
            betAmount *= 2;
            boolStand = true;
            addToHand(1);
        }

        private void splitBtn_Click(object sender, EventArgs e)
        {
            if (hand.Count > 3)
            {
                int card1 = int.Parse(hand[0].ToString());

                int card2 = int.Parse(hand[1].ToString());

                if (card1 == card2)
                {
                    boolSplitHand = true;
                    addToHand(1);
                }
            }
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            string moneyText = moneyBox.Text;
            int betAmount = int.Parse(moneyText);

            loseMoney(betAmount);

            moneyEqual();
        }

        private void hitBtn_Click(object sender, EventArgs e)
        {
            if (turn.Equals(TurnCount.PlayerTurn))
            {

                addToHand(1);
            }
            turn = TurnCount.EnemyTurn;

        }

        private void standBtn_Click(object sender, EventArgs e)
        {
            if (turn.Equals(TurnCount.PlayerTurn))
            {
                addToHand(0);
                turn = TurnCount.EnemyTurn;
            }
        }

        private void addToHand(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random r = new Random();
                int ran = r.Next(0, deck.Count - 1);
                hand.Add(deck[ran]);
                deck.RemoveAt(ran);

                if (boolSplitHand)
                {
                    ran = r.Next(0, deck.Count - 1);
                    splitHand.Add(deck[ran]);
                    deck.RemoveAt(ran);
                }


            }
            handValue = setValueOfHand(hand);
            if (boolSplitHand)
            {
                splitHandValue = setValueOfHand(splitHand);
            }
        }
        private void addToDelearHand(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Random r = new Random();
                int ran = r.Next(0, deck.Count - 1);
                dealerhand.Add(deck[ran]);
                deck.RemoveAt(ran);
                dealerhandValue = setValueOfHand(dealerhand);
            }
        }

        private void betAmount_TextChanged(object sender, EventArgs e)
        {

        }

        public int setValueOfHand(List<Cards> hand)
        {
            int totalValue = 0;
            foreach (var item in hand)
            {
                totalValue += item.returnValue();
            }
            return totalValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}