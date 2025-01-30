using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250130
{
    public class Board
    {
        public bool[] NineBoard;

        // 状態管理
        public void State()
        {

        }
    }

    public class  Player
    {
        public string name;
        public void NameCheck()
        {
            Console.WriteLine("名前を入力してください。");
            name = Console.ReadLine();
        }
    }

    public class Game
    {
        int[] TwoDice;
        // ダイスの処理
        private void Dice()
        {
            Random random = new Random();
            
            Console.WriteLine("ダイスを振ります");
            TwoDice = new int[2];
            for(int i=0;i<2;i++)
            {
                TwoDice[i] = random.Next(1, 6);
                Console.WriteLine($"{i + 1}個目：{TwoDice[i]}");
            }
        }
        public void GameStart()
        {
            Random rand = new Random();
            Board board = new Board();
            Player player = new Player();

            int Pcheck;
            int cCheck;

            // プレイヤーの名前を入力
            player.NameCheck();

            // マスの初期化
            //foreach(var i in board.NineBoard)
            //{
            //    board.NineBoard[i] = false;
            //}

            Console.WriteLine("GameStart");
            while(true)
            {
                // プレイヤーのターン
                Console.WriteLine("プレイヤーのターン");
                Dice();
                // 異なる目の場合
                if (TwoDice[0] != TwoDice[1])
                {
                    Console.WriteLine("どちらかを選択してください");
                    Console.WriteLine("出た目のマスを使う：１　合計を使う：２");
                    while (true)
                    {
                        Pcheck = int.Parse(Console.ReadLine());
                        if (Pcheck > 2 || Pcheck < 0)
                        {
                            Console.WriteLine("入力に誤りがあります。再度入力してください。");
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (Pcheck == 1)
                    {
                        Console.WriteLine("どちらの数字を使いますか？");

                    }
                    else
                    {
                        Console.WriteLine($"{TwoDice[0] + TwoDice[1]}をひっくり返します");
                    }
                }
                // ゾロ目の場合
                else
                {
                    Console.WriteLine("どちらかを選択してください");
                    Console.WriteLine("出た目のマスを使う：１　合計を使う：２");
                    while (true)
                    {
                        Pcheck = int.Parse(Console.ReadLine());
                        if (Pcheck > 2 || Pcheck < 0)
                        {
                            Console.WriteLine("入力に誤りがあります。再度入力してください。");
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (Pcheck == 1)
                    {
                        Console.WriteLine("どちらの数字を使いますか？");

                    }
                    else
                    {
                        Console.WriteLine($"{TwoDice[0] + TwoDice[1]}を元に戻します");
                    }
                }

                // CPUのターン
                Console.WriteLine("CPUのターン");
                Dice();
                cCheck = rand.Next(1,2);

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.GameStart();
        }
    }
}
