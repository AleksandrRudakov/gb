using System;
using System.IO;
using Newtonsoft.Json;

namespace less_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "tasks.json";

            ToDo[] taskArray = taskList(filename);

            Console.WriteLine("Возможные действия:\n1 - прочитать список задач\n2 - добавить задачу\n3 - выполнить задачу\n4 - очистить список задач\n5 - выйти");
            while (true)
            {
                Console.WriteLine("Выберите следующее действие");
                char symbol = Console.ReadKey(true).KeyChar;

                if (symbol=='1')
                {
                    taskArray = taskList(filename);
                }
                else if (symbol == '2')
                {
                    Console.WriteLine("Введите наименование задачи:");
                    string taskName = Console.ReadLine();
                    ToDo newTask = new ToDo(taskName, false);
                    for (int i = 0; i < taskArray.Length; i++)
                    {
                        if (taskArray[i] == null)
                        {
                            taskArray[i] = newTask;
                            break;
                        }
                    }
                    saveTask(taskArray, filename);
                }
                else if (symbol == '3')
                {
                    Console.WriteLine("Введите номер задачи:");
                    string taskNumberStr = Console.ReadLine();
                    int taskNumber;
                    if (Int32.TryParse(taskNumberStr, out taskNumber)==true)
                    {
                        try
                        {
                            taskArray[taskNumber - 1].isDone = true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Некорректный ввод номера!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод номера!");
                    }
                    saveTask(taskArray, filename);
                }
                else if (symbol == '4')
                {
                    taskArray = new ToDo[100];
                    Console.WriteLine("Список задач очищен!");
                    saveTask(taskArray, filename);
                }
                else if (symbol == '5')
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }

        static void saveTask(ToDo[] taskArray, string filename)
        {
            string json = JsonConvert.SerializeObject(taskArray);
            File.WriteAllText(filename, json);
        }

        static ToDo[] taskList(string filename)
        {
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                ToDo[] taskArray = JsonConvert.DeserializeObject<ToDo[]>(json);

                for (int i = 0; i < taskArray.Length; i++)
                {
                    if (taskArray[i]?.isDone==true)
                    {
                        Console.WriteLine($"[x] {i+1}. " + taskArray[i].title);
                    }
                    else if (taskArray[i]?.isDone == false)
                    {
                        Console.WriteLine($"{i+1}. " + taskArray[i].title);
                    }
                }
                return taskArray;
            }
            else
            {
                return new ToDo[100];
            }
        }
    }

    public class ToDo
    {
        private string _title;
        public string title { get; set; }

        private bool _isDone;
        public bool isDone { get; set; }

        public ToDo(string p_title, bool p_isDone)
        {
            title = p_title;
            isDone = p_isDone;
        }
    }
}
