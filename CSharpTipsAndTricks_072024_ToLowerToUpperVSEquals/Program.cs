using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using CSharpTipsAndTricks_072024_ToLowerToUpperVSEquals;

var config = DefaultConfig.Instance;
var summary = BenchmarkRunner.Run<Benchmarks>(config, args);

// Use this to select benchmarks from the console:
// var summaries = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
