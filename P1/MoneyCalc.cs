using System;

namespace P1
{
  // カプセル化
  /*
  「値」と「ロジック」を一まとめにする
  インテリセンスから関数を選べる（C#における . でてくるやつ)
  どのようなロジックで税込計算はされているのか参照することですぐに把握できる
  */
  class MoneyCalc
  {
    // お金の値
    private float value;
    // コンストラクタ
    public MoneyCalc(float value)
    {
      this.value = value;
    }
    // プロパティ
    // 原価
    public float Value
    {
      get { return value;}
    }
    // 原価 + 消費税
    public float TaxValue
    {
      get { return value * 1.1f ;}
    }

  }
}