﻿using Story;
using System;
using System.Threading;

namespace Story_.ActionM_V_T
{
    class Text
    {
        public static void Text_()
        {
            Washbasin washbasin = new Washbasin();
            Brushes brushes = new Brushes();
            Soap soap = new Soap();
            Crocodyle crocodyle = new Crocodyle();
            Pie pie = new Pie();
            

            //Console.WriteLine();
            //Console.WriteLine();
            //Thread.Sleep(700);
            //Console.WriteLine("\t\tОдеяло убежало,");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tУлетела простыня,");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tИ подушка, как лягушка,");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tУскакала от меня.");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tЯ за свечку, Свечка — в печку!");
            //Thread.Sleep(1500);
            //Console.WriteLine();
            //Console.WriteLine("\t\tЯ за книжку, Та — бежать");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tИ вприпрыжку под кровать!");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tЯ хочу напиться чаю, к самовару подбегаю, ");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tК самовару подбегаю, а пузатый от меня,");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tУбежал, как от огня.");
            //Thread.Sleep(1500);
            //Console.WriteLine();
            //Console.WriteLine("\t\tЧто такое, что случилось ? ");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tОтчего же всё кругом завертелось, ");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tЗакружилось и помчалось колесом ? ");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tУтюги за сапогами, сапоги за пирогами, ");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tПироги за утюгами, кочерга за кушаком — ");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tВсё вертится, и кружится, ");
            //Thread.Sleep(1500);
            //Console.WriteLine("\t\tИ несётся кувырком. ");
            //Console.WriteLine();
            //Console.Write("\t\tContinue (enter/esc)");
            //Action();
            //Console.Clear();
            //Console.WriteLine();
            //Console.WriteLine();
            Thread.Sleep(700);
            Console.WriteLine("\t\tВдруг из маминой из спальни,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tКривоногий и хромой, выбегает умывальник");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ качает головой:");
            Thread.Sleep(1500);
            try
            {
                Console.WriteLine($"\t\t«Ах ты, {washbasin.ToString()}, ах ты, {washbasin.ToString()}, Неумытый поросёнок!");
            }
            catch (IteractionException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\t\terror: {ex.Message}");
                Console.ResetColor();
            }

            Thread.Sleep(1500);
            Console.WriteLine();
            Console.WriteLine($"\t\tТы чернее {washbasin.IteractionToStringW_0()}, полюбуйся на себя:");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tУ тебя на шее вакса, у тебя под носом клякса,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tУ тебя такие руки, что сбежали даже брюки,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tДаже брюки, даже брюки убежали от тебя.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tРано утром на рассвете умываются котята,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ мышата, и утята, и жучки, и паучки.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tТы один не умывался и грязнулею остался,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ сбежали от грязнули и чулки и башмаки.");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\tЯ — Великий Умывальник, Знаменитый {washbasin.IteractionToStringW_1()},");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tУмывальников начальник и мочалок Командир!");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tЕсли топну я ногою, позову моих солдат,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tВ эту комнату толпою умывальники влетят,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ залают, и завоют, и ногами застучат,");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\tИ тебе головомойку, {washbasin.IteractionToStringW_2()}, дадут —");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tПрямо в Мойку, прямо в Мойку");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tС головою окунут!");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.Write("\t\tContinue (enter/esc)");
            Action_with_text.Action();
            
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tОн ударил в медный таз");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\tИ вскричал: «{washbasin.IteractionToStringW_3()}!»");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ сейчас же щетки, щетки");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tЗатрещали, как трещотки,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ давай меня тереть, приговаривать:");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\t«Моем, моем трубочиста {brushes.IteractionToStringB_0()}!");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tБудет, будет трубочист Чист, чист, чист, чист!»");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tТут и мыло подскочило и вцепилось в волоса,");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\t{soap.InteractionWithText()}");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\t{soap.Answer_for_Boy()}");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tА от бешеной мочалки");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tЯ помчался, как от палки,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tА она за мной, за мной");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tПо Садовой, по Сенной.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tЯ к Таврическому саду,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tПерепрыгнул чрез ограду,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tА она за мною мчится");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ кусает, как волчица.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tВдруг навстречу мой хороший,");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.Write("\t\tContinue (enter/esc)");
            Action_with_text.Action();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tМой любимый Крокодил.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tОн с Тотошей и Кокошей");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tПо аллее проходил.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ мочалку, словно галку,");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\tСловно галку, {crocodyle.InteractionWithText()}.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tА потом как зарычит");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tНа меня, как ногами застучит");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\tНа меня: «Уходи - ка ты {crocodyle.ToStirngC_1()},");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tГоворит, да лицо своё умой,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tГоворит, растопчу и проглочу!»");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tГоворит.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tКак пустился я по улице бежать,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tПрибежал я к умывальнику опять.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tМылом, мылом");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tУмывался без конца, cмыл и ваксу и чернила");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tС неумытого лица.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ сейчас же брюки, брюки");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tТак и прыгнули мне в руки.");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tА за ними пирожок:");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\t«Ну-ка, съешь меня, {pie.ToStringP()}!»");
            Thread.Sleep(1500);
            Console.WriteLine($"\t\t{pie.Answer_for_Boy()}");
            Thread.Sleep(1500);
            Console.WriteLine();
            Console.Write("\t\tContinue (enter/esc)");
            Action_with_text.Action();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tА за ним и бутерброд:");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tПодбежал — и прямо в рот!");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tВот и книжка воротилась,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tВоротилася тетрадь, и грамматика пустилась");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tС арифметикой плясать.");
            Thread.Sleep(1500);

            Console.WriteLine($"\t\tТут Великий {washbasin.IteractionToStringW_1()}");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tЗнаменитый Мойдодыр,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tУмывальников Начальник и мочалок Командир,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tПодбежал ко мне, танцуя,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ, целуя, говорил:");
            Thread.Sleep(1500);
            Console.WriteLine("\t\t«Вот теперь тебя люблю я, вот теперь тебя хвалю я!");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tНаконец-то ты, грязнуля, Мойдодыру угодил!»");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tНадо, надо умываться по утрам и вечерам,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tА нечистым Трубочистам —");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tСтыд и срам!");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tДа здравствует мыло душистое, и полотенце пушистое,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ зубной порошок, и густой гребешок!");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tДавайте же мыться, плескаться,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tКупаться, нырять, кувыркаться в ушате, в корыте, в лохани,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tВ реке, в ручейке, в океане, —");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tИ в ванне, и в бане,");
            Thread.Sleep(1500);
            Console.WriteLine("\t\tВсегда и везде — Вечная слава .NET");
            Thread.Sleep(1500);



            /*
            
            
            
            
            Всегда и везде — Вечная слава воде!



                        */
        }
    }
}
