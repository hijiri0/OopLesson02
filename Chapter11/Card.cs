// ■リスト11-1：構造体を定義する
// Card構造体
//CardSuit列挙型の定義
enum CardSuit
{
    Club,
    Spade,
    Heart,
    Diamond
}





struct Card  // structキーワードで構造体を定義
{
    // プロパティ
    public  CardSuit Suit { get; private set; }   // 読み取り専用プロパティ
    public int Number { get; set; }  // 読み取り専用プロパティ

    // コンストラクター
    public Card(CardSuit suit, int number)
    {
        Suit = suit;  // コンストラクターでSuitとNumberの値を初期化
        Number = number;
    }

    // メソッド
    public void Print()  // 構造体にもメソッドを定義できる
    {
        var s = "";
        switch (Suit)
        {
            case CardSuit.Heart:
                s = "ハート";
                break;
            case CardSuit.Diamond:
                s = "ダイヤ";
                break;
            case CardSuit.Spade:
                s = "スペード";
                break;
            case CardSuit.Club:
                s = "クラブ";
                break;
        }









        System.Console.WriteLine($"{s} {Number}");
    }
}
