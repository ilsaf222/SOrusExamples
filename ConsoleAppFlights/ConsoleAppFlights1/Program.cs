﻿using ConsoleAppFlights1.Data;
using ConsoleAppFlights1.Ui;

namespace ConsoleAppFlights1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface(new DataContext());

            while (ui.ReadCommand())
            {
                ui.ExecuteCommand();
            }
        }
    }
}
