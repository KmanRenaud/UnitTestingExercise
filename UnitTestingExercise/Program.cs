using System;
using System.Threading;


Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Clear();


string intro = "Hello! This is a really cool message that I'm about to show you......";
string stringystring = "\r\n  ██████  █    ██  ██▓███  ▓█████  ██▀███   ▄████▄   ▒█████   ▒█████   ██▓     ███▄ ▄███▓▓█████   ██████   ██████  ▄▄▄        ▄████ ▓█████  ▐██▌ \r\n▒██    ▒  ██  ▓██▒▓██░  ██▒▓█   ▀ ▓██ ▒ ██▒▒██▀ ▀█  ▒██▒  ██▒▒██▒  ██▒▓██▒    ▓██▒▀█▀ ██▒▓█   ▀ ▒██    ▒ ▒██    ▒ ▒████▄     ██▒ ▀█▒▓█   ▀  ▐██▌ \r\n░ ▓██▄   ▓██  ▒██░▓██░ ██▓▒▒███   ▓██ ░▄█ ▒▒▓█    ▄ ▒██░  ██▒▒██░  ██▒▒██░    ▓██    ▓██░▒███   ░ ▓██▄   ░ ▓██▄   ▒██  ▀█▄  ▒██░▄▄▄░▒███    ▐██▌ \r\n  ▒   ██▒▓▓█  ░██░▒██▄█▓▒ ▒▒▓█  ▄ ▒██▀▀█▄  ▒▓▓▄ ▄██▒▒██   ██░▒██   ██░▒██░    ▒██    ▒██ ▒▓█  ▄   ▒   ██▒  ▒   ██▒░██▄▄▄▄██ ░▓█  ██▓▒▓█  ▄  ▓██▒ \r\n▒██████▒▒▒▒█████▓ ▒██▒ ░  ░░▒████▒░██▓ ▒██▒▒ ▓███▀ ░░ ████▓▒░░ ████▓▒░░██████▒▒██▒   ░██▒░▒████▒▒██████▒▒▒██████▒▒ ▓█   ▓██▒░▒▓███▀▒░▒████▒ ▒▄▄  \r\n▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ▒▓▒░ ░  ░░░ ▒░ ░░ ▒▓ ░▒▓░░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░░ ▒░   ░  ░░░ ▒░ ░▒ ▒▓▒ ▒ ░▒ ▒▓▒ ▒ ░ ▒▒   ▓▒█░ ░▒   ▒ ░░ ▒░ ░ ░▀▀▒ \r\n░ ░▒  ░ ░░░▒░ ░ ░ ░▒ ░      ░ ░  ░  ░▒ ░ ▒░  ░  ▒     ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░░  ░      ░ ░ ░  ░░ ░▒  ░ ░░ ░▒  ░ ░  ▒   ▒▒ ░  ░   ░  ░ ░  ░ ░  ░ \r\n░  ░  ░   ░░░ ░ ░ ░░          ░     ░░   ░ ░        ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   ░      ░      ░   ░  ░  ░  ░  ░  ░    ░   ▒   ░ ░   ░    ░       ░ \r\n      ░     ░                 ░  ░   ░     ░ ░          ░ ░      ░ ░      ░  ░       ░      ░  ░      ░        ░        ░  ░      ░    ░  ░ ░    \r\n                                           ░                                                                                                     \r\n";
foreach (var item in intro)
{
    Thread.Sleep(75);
    Console.Write(item);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
foreach (var item in stringystring)
{
    Thread.Sleep(1);
    Console.Write(item);
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Thread.Sleep(10000);