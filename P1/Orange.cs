using System;

namespace P1
{
  class Orange : Food
  {
    // コンストラクタ
    public Orange() : base("みかん", 100f)
    {
    }
    // 特徴
    public string Features()
    {
      return "甘くて美味しい";
    }
  }
}