

namespace Model
{
    /// <summary>
    /// Класс Program
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            Book book1 = new Book("Филиппова А.Г", "История",
                "учебное пособие", "Москва", "Юнион", 2011, 126);

            Magazine magazine1 = new Magazine("Вопросы", "Научный журнал",
                "ООО 'Редация'", "Москва", "А.А. Искендеров", 2011, 518);

            Collection collection1 = new Collection(
                "Инновации", "Международная конференция",
                "Москва", "Московский Государственный Унверститет",
                2012, 58);

            Dissertation thesis1 = new Dissertation(
                "Филиппова А.Г", "Название диссертации",
                "диссертация на соискание ученой степени",
                "специальность 13.00.01 'Общая педагогика'",
                "Москва", "Кузбасская государственная педагогическая академия",
                2000, 255);

            var editionBases = new List<EditionBase>()
                { book1, magazine1, collection1, thesis1};
            foreach (EditionBase editionBase in editionBases)
            {
                Console.WriteLine("Класс - " +
                    editionBase.GetType().Name +
                    ":\n" + editionBase.GetInfo() + "\n");
            }
            _ = Console.ReadKey();

            var editionList = new List<EditionBase>();

            EditionBase editionObject = new Book();

            Action actionEditionType = new Action(() =>
            {
                Console.WriteLine("\n1 - Кинга;\n2 - Сборник;\n3 - Диссертация;\n" +
                    "4 - Журнал;\n");

                int editionType = int.Parse(Console.ReadLine());

                switch (editionType)
                {
                    case 1:
                        {
                            editionObject = new Book();
                            break;
                        }

                    case 2:
                        {
                            editionObject = new Collection();
                            break;
                        }

                    case 3:
                        {
                            editionObject = new Dissertation();
                            break;
                        }
                    case 4:
                        {
                            editionObject = new Magazine();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException
                                ("Пожалуйста, введите число от 1 до 4.");
                        }
                }
            });

            ActionHandler(actionEditionType, "Введите издание для добавления");



            var actionBook = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Book book = (Book)editionObject;
                    book.Author = Console.ReadLine();
                }), "Автор книги"),

                (new Action(() =>
                {
                    Book book = (Book)editionObject;
                    book.Name = Console.ReadLine();
                }), "Наименование"),

                (new Action(() =>
                {
                    Book book =  (Book)editionObject;
                    book.Type = Console.ReadLine();
                }), "Тип"),

                (new Action(() =>
                {
                    Book book = (Book)editionObject;
                    book.Place =Console.ReadLine();
                }), "Место публикации"),

                (new Action(() =>
                {
                    Book book = (Book)editionObject;
                    book.Publisher = Console.ReadLine();
                }), "Издатель"),

                (new Action(() =>
                {
                    Book book = (Book)editionObject;
                    book.Year = GetReadLineInt();
                }), "Год публикации"),

                (new Action(() =>
                {
                    Book book = (Book)editionObject;
                    book.PageCount = GetReadLineInt();
                }), "Кол-во страниц"),
            };

            var actionCollection = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Collection collection = (Collection)editionObject;
                    collection.Name = Console.ReadLine();
                }), "Название"),

                (new Action(() =>
                {
                    Collection collection = (Collection)editionObject;
                    collection.NameOfConference = Console.ReadLine();
                }), "Наименование конференции"),

                (new Action(() =>
                {
                    Collection collection = (Collection)editionObject;
                    collection.Place =Console.ReadLine();
                }), "Место публикации"),

                (new Action(() =>
                {
                    Collection collection = (Collection)editionObject;
                    collection.Publisher = Console.ReadLine();
                }), "Издатель сборника"),

                (new Action(() =>
                {
                    Collection collection = (Collection)editionObject;
                    collection.Year = int.Parse(Console.ReadLine());
                }), "Год издания"),

                (new Action(() =>
                {
                    Collection collection = (Collection)editionObject;
                    collection.PageCount = int.Parse(Console.ReadLine());
                }), "Кол-во страниц"),
            };

            var actionDissertation = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.Author = Console.ReadLine();
                }), "Автор диссертации"),

                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.Name = Console.ReadLine();
                }), "Название"),

                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.Type =Console.ReadLine();
                }), "Тип"),

                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.Specialization = Console.ReadLine();
                }), "Специализация исследования"),

                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.Place = Console.ReadLine();
                }), "Место публикации"),

                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.University = Console.ReadLine();
                }), "Университет"),

                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.Year = int.Parse(Console.ReadLine());
                }), "Год издания"),

                (new Action(() =>
                {
                    Dissertation dissertation = (Dissertation)editionObject;
                    dissertation.PageCount = int.Parse(Console.ReadLine());
                }), "Кол-во страниц"),
            };

            var actionMagazine = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Magazine magazine = (Magazine)editionObject;
                    magazine.Name = Console.ReadLine();
                }), "Наименование журнала"),

                (new Action(() =>
                {
                    Magazine magazine = (Magazine)editionObject;
                    magazine.Type = Console.ReadLine();
                }), "Тип"),

                (new Action(() =>
                {
                    Magazine magazine = (Magazine)editionObject;
                    magazine.Organization =Console.ReadLine();
                }), "Организация публикации"),

                (new Action(() =>
                {
                    Magazine magazine = (Magazine)editionObject;
                    magazine.Place = Console.ReadLine();
                }), "Место публикации"),

                (new Action(() =>
                {
                    Magazine magazine = (Magazine)editionObject;
                    magazine.Editor = Console.ReadLine();
                }), "Редактор журнала"),

                (new Action(() =>
                {
                    Magazine magazine = (Magazine)editionObject;
                    magazine.Year = int.Parse(Console.ReadLine());
                }), "Год издания"),

                (new Action(() =>
                {
                    Magazine magazine = (Magazine)editionObject;
                    magazine.PageCount = int.Parse(Console.ReadLine());
                }), "Кол-во страниц"),
            };

            foreach (EditionBase editionBase in editionList)
            {
                Console.WriteLine(
                    editionBase.GetType().Name +
                    "\n" + editionBase.GetInfo() + "\n");
            }

            var actionDictionary = new Dictionary
                <Type, List<(Action, string)>>
            {
                {typeof(Book), actionBook },
                {typeof(Collection), actionCollection},
                {typeof(Dissertation), actionDissertation},
                {typeof(Magazine), actionMagazine}
            };

            var tmpActionsCollection = actionDictionary
            [editionObject.GetType()];
            foreach (var action in tmpActionsCollection)
            {
                ActionHandler(action.Item1, action.Item2);
            }

            Console.Write($"\nДобавлено новое издание:\n" +
                $"{editionObject.GetInfo()}");

            _ = Console.ReadKey();
        }

        public static int GetReadLineInt()
        {
            return !int.TryParse(Console.ReadLine(), out int value)
                ? throw new ArgumentException
                   ("Ожидается ввод целого числа")
                : value;
        }


        /// <summary>
        /// Метод, который используется для выполнения action из списка.
        /// </summary>
        /// <param name="action">Action.</param>
        /// <param name="propertyName">Дополнительный параметр
        /// для вывода.</param>
        private static void ActionHandler
            (Action action, string propertyName)
        {
            while (true)
            {
                try
                {
                    Console.Write($"{propertyName}: ");
                    action.Invoke();
                    return;
                }
                catch (Exception exception)
                {
                    if (exception.GetType()
                        == typeof(ArgumentOutOfRangeException)
                        || exception.GetType() == typeof(Exception)
                        || exception.GetType() == typeof(ArgumentException))
                    {
                        Console.WriteLine($"Некоректный ввод: " +
                            $"{exception.Message}");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }
    }
}
