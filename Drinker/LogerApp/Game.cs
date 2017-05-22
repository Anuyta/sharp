using Drinker.Enums;
using LogerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinker
{
    public class Game
    {
        #region FIELDS
        static int run; //кол-во ходов в игре        
        private List<Card> cards = new List<Card>();
        private List<Player> players;
        private int countPlayers;
        #endregion

        #region CONSTRUCTORS
        static Game()
        {
            run = 0;            
        } 

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="countPlayers">count players</param>
        /// <param name="name">player names</param>
        public Game(int countPlayers, params string[] name)
        {
            if (countPlayers == 1 || countPlayers >= 5 || countPlayers != name.Count())
                throw new GameExceptions("Некорректное кол-во игроков");
            this.countPlayers = countPlayers;
            players = new List<Player>();
            
            for (int i = 0; i < countPlayers; i++)            
                players.Add(new Player(name[i]));
        }
        #endregion

        #region METHODS
        public void Start()
        {
            Logger.Write(Environment.UserName, System.Reflection.MethodBase.GetCurrentMethod().Name, TypeAction.Begin, "Игра началась!");
            CreateDeck();
            ShuffleDeck(cards);
            DealDeck();
            Battle(players);
        }

        /// <summary>
        /// Метод создания колоды
        /// </summary>
        private void CreateDeck()
        {
            Array suits = Enum.GetValues(typeof(Suit));
            Array values = Enum.GetValues(typeof(Value));

            for (int i = 0; i < suits.Length; i++)            
                for (int j = 0; j < values.Length; j++)                
                    cards.Add(new Card((Suit)suits.GetValue(i), (Value)values.GetValue(j)));
        }

        /// <summary>
        /// Метод моделирующий перетасовывание карт
        /// </summary>
        /// <param name="cards">уже существующая колода</param>
        /// <returns>перетасованную колоду</returns>
        public List<Card> ShuffleDeck(List<Card> cards)
        {
            Random rnd = new Random();            
            int countCard = cards.Count;
            for (int i = 0; i < countCard; i++)
            {                
                int index = rnd.Next(countCard);
                Card temp = cards[i];
                cards[i] = cards[index];
                cards[index] = temp;
            }            
            return cards;
        }

        /// <summary>
        /// Метод моделирующий раздачу карт игрокам
        /// </summary>
        public void DealDeck()
        {
            int countCard = cards.Count;
            for (int j = 0; j < countCard; )
            {
                for (int i = 0; i < players.Count; i++)
			    {
                    players[i].Cards.Add(cards[0]);
                    cards.RemoveAt(0);
                    j++;
			    }
            }
        }

        /// <summary>
        /// Метод моделирующий игру
        /// </summary>
        /// <param name="players">список игроков, принимающих участие в игре</param>
        public void Battle(List<Player> players)
        {           
            DateTime startGame = DateTime.Now;
            int indexWin = 0;
            
            while (players.Count() > 1)
            {
                List<Card> cardsRun = new List<Card>();                
                List<Card> cardsRunWin = new List<Card>();                
                run++;                
                DoCardsRun(cardsRun);
                DoCardsWinner(cardsRunWin, cardsRun); 

                int[] arrWin;
                indexWin = WinnerRun(cardsRun, out arrWin);

                while (arrWin.Count() != 0)
                {
                    List<Card> cardsRunSecond = new List<Card>();
                    DoCardsRun(cardsRunSecond, arrWin);                    
                    DoCardsWinner(cardsRunWin, cardsRunSecond);
                    indexWin = WinnerRun(cardsRunSecond, out arrWin);                    
                }

                ShuffleDeck(cardsRunWin);

                for (int k = 0; k < cardsRunWin.Count(); k++)
                    players[indexWin].Cards.Add(cardsRunWin[k]);                

                for (int i = 0; i < players.Count(); i++)
                {
                    if (PlayerHaveCards(players[i]) == false)
                        RemovePlayer(i);
                }
            }

            DateTime endGame = DateTime.Now;
            TimeSpan intervalGame = endGame - startGame;
            Logger.Write(players[0].Name, System.Reflection.MethodBase.GetCurrentMethod().Name, TypeAction.Ok, string.Format("Победил!!! Общее количество ходов составило {0}, время игры {1} ", run, intervalGame));
        }

        /// <summary>
        /// Метод, в котором формируется колода карт из тех, что выложены на стол
        /// </summary>
        /// <param name="cardsRun">пустая колода, которая заполнится внутри метода</param>
        /// <returns>колода карт со стола на данном ходе</returns>
        public List<Card> DoCardsRun(List<Card> cardsRun)
        {
            for (int i = 0; i < players.Count(); i++)
            {     
                cardsRun.Add(players[i].Cards[0]);
                players[i].Cards.RemoveAt(0);
            }
            return cardsRun;
        }

        /// <summary>
        /// Метод, в котором формируется колода карт из тех, что выложены на стол повторно
        /// </summary>
        /// <param name="cardsRun">пустая колода, которая заполнится внутри метода</param>
        /// <param name="arrWin">массив игроков, которые спорят повторно, т.к. сразу у них были одинаковые карты</param>
        /// <returns>колода карт со стола на данном ходе</returns>
        public List<Card> DoCardsRun(List<Card> cardsRun, int[] arrWin)
        {
            for (int i = 0, j = 0; i < players.Count(); i++)
            {
                if (PlayerHaveCards(players[i]) == true)
                {
                    if (arrWin.Length > j && i == arrWin[j])
                    {
                        cardsRun.Add(players[i].Cards[0]);
                        players[i].Cards.RemoveAt(0);
                        j++;
                    }
                    else
                        cardsRun.Add(null);
                }                                
            }
            return cardsRun;
        }

        /// <summary>
        /// Метод в котором формируется колода победителя определенного хода игры
        /// </summary>
        /// <param name="cardsRunWin">карты победителя(эти карты лягут в колоду выйгравшему игроку)</param>
        /// <param name="cardsRun">карты доп.хода, если победитель не был определен сразу</param>
        /// <returns>колода победителя</returns>
        public List<Card> DoCardsWinner(List<Card> cardsRunWin, List<Card> cardsRun)
        {
            for (int i = 0; i < cardsRun.Count; i++)
                if (cardsRun[i] != null)
                    cardsRunWin.Add(cardsRun[i]);
            return cardsRunWin;
        }

        /// <summary>
        /// Метод для проверки наличия карт у игрока
        /// </summary>
        /// <param name="player">конкретный игрок</param>
        /// <returns>true - если у игрока еще есть карты, false - если у игрока закончились карты</returns>
        public bool PlayerHaveCards(Player player)
        {
            if (player.Cards.Count() == 0)        
                return false;            
            return true;
        }

        /// <summary>
        /// Метод, удаляющий игрока из списка игроков
        /// </summary>
        /// <param name="index">индекс, по которому будет удален игрок</param>
        /// <returns>список оставшихся игроков</returns>
        public List<Player> RemovePlayer(int index)
        {
            Logger.Write(players[index].Name, System.Reflection.MethodBase.GetCurrentMethod().Name, TypeAction.Ok, string.Format("Закончились карты! Проиграл на {0} ходу", run));
            players.RemoveAt(index);
            return players;
        }

        /// <summary>
        /// Метод определяющий кто выйграл на данном ходе игры
        /// </summary>
        /// <param name="cardsRun">карты выложенные на стол</param>
        /// <param name="arrWin">выходной массив индексов нескольких победителей</param>
        /// <returns>индекс победителя, если он найден</returns>
        public int WinnerRun(List<Card> cardsRun, out int[] arrWin)
        {
            arrWin = new int[cardsRun.Count];
            for (int i = 0; i < arrWin.Count(); i++)
                arrWin[i] = -100;                

            int arrWinIndex = 0;
            for (int i = 0; i < cardsRun.Count - 1; i++)
            {
                for (int j = i + 1; j < cardsRun.Count; j++)
			    {
                    if (cardsRun[i] == null)
                        break;
                    if (cardsRun[i] != null && cardsRun[j] != null && cardsRun[i].CompareTo(cardsRun[j]) == 1)
                        cardsRun[j] = null;
                    else if (cardsRun[i] != null && cardsRun[j] != null && cardsRun[i].CompareTo(cardsRun[j]) == -1)
                        cardsRun[i] = null;
                    else if (cardsRun[i] != null && cardsRun[j] != null && cardsRun[i].CompareTo(cardsRun[j]) == 0)
                    {
                        if (!Array.Exists(arrWin, element => element == i))
                            arrWin[arrWinIndex++] = i;
                        if (!Array.Exists(arrWin, element => element == j))
                            arrWin[arrWinIndex++] = j;
                    }
                    else
                        break;
			    }
            }
            Array.Resize(ref arrWin, arrWinIndex);
          
            return cardsRun.IndexOf(cardsRun.Find(element => element != null));
        }
        #endregion
    }
}
