# Custom Console Example

## What is My Project?

This is an example project that demonstrates how to use a custom IConsole for System.CommandLine command line parser.

## Getting Started

To get started download a copy of the source.

## Building and Running

Once you have downloaded the source simple run using dotnet.  This project is built using net50.  If you are using a different version you may need to update the TargetFramework.

### Build the Project

To build:

```bash
dotnet build
```

### Running and Settings

This example project does not have any settings or configuration.

To run:

```bash
dotnet run -- --help
```

This results in the output:

```bash
Hello World!
custom-console-example
  Console app to demonstrate System.CommandLine.IConsole

Usage:
  custom-console-example [options]

Options:
  --version       Show version information
  -?, -h, --help  Show help and usage information
```
