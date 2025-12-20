using System.ComponentModel;
using Lab_13.Models;

namespace Lab_13.Extensions;

public static class OperatorExtensions
{
    public static string Description(this Operator value) =>
        ((DescriptionAttribute[])typeof(Operator)
            .GetField(value.ToString())!
            .GetCustomAttributes(typeof(DescriptionAttribute), false))[0]
            .Description;
}