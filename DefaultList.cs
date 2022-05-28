using AksonPriceList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AksonPriceList
{
    internal static class DefaultList
    {
        public static void UploadDefaultData(MedicamentFileProvider provider)
        {
            provider.Add(new MedicamentModel()
            {
                Name = "Доктор Мом",
                Country = "Russia",
                Price = 200.428M,
                Composition = new List<string>()
            {
                "Сироп",
                "Гидрохроматин",
                "Глицерин",
                "Парацетомол"
            },
                Recomendations = new Dictionary<string, List<string>>()
            {
                {
                    "60 лет", new List<string>()
                    {
                        "Употреблять после приёма пищи",
                        "не смешивать с другими таблетками"
                    }
                },
                {
                    "16 лет", new List<string>()
                    {
                        "Употреблять строго по инструкции",
                        "Противопоказано при стоматите",
                        "Противопоказано при наличии сердечно-сосудистых заболеваний"
                    }
                }
            }
            }, false);

            provider.Add(new MedicamentModel()
            {
                Name = "Мазь Фенистил",
                Country = "Швейцария",
                Price = 1119.20M,
                Composition = new List<string>()
                {
                    "Диметиндена малеат 1.0мг",
                    "1мл - 1мг диметиндена",
                    "Натрия гидрофосфата додекагидрат 16.0мг",
                    "Лимонной кислоты моногидрат 5.0мг"
                },
                Recomendations = new Dictionary<string, List<string>>()
                {
                    { 
                        "Все возраста", new List<string>()
                        {
                            "Противопоказано при кожном зуде",
                            "Противопоказано при кори",
                            "Противопоказано при атопическом дерматите",
                            "Противопоказано при крапивнице"
                        }
                    }
                }
            });

            provider.Add(new MedicamentModel()
            {
                Name = "Флуконазол",
                Country = "Россия",
                Price = 150.80M,
                Composition = new List<string>()
                {
                    "Флуконазол",
                    "Натрия лаурил",
                    "Лактоза"
                },
                Recomendations = new Dictionary<string, List<string>>()
                {
                    { 
                        "до 18ти лет", new List<string>() 
                        {
                            "Полностью противопоказано"
                        } 
                    },
                    {
                        "18+", new List<string>()
                        {
                            "У больных пожилого возраста при отсутствии нарушений функции почек следует придерживаться обычного режима дозирования препарата",
                            "Противопоказан в период лактации",
                            "Запрещен одновременный приём терфенадина"
                        }
                    }
                }
            });

            provider.Add(new MedicamentModel()
            {
                Name = "Аторвастатин-сз таблетки",
                Country = "Россия",
                Price = 176.20M,
                Composition = new List<string>()
                {
                    "Аторвастатин кальция",
                    "Лактозы моногидрат",
                    "Кальция каронат",
                    "Натрия стеарилфумарат",
                    "Кроскармеллоза натрия"
                },
                Recomendations = new Dictionary<string, List<string>>()
                {
                    {
                        "16 лет", new List<string>()
                        {
                            "Непереносимость лактозы",
                            "Повышенная чувствительность к сое и арахису"
                        }
                    },
                    {
                        "18 лет", new List<string>()
                        {
                            "Активное заболевание печени"
                        } 
                    },
                    {
                        "18+", new List<string>()
                        {
                            "Противопоказан при беременности",
                            "Повышенная чувствительность к любому компоненту препарата",
                            "Рекомендуется при профилактики сердечно-сосудистых осложнений у пациентов с ИБС"
                        }
                    }
                }
            });

            provider.Add(new MedicamentModel()
            {
                Name = "Гулиум-хель капли",
                Country = "Германия",
                Price = 1034M,
                Composition = new List<string>()
                {
                    "Галиум апарине 4г",
                    "Галиум моллуго 4г",
                    "Седум акре 5г",
                    "Семпервиум текторум 5г",
                    "Юниперус палюстрис 5г",
                    "Кольциум флюоратум"
                },
                Recomendations = new Dictionary<string, List<string>>()
                {
                    {
                        "Все возраста", new List<string>()
                        {
                            "Противопоказан при чувствительности к любым компонентам препарате",
                            "Противопоказано применение при беременности и лактации"
                        }
                    }
                }
            });
        }
    }
}
