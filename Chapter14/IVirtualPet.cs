// ■リスト14-4：ポリモーフィズムを利用するための基底クラス（VirtualPetクラス）
 interface IVirtualPet
{
     string Name { get; }
     int Mood { get; set; }
     int Energy { get; set; }
   

      void Eat();
      void Play();
      void Sleep();
   
}
