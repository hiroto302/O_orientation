using System;

namespace P1
{
  class Tomato : Food
  {
    // コンストラクタ
    public Tomato() : base("トマト", 150f)
    {
    }
    // 特徴
    public string Features()
    {
      return "甘くて酸っぱい";
    }
  }
}