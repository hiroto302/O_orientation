using System;

namespace P1
{
  // 抽象クラス 食べ物
  abstract class Food
  {
    // 商品 名
    private string name;
    // 商品 価格
    private float value;
    // コンストラクタ
    public Food(string name, float value)
    {
      this.name = name;
      this.value = value;
    }
    // プロパティ
    public string Name
    {
      get {return name;}
    }
    public float Value
    {
      get {return value;}
    }
  }
}