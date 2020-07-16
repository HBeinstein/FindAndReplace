using System.Collections.Generic;
using System;

namespace FindAndReplace.Models
{
  public class Sentence
  {

    public string SentenceInput { get; set; }

    public Sentence(string input)
    {
      SentenceInput = input;
    }

  }
}