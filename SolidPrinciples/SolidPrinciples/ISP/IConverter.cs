﻿namespace SolidPrinciples.ISP
{
    public interface IConverter<in TFrom, out TTo>
    {
        TTo Convert(TFrom value);
    }
}