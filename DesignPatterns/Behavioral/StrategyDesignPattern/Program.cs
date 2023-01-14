using StrategyDesignPattern.Services;
using StrategyDesignPattern.StrategyContexts;

CompressionContext ctx = new CompressionContext(new ZipCompression());
ctx.CreateArchive("StrategyDesignPattern");
ctx.SetStrategy(new RarCompression());
ctx.CreateArchive("StrategyDesignPattern");
Console.Read();