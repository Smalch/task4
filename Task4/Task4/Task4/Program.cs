using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            AppConfig app = new AppConfig("1");
        }




        interface Editor
        {
            void Correct_Begin_End();
            static void Ex()
            {
                throw new Exception("Неправильные входные параметры");
            }

            void Color();

            void Check_s();

            void Check_toch();

            void Esckape();

            void Toch_ost();

            void Auto_kor();

            void Auo_dop();

            void Auto_save();

            void Pod_mis();
        }


        class SqlEditor : Editor
        {
            string[] mass_of_config;
            public SqlEditor(string[] mass_of_config)
            {
                this.mass_of_config = mass_of_config;
                Console.WriteLine("В SQL: ");
            }
            public void Correct_Begin_End()
            {
                if (mass_of_config[0]=="10")
                    Console.WriteLine("Проверка на соответствия begin и end включена");
                else
                    Console.WriteLine("Проверка на соответствия begin и end выключена");
            }

            public void Color()
            {
                switch (mass_of_config[1])
                {
                    case "r":
                        Console.WriteLine("Цвет красный");
                        break;
                    case "b":
                        Console.WriteLine("Цвет синий");
                        break;
                    case "o":
                        Console.WriteLine("Цвет оранжевый");
                        break;
                    default:
                        Editor.Ex();
                        break;
                }


            }

            public void Check_s() 
            {
                if (mass_of_config[2] == "s")
                    Console.WriteLine("Проверка select включена");
                else
                    Console.WriteLine("Проверка select выключена");
            }
            public void Check_toch()
            {}

            public void Esckape()
            {
                if (mass_of_config[4] == "es")
                    Console.WriteLine("Автотабуляция включена");
                else
                    Console.WriteLine("Автотабуляция выключена");
            }

            public void Toch_ost()
            {
                if (mass_of_config[5] == "toch_ost")
                    Console.WriteLine("Точки останова включены");
                else
                    Console.WriteLine("Точки останова выключены");
            }

            public void Auto_kor()
            {}
            public void Auo_dop() { }
            public void Auto_save()
            {
                if (mass_of_config[8] == "1")
                    Console.WriteLine("Автосохранение включено");
                else
                    Console.WriteLine("Автосохранение выключено");
            }

            public void Pod_mis() { }
        }

        class CsEditor : Editor
        {
            string[] mass_of_config;
            public CsEditor(string[] mass_of_config)
            {
                this.mass_of_config = mass_of_config;
                Console.WriteLine("В Cs: ");
            }

            public void Correct_Begin_End()
            {
                if (mass_of_config[0] == "12")
                    Console.WriteLine("Проверка на соответствия { и } включена");
                else
                    Console.WriteLine("Проверка на соответствия { и } выключена");
            }

            public void Color()
            {
                switch (mass_of_config[1])
                {
                    case "r":
                        Console.WriteLine("Цвет красный");
                        break;
                    case "b":
                        Console.WriteLine("Цвет синий");
                        break;
                    case "o":
                        Console.WriteLine("Цвет оранжевый");
                        break;
                    default:
                        Editor.Ex();
                        break;
                }


            }
            public void Check_s()
            {}

            public void Check_toch()
            {
                if (mass_of_config[3] == ";")
                    Console.WriteLine("Включена проверка на ;");
                else
                    Console.WriteLine("Выключена проверка на ;");
            }
            public void Esckape()
            {
                if (mass_of_config[4] == "es")
                    Console.WriteLine("Автотабуляция включена");
                else
                    Console.WriteLine("Автотабуляция выключена");
            }

            public void Toch_ost()
            {
                if (mass_of_config[5] == "toch_ost")
                    Console.WriteLine("Точки останова включены");
                else
                    Console.WriteLine("Точки останова выключены");
            }

            public void Auto_kor()
            {
                if (mass_of_config[6] == "avto_kor")
                    Console.WriteLine("Автокоррекция включена");
                else
                    Console.WriteLine("Автокоррекция выключена");
            }
            public void Auo_dop()
            {
                if (mass_of_config[7] == "dop")
                    Console.WriteLine("Автодописывание включены");
                else
                    Console.WriteLine("Автодописывание выключены");
            }

            public void Auto_save()
            {
                if (mass_of_config[8] == "1")
                    Console.WriteLine("Автосохранение включена");
                else
                    Console.WriteLine("Автосохранение выключена");
            }

            public void Pod_mis()
            {
                if (mass_of_config[9] == "mis")
                    Console.WriteLine("Подсветка ошибок включена");
                else
                    Console.WriteLine("Подсветка ошибок выключена");
            }
        }

        class HtmlEditor : Editor
        {
            string[] mass_of_config;
            public HtmlEditor(string[] mass_of_config)
            {
                this.mass_of_config = mass_of_config;
                Console.WriteLine("В HTML: ");
            }
            public void Correct_Begin_End()
            {
                if (mass_of_config[0] == "11")
                    Console.WriteLine("Проверка на соответствия { и } включена");
                else
                    Console.WriteLine("Проверка на соответствия { и } выключена");
            }
            public void Color()
            {
                switch (mass_of_config[1])
                {
                    case "r":
                        Console.WriteLine("Цвет красный");
                        break;
                    case "b":
                        Console.WriteLine("Цвет синий");
                        break;
                    case "o":
                        Console.WriteLine("Цвет оранжевый");
                        break;
                    default:
                        Editor.Ex();
                        break;
                }


            }
            public void Check_s()
            { }

            public void Check_toch()
            {
                if (mass_of_config[3] == ";")
                    Console.WriteLine("Включена проверка на ;");
                else
                    Console.WriteLine("Выключена проверка на ;");
            }
            public void Esckape()
            {
                if (mass_of_config[4] == "es")
                    Console.WriteLine("Автотабуляция включена");
                else
                    Console.WriteLine("Автотабуляция выключена");
            }

            public void Toch_ost()
            {
                if (mass_of_config[5] == "toch_ost")
                    Console.WriteLine("Точки останова включены");
                else
                    Console.WriteLine("Точки останова выключены");
            }

            public void Auto_kor()
            {
                if (mass_of_config[6] == "avto_kor")
                    Console.WriteLine("Автокоррекция включена");
                else
                    Console.WriteLine("Автокоррекция выключена");
            }
            public void Auo_dop()
            {
                if (mass_of_config[7] == "dop")
                    Console.WriteLine("Автодописывание включено");
                else
                    Console.WriteLine("Автодописывание выключено");
            }

            public void Auto_save()
            {
                if (mass_of_config[8] == "1")
                    Console.WriteLine("Автосохранение включено");
                else
                    Console.WriteLine("Автосохранение выключено");
            }

            public void Pod_mis()
            {
                if (mass_of_config[9] == "mis")
                    Console.WriteLine("Подсветка ошибок включена");
                else
                    Console.WriteLine("Подсветка ошибок выключена");
            }
        }

        class Client
        {
            public Client(Editor editor)
            {
                editor.Correct_Begin_End();
                editor.Color();

                editor.Check_s();

                editor.Check_toch();

                editor.Esckape();

                editor.Toch_ost();

                editor.Auto_kor();

                editor.Auo_dop();

                editor.Auto_save();

                editor.Pod_mis();
            }
        }



        class AppConfig
        { 
            public AppConfig(string start_address)
            {
                Console.WriteLine("Введите адрес файла источника");
                start_address = @"D:\test.html.txt";//Console.ReadLine();
                string[] mass_of_config = Read_String(start_address);
                if (mass_of_config.Length != 10)
                    throw new Exception("Неправильные входные параметры");

                Editor editor;

                switch (Coise(start_address))
                {
                    case "SQL":
                        editor = new SqlEditor(mass_of_config);
                        break;
                    case "CS":
                        editor = new CsEditor(mass_of_config);
                        break;
                    case "HTML":
                        editor = new HtmlEditor(mass_of_config);
                        break;
                    default:
                        throw new Exception("Неправильные входные параметры");
                }

                Client client = new Client(editor);
            }



            string Coise(string start_address)
            {
                string[] mas= start_address.Split('.');
                return mas[mas.Length-2].ToUpper();
            }



            string[] Read_String(string start_address)
            {
                string own_str;
                try
                {
                    using (StreamReader sr = new StreamReader(start_address))
                    {
                        own_str = sr.ReadToEnd();
                        return own_str.Split(' ');
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return Read_String(start_address);
                }
            }

        }








    }
}
