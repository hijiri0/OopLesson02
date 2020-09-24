// ■リスト14-5：ポリモーフィズムを利用するための派生クラス（FoodiePetクラス）
using System;

class FoodiePet : IVirtualPet  // VirtualPetクラスを継承
{
    public string Name { get; private set; }
    public int Mood { get;  set; }
    public int Energy { get;  set; }
    //コンストラクタ(親クラスのコンストラクタに名前を渡す)
    public FoodiePet(string name) 
    {
        Name = name;
        Mood = 5;
        Energy = 100;

    }

    public  void Eat()  // overrideを使って上書き定義
    {
        Mood += 3;
        Energy += 5;
        Console.WriteLine("FoodiePet.Eatメソッドが実行されました");
    }

    public  void Play()  // overrideを使って上書き定義
    {
        Mood -= 1;
        Energy -= 10;
        Console.WriteLine("FoodiePet.Playメソッドが実行されました");
    }

    public  void Sleep()  // overrideを使って上書き定義
    {
        Mood -= 1;
        Energy += 2;
        Console.WriteLine("FoodiePet.Sleepメソッドが実行されました");
    }
}
