using System;

public static class Program {
    public static void Main(string[] args) {
        string message = "";
        if (args.Length < 1) {
            message = "Welcome to NHK!";
        } else {
            foreach (string item in args) {
                message +=item;
            }
        }

        Console.WriteLine(message);
    }
}

