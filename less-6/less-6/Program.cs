using System;
using System.Diagnostics;

namespace less_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("list - вывод запущенных процессов\nexit - выход\nkill /id [PID] - завершить процесс по ID\nkill /name [Имя образа] - завершить процесс по имени процесса");
            Console.WriteLine("".PadLeft(100, '-'));

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');

                if (command[0] == "list")
                {
                    Console.WriteLine("Имя образа".PadRight(25) + " " + "PID".PadLeft(9) + " " + "Имя сессии".PadRight(16) + " " + "№ сеанса".PadLeft(11) + " " + "Память".PadLeft(12));
                    Console.WriteLine("".PadRight(25, '=') + " " + "".PadLeft(9, '=') + " " + "".PadRight(16, '=') + " " + "".PadLeft(11, '=') + " " + "".PadLeft(12, '='));

                    Process[] processes = Process.GetProcesses();
                    for (int i = 0; i < processes.Length; i++)
                    {
                        Console.WriteLine(processes[i].ProcessName.Substring(0, processes[i].ProcessName.Length > 25 ? 25 : processes[i].ProcessName.Length).PadRight(25) + " " +
                            processes[i].Id.ToString().PadLeft(9) + " " +
                            GetSessionName(processes[i].SessionId).PadRight(16) + " " +
                            processes[i].SessionId.ToString().PadLeft(11) + " " +
                            ((processes[i].WorkingSet64 / 1024).ToString("#,#") + " КБ").PadLeft(12));
                    }
                    Console.WriteLine("".PadLeft(100, '-'));
                }
                else if (command[0] == "exit")
                {
                    return;
                }
                else if (command.Length > 2 && command[0] == "kill" && command[1] == "/id")
                {
                    try
                    {
                        Process.GetProcessById(Convert.ToInt32(command[2])).Kill();
                        Console.WriteLine($"Процесс с PID {command[2]} завершен...");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Ошибка завершения процесса с PID {command[2]}...");
                    }
                    Console.WriteLine("".PadLeft(100, '-'));
                }
                else if (command.Length > 2 && command[0] == "kill" && command[1] == "/name")
                {
                    Process[] processes = Process.GetProcessesByName(command[2]);
                    for (int i = 0; i < processes.Length; i++)
                    {
                        try
                        {
                            processes[i].Kill();
                            Console.WriteLine($"Процесс с PID {processes[i].Id} завершен...");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Ошибка завершения процесса с PID {processes[i].Id}...");
                        }
                    }
                    Console.WriteLine("".PadLeft(100, '-'));
                }
                else
                {
                    Console.WriteLine("Команда не найдена! Повторите ввод!");
                    Console.WriteLine("".PadLeft(100, '-'));
                }
            }
        }
        static string GetSessionName(int id)
        {
            if (id==0)
            {
                return "Services";
            }
            else if(id==1)
            {
                return "Console";
            }
            return "";
        }
    }
}
