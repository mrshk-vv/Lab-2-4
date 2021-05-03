using System.Collections.Generic;

namespace DomainModel.Mock
{
    public class MockData
    {
        public class Stundents
        {
            public static readonly List<string> Surnames = new List<string>
            {
                "Иванов",
                "Петров",
                "Cпирдонов",
                "Дудченко",
                "Басанец",
                "Мурашко",
                "Черненко"
            };

            public static readonly List<string> Names = new List<string>
            {
                "Владмимир",
                "Руслан",
                "Виталий",
                "Андрей",
                "Александр",
                "Даниил",
                "Василий"
            };

            public static readonly List<string> Patronymics = new List<string>
            {
                "Владимирович",
                "Русланович",
                "Витальевич",
                "Андреевич",
                "Александрович",
                "Данилович",
                "Васильевич"
            };
        }
    }
}
