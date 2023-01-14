﻿using StrategyDesignPattern.Interfaces;

namespace StrategyDesignPattern.Services
{
    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName) 
            => Console.WriteLine($"Folder is compressed using Rar approach: '{compressedArchiveFileName}.rar' file is created");
    }
}
