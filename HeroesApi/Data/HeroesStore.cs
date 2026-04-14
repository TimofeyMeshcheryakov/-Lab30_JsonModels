using HeroesApi.Models;



namespace HeroesApi.Data;

public static class HeroesStore {
    public static List<Hero> Heroes { get; } = new() {
        new Hero {
            Id = 1,
            Name = "Человек паук",
            RealName = "Питер Паркер",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new() { "паутина", "лазание по стенам", "паучье чутьё" },
            Weapon = new() { Name = "Паутинострел", IsRanged = true },
            InternalNotes = "Любимый герой редактора"
        },
        new Hero {
            Id = 2,
            Name = "Бэтмен",
            RealName = "Брюс Уэйн",
            Universe = Universe.DC,
            PowerLevel = 70,
            Powers = new() { "интеллект", "боевые искусства", "технологии" },
            Weapon = new() { Name = "Бэтаранг", IsRanged = true },
            InternalNotes = "Без суперсил, только деньги и упорство"
        },
        new Hero {
            Id = 3,
            Name = "Железный человек",
            RealName = "Тони Старк",
            Universe = Universe.Marvel,
            PowerLevel = 85,
            Powers = new() { "броня", "полёт", "интеллект", "лазеры" },
            Weapon = new() { Name = "Костюм Марк 50", IsRanged = true },
            InternalNotes = "Я - Железный человек"
        },
new Hero {
            Id = 4,
            Name = "Грут",
            RealName = "Грут",
            Universe = Universe.Marvel,
            PowerLevel = 80,
            Powers = new() { "регенерация", "управление деревом", "суперсила", },
            Weapon = new() { Name = "Ветви", IsRanged = false },
            InternalNotes = "Я есть Грут"
        },
new Hero {
            Id = 5,
            Name = "Енот",
            RealName = "Ракета",
            Universe = Universe.Marvel,
            PowerLevel = 65,
            Powers = new() { "броня", "полёт", "оружие", },
            Weapon = new() { Name = "Ранец", IsRanged = false },
            InternalNotes = "Не зови меня енотом"
        },
new Hero {
            Id = 6,
            Name = "Халк",
            RealName = "Доктор Брюс",
            Universe = Universe.Marvel,
            PowerLevel = 100,
            Powers = new() { "сила", "агрессия", "прыжок", },
            Weapon = new() { Name = "Шорты", IsRanged = true },
            InternalNotes = "Халк - смеешь"
        },
new Hero {
            Id = 7,
            Name = "Тор",
            RealName = "Тор Одинсон",
            Universe = Universe.Marvel,
            PowerLevel = 95,
            Powers = new() { "молния", "полёт", "суперсила", "бессмертие" },
            Weapon = new() { Name = "Мьёльнир", IsRanged = false },
            InternalNotes = "Бог грома"
        },
        };
    }