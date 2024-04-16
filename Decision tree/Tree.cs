using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree {
    public class DecisionTree {
        internal Node curNode;
        internal Node CurNode { set { curNode = value; } }
        internal Node root;
        
        internal abstract class Node {

        }

        internal class QuestionNode : Node {
            public string question;
            public List<string> answers;
            public List<Node> nextQuestions;

            public QuestionNode(string question, List<string> answers) {
                this.question = question;
                this.answers = answers;
                nextQuestions = new List<Node>();
            }
        }

        internal class AnswerNode : Node {
            public string name;
            public string description;
            public string imgDestination;

            public AnswerNode(string name, string description, string imgDestination) {
                this.name = name;
                this.description = description;
                this.imgDestination = imgDestination;
            }
        }

        public DecisionTree() {
            Stack<Node> parentStack = new Stack<Node>();

            root = new QuestionNode("1. Вы предпочитаете экшн-игры или игры с пошаговым управлением?",
                new List<string>(){ "Экшн-игры", "Игры с пошаговым управлением" });

            curNode = root;
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("2. Какой тип пространства в играх вы предпочитаете?",
                new List<string>() { "2D", "3D" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("3. Какой вид камеры вы предпочитаете в 2D играх?",
                new List<string>() { "Вид сверху", "Вид сбоку" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("4. Вам нравятся игры с минимальным управлением?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("5. Вас привлекает серия игр \"Castlevania\"?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Vampire Survivors", "Пачками косить порождений ночи" +
                "и дожить до рассвета! Vampire Survivors — казуальная игра в стиле готического хоррора с элементами упрощенного" +
                "рогалика. Здесь каждое ваше решение может вызвать лавину последствий для орд монстров", "VampireSurvivours.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("6. Вас привлекает серия игр \"Diablo\"?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Halls of Torment", "Halls of Torment" +
                "предлагает окунуться в мир ужасающих монстров, в этом уникальном экшене с элементами roguelite," +
                "где в каждой игре вы будете сталкиваться с новыми вызовами и опасностями. Погрузитесь в темные и" +
                "безжалостные подземелья, где ждут вас лорды подземного мира.", "HallsofTorment.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("7. Вас привлекает мультяшная графика?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Brotato", "Brotato — аренный шутер с элементами" +
                "«рогалика», в котором вы играете за вооруженную картофелину, дающую отпор ордам пришельцев. Берите до 6 видов" +
                "оружия, выбирайте черты и предметы, придумывайте тактику и выживайте до прибытия подмоги.", "Brotato.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("8. Вам интересна игра \"Deep Rock Galactic\"?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Deep Rock Galactic: Survivor", "Deep Rock Galactic:" +
                "Survivor — одиночный автошутер с элементами выживания. Используйте весь арсенал Deep Rock Galactic, сражайтесь" +
                "с ордами чудовищ, добывайте ресурсы и открывайте мощные улучшения. Один крутой дворф против всей планеты", "DRGSurvivor.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Soulstone Survior", "Сразитесь с Владыками Бездны и" +
                "их несчетными приспешниками, соберите камни души и станьте богом! В этой Action Roguelite игре откройте секретные" +
                "заклинания, создайте могущественное оружие, откройте множество персонажей, откройте множество комбинаций", "SoulstoneSurvior.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("9. Вам интересна библейская тема?",
                new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("The Binding of Isaac: Repentance", "The Binding of Isaac:" +
                "Repentance создана на базе оригинальной игры и всех дополнений, при этом включает новые локации, персонажей, врагов," +
                "боссов и предметов. Сюжет, как и прежде, основан на библейском сказании про Авраама и Исаака. Немного переделана графика" +
                "и внесены некоторые правки в визуальный стиль и движок, из-за чего геймплей стал ощущать более плавнее и приятнее.", "Isaac.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("10. Вам интересно собирать собсвтенную армию?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Necrosmith 2", "Словно мертвец, оживлённый тёмной магией," +
                "симулятор некроманта возвращается! Даруйте мертвецам способность перелетать горы и переплывать реки, исследуйте" +
                "генерируемый мир ночью и отбивайтесь от орд врагов днём. Начните, хм… новую жизнь.", "Necrosmith2.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("11. Вам интересен сеттинг древней греции?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Hades", "Бросьте вызов богу мёртвых и прорубите себе" +
                "путь из Подземного мира в игре в жанрах «рогалик» и «данжен-кроулер» от создателей Bastion, Transistor и Pyre.", "Hades.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("12. Вам интересна минималистичная графика?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Tiny Rogues", "Tiny Rogues — это рогалик dungeon-crawler" +
                "в таком минималистичном пиксель-арт стиле, который предлагает на прохождение десять различных уровней, следующих" +
                "друг за другом, в попытке убить саму Смерть", "TinyRogues.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("13. Вам интересен сеттинг мутантов?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Nuclear Throne", "Nuclear Throne — игра в жанре roguelike-action" +
                "от студии Vlambeer, создателей инди-хитов Super Crate Box, Ridiculous Fishing и Luftrausers. Их новый проект —" +
                "одновременно самый большой и амбициозный за всю историю существования дуэта", "NuclearThrone.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Enter the Gugeon", "Enter the Gungeon - игра жанра “пулевая" +
                "завеса в подземелье”, в которой ищущие спасения неудачники стреляют, грабят, перекатываются и опрокидывают столы," +
                "чтобы добраться до легендарного сокровища Оружелья: оружия, которое может убить прошлое.", "ETG.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("14. Вам интересны игры с разрушаемым окружением?",
               new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("15. Вам интересны игры, где разрушение окружения является основой геймплея?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("16. Вы хотите жить под куполом или на отвесной стене?",
                new List<string>() { "Под куполом", "На отвесной стене" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Dome Keeper", "Dome Keeper сочетает в себе рогалик, экшен и" +
                "симулятор выживания. В игре также есть элементы жанра Tower Defense. Она использует научно-фантастический сеттинг и вид" +
                "сбоку. Действие происходит на мрачной планете с враждебной фауной.", "DomeKeeper.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Wall World", "Wall World сочетает в себе несколько жанров. В" +
                "этом инди-проекте есть элементы рогалика, Tower Defense и симулятора шахтера. В нём присутствует смена дня и ночи." +
                "Погодные условия тоже часто меняются.", "WallWorld.png"));

            curNode = parentStack.Peek();
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("17. Вам интересны игры с элементами \"песочницы\"?",
               new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Noita", "Noita — боевик с элементами «roguelike» с физическим" +
                "моделированием пикселей. Вы сражаетесь, исследуете различные места, расплавляете, сжигаете, замораживаете и испаряете" +
                "препятствия, используя заклинания.", "Noita.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Spelunky 2", "Spelunky 2 — сиквел оригинального платформера с" +
                "элементом rouge-like, в котором игроки исследуют самые разнообразные локации," +
                "пытаясь разгадать тайны древней цивилизации.", "Spelunky2.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("18. Интересны ли вам игры с различными альтернативными локациями?",
              new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("19. Интересна ли вам игра, где сложность растет каждую секунду?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Risk of Rain Returns", "Культовая roguelike-игра" +
                "Risk of Rain возвращается — она стала ещё больше и лучше! Новые стили игры, уникальная добыча, новые" +
                "выжившие, обновлённый многопользовательский режим", "RORReturns.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Dead Cells", "Dead Cells — это экшн-платформер " +
                "в жанре Rogue-lite и Metroidvania. Вас ждет огромный, постоянно меняющийся замок... Если, конечно, вы " +
                "сможете победить тех, кто встанет у вас на пути, в 2D-схватках в стиле Souls-lite.", "DeadCells.png"));

            curNode = parentStack.Peek();
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("20. Интересна ли вам игра с ведением родословной?",
               new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Rogue Legacy 2", "Rogue Legacy 2 — это то, что бывает," +
                " когда берешь Rogue Legacy и добавляешь «продолжение». После каждой смерти на смену вам приходит ваш отпрыск. " +
                "Дочь может родиться следопыткой-дальтоником, а сын — кулинаром-пацифистом.", "RogueLegacy2.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Skul: The Hero Slayer", "Помогите скелету Скалу в одиночку" +
                " расправиться с императорской армией и спасти своего короля из плена в игре на все времена — остросюжетном 2D-платформере " +
                "в жанре rogue-lite.", "Skul.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("21. Какой вид камеры вы предпочитаете в 3D играх?",
              new List<string>() { "От первого лица", "От третьего лица" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];   
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("22. Интересно ли вам поиграть в ритм-экшн?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("BPM: Bullets per Minute ", "BPM — это ритмичный шутер от " +
                "первого лица с элементами rogue-like-игр, в котором тебе предстоит вести огонь, прыгать и уклоняться от атак в ритме " +
                "эпического саундтрека в стиле рок. Отправляйся в случайно генерируемые подземелья", "BPM.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("23. Выберете предпочитаемый сеттинг игры от третьего лица:",
                new List<string>() { "Фэнтези", "Роботы", "Космос", "Животные", "Древний Египет", "Персия" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("24. Выберете предпочитаемый тип сражений в фэнтезийной игре::",
                new List<string>() { "Ближний бой", "Дальний бой" }));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Roboquest", "Roboquest - быстрый Шутер-Роуглайт в выжженном " +
                "мире будущего. Вы - перезагруженный Хранитель, готовый надрать металлические задницы! Сражайтесь бок о бок с другом " +
                "или в одиночку, и уничтожайте орды смертоносных ботов", "Roboquest.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Void Bastards", "Стратегический шутер в котором вам предстоит " +
                "провести заключенных «Пустотного ковчега» через опасную Туманность Саргассо. Игроку предстоит принимать различные решения, " +
                "заниматься собирательством, создавать предметы и управлять космическим кораблём в попытке выжить на просторах Саргассо.", "VoidBastards.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Gunfire Reborn", "Gunfire Reborn — это приключенческая многоуровневая " +
                "игра с элементами ролевой игры (RPG), Roguelite и шутера от первого лица (FPS). Игроки могут управлять героями, которые " +
                "обладают различными способностями, чтобы исследовать разнообразный геймплей.", "GunfireReborn.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Immortal Redneck", "Immortal Redneck — это шутер с элементами " +
                "жанра роуглайт, действие которого происходит в Египте. бешеный темп, аркадная атмосфера, случайно создаваемые подземелья," +
                " 9 классов с разными особенностями и дерево навыков", "ImmortalRedneck.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Sity of Brass", "Приключение-экшен от первого лица, " +
                "навеянное сказками Тысячи и одной ночи, от главных разработчиков BioShock.", "SityofBrass.png"));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Slasher's Keep", "Рубите, режьте, стреляйте и грабьте, " +
                "прокладывая себе путь в процедурно генерируемых подземельях! Нашпигуйте врагов шипами с помощью своего мешка", "SlasherKeep.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Ziggurat 2", "Используйте мощные орудия и заклинания, чтобы пробиться " +
                "через орды врагов, и изучить лабиринтоподобные подземелья в этом лихорадочном roguelite шутере от первого лица", "Ziggurat2.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("25. Вам нравится трек \"Crab Rave\"?",
              new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Crab Champions", "Прокладывайте себе путь по экзотическим островам, " +
                "сочетая плавное движение с быстрым темпом боя, чтобы стать чемпионом по борьбе с крабами в этом шутере от третьего лица с " +
                "элементами rogueplike.", "CrabChampions.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Risk of Rain 2", "Выберитесь с хаотичной неизвестной планеты, " +
                "отбиваясь от полчищ безумных монстров в одиночку или с друзьями. Неожиданным образом сочетайте найденные предметы и постигайте" +
                " все особенности персонажей, пока сами не станете разрушительной силой", "ROR2.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("26. Вам нравятся карточные игры?",
              new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("27. Интересны ли вам карточные игры с элементами \"Tower Defence\"?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("28. Интересны ли вам карточные игры-автобатлеры?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Heretic's Fork", "Уважаемый соискатель, мы рады пригласить вас на " +
                "позицию менеджера Ада. Вашей задачей будет наказывать грешников, используя нашу карточную компьютерную систему для " +
                "постройки адских башен. ", "HereticFork.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Monster Train", "Monster Train — стратегическая игра-«рогалик», " +
                "основанная на построении колод и имеющая свою изюминку. В захватывающем путешествии по Аду на поезде вам придется принимать " +
                "тактические решения, защищая несколько расположенных друг над другом полей сражений.", "MonsterTrain.png"));

            curNode = parentStack.Peek();
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("29. Карточная игра должна быть сосредоточена на геймплее?",
              new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("30. Карточная игра должна поддерживать режим совместной игры?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("HellCard", "Hellcard – это карточный «рогалик», поддерживающий режимы " +
                "одиночной и совместной игры. Покоряйте нарисованные подземелья в одиночку, с ИИ-соратниками или другими игроками", "HellCard.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("31. Вам нравится покер?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Balatro", "Покерная игра-«рогалик». Balatro — гипнотически увлекательная " +
                "игра с построением колод, где можно использовать нестандартные покерные комбинации, находить джокеров в решающие моменты и " +
                "запускать забойные, возмутительно мощные комбо.", "Balatro.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Slay the Spire", "Мы смешали жанры ККИ и «рогалик» в попытке предоставить " +
                "вам нашу лучшую одиночную карточную стратегию. Вам предстоит собрать уникальную колоду, встретить множество причудливых монстров, " +
                "найти разнообразные могущественные реликвии и повергнуть Шпиль!", "STS.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("32. Вам нравятся игры, преподносящие неожиданные сюрпризы?",
                new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Inscryption", "Inscryption – мрачное карточное приключение, в " +
                "котором roguelike с составлением колод, головоломки в духе квест-комнат и психологический хоррор смешались в пропитанный " +
                "кровью коктейль.", "Inscryption.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Loop Hero", "Лич заточил мир во вневременную петлю, и всех его " +
                "обитателей поглотил нескончаемый хаос. В вашем распоряжении растущая колода загадочных карт, с помощью которой вам предстоит " +
                "размещать врагов, здания и элементы ландшафта на пути отважного героя", "LoopHero.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("33. Вам нравятся стратегические игры?",
                new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("34. Вам нравятся градостроительные симуляторы?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Against the Storm", "Возродите цивилизацию и спасите ее от смертоносных " +
                "дождей в градостроительном симуляторе в мире темного фэнтези. В роли наместника королевы возглавьте людей, бобров, ящеров, " +
                "лис и гарпий и подчините себе природу.", "AgainsttheStorm.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("35. Хотите управлять космический кораблем?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("FTL: Faster Than Light", "Этот «двумерный симулятор космического " +
                "корабля» отправит ваш корабль и экипаж в полное славы и горьких поражений путешествие через " +
                "случайным образом генерируемую галактику.", "FTL.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Into the Breach", "Отразите угрозу, командуя могучими мехами из " +
                "будущего. В этой пошаговой стратегии каждая попытка спасти мир – это" +
                " новая ситуация, создаваемая случайным образом.", "IntotheBreach.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("36. Вам нравятся игры жанра \"Dungeon Crawler\"?",
                new List<string>() { "Да", "Нет" }));

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("37. Хотите ли иметь в игре элемента строительства и управления?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("38. Вы хотите управлять большим количеством персонажей?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Dwarf Fortress", "Самая глубокая и запутанная симуляция мира, которая" +
                " когда-либо создавалась. Постройте крепость и попытайтесь помочь своим гномам выжить в" +
                " тщательно сгенерированном мире", "DwarfFortress.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Darkest Dungeon", "Darkest Dungeon — сложная пошаговая ролевая roguelike-игра" +
                " с готической атмосферой, в которой приключения персонажей сказываются на их душевном здоровье. Вам предстоит собрать, " +
                "обучить и возглавить команду героев, у каждого из которых есть свои недостатки.", "DarkestDungeon.png"));

            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("39. Важна ли вам графика в \"Dungeon Crawler\"?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("40. Хотите ли иметь открытый мир в \"Dungeon Crawler\"?",
                new List<string>() { "Да", "Нет" }));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Rogue", "Термин roguelike появился в 1980-х благодаря игре Rogue — " +
                "фэнтезийному приключению про исследование подземелья, где уровни, а также объекты и враги, размещённые на локациях, " +
                "генерировались случайно.", "Rogue.png"));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[0];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Stoneshard", "Stoneshard – это сложная пошаговая RPG в открытом мире. " +
                "Вас ждёт суровая жизнь средневекового наёмника: путешествуйте по разорённому войной королевству, выполняйте контракты, " +
                "сражайтесь, залечивайте раны и развивайте персонажа", "Stoneshard.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("41. Вам нравятся ритм-игры?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Crypt of the Necrodancer", "Crypt of the NecroDancer — удостоенная " +
                "множества наград сложная ритм-игра в жанре «рогалик». Двигайтесь в такт музыке и выбивайте ритм на черепах врагов! Играйте " +
                "под великолепный саундтрек авторства Дэнни Барановски", "Necrodancer.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Pixel Dungeon", "Pixel Dungeon - захватывающая и чрезвычайно популярная " +
                "игра в жанре рогаликов. Исследуйте глубины Pixel Dungeon, собирайте полезные предметы и сражайтесь со свирепыми монстрами, " +
                "чтобы найти амулет Йендора", "PixelDungeon.png"));

            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Pop();
            curNode = parentStack.Peek();

            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("42. Вам нравятся пачинко-игры (например, Peggle)?",
               new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Peglin", "Peglin — это рогалик Пачинко. Сражайся с врагами, " +
                "собирай различные шары и разбивай штыри, чтобы наносить урон. Получай реликвии, которые радикально изменят игру и " +
                "гарантируют, что у тебя не будет двух одинаковых забегов.", "Peglin.png"));
            (curNode as QuestionNode).nextQuestions.Add(new QuestionNode("43. Вам нравятся игры с задачами комплектации инвентаря?",
                new List<string>() { "Да", "Нет" }));
            parentStack.Push(curNode);

            curNode = (curNode as QuestionNode).nextQuestions[1];
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Backpack Hero", "«Рогалик» про менеджмент инвентаря! Собирайте " +
                "редкие предметы, распределяйте их в рюкзаке и побеждайте врагов!", "BackpackHero.png"));
            (curNode as QuestionNode).nextQuestions.Add(new AnswerNode("Dicey Dungeon", "Стань огромным игральным кубиком на ножках" +
                " и сражайся до конца в постоянно меняющихся подземельях!", "DiceyDungeon.png"));

            parentStack.Clear();
            curNode = root;
        }

        public string getCurrentQuestion() {
            return (curNode is QuestionNode) ? (curNode as QuestionNode).question : "Ошибка";
        }

        public List<string> getCurrentAnswers() {
            return (curNode is QuestionNode) ? (curNode as QuestionNode).answers : new List<string>{"Ошибка"};
        }

        public List<string> getAnswerData() {
            if (curNode is AnswerNode) {
                AnswerNode tmp = curNode as AnswerNode;
                return new List<string>(){ tmp.name, tmp.description, tmp.imgDestination };
            }
            return new List<string>(){ "Ошибка" };
        }

        public string getCurrentType() {
            return (curNode is QuestionNode) ? "Question" : "Answer";
        }

        public void getNextNode(int index) {
            curNode = (curNode as QuestionNode).nextQuestions[index];
        }

        public void reset() {
            curNode = root;
        }
    }
}
