using System.ComponentModel;
using Lab_13.Extensions;

namespace Lab_13.Models;

public class Quiz
{
    private readonly int _firstNumber;
    private readonly int _secondNumber;
    private readonly Operator _operator;
    private readonly int _result;

    public Quiz()
    {
        var random = new Random();

        _firstNumber = random.Next(-100, 101);
        _secondNumber = random.Next(-100, 101);
        _operator = (Operator)random.Next(typeof(Operator).GetFields().Length - 1);

        _result = _operator switch
        {
            Operator.Plus => _firstNumber + _secondNumber,
            Operator.Minus => _firstNumber - _secondNumber
        };
    }

    public int Answer { get; set; }

    public bool IsRight => _result == Answer;

    public override string ToString() =>
        $"{_firstNumber} {_operator.Description()} " +
        (_operator == Operator.Minus && _secondNumber < 0 ?
            $"({_secondNumber})" : _secondNumber.ToString());
}

public enum Operator
{
    [Description("+")]
    Plus,
    [Description("-")]
    Minus
}