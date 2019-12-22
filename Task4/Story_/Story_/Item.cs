using System;
using System.Collections.Generic;
using Story_.Interface;
using Story_.DelegateAndEvent;


namespace Story
{
     
    public abstract class Interaction<T>
    {

        protected List<T> random_names = new List<T>();
        protected Dictionary<int, T> DictionList = new Dictionary<int, T>();

        protected static Random rnd = new Random();
        private  string str_;
        public string randn_0_W 
        {
            get { return str_; }
            set 
            {
                if (value == "гад")
                {
                    throw new IteractionException("Некоректное слово");
                }
                else 
                {
                    str_ = value;
                }
            }
        }
        public string randn_1_W { get; set; }
        public string randn_2_W { get; set; }
        public string randn_3_W { get; set; }
        public string randn_4_W { get; set; }
        public string randn_5_Br { get; set; }


        public virtual string InteractionWithText() 
        {
            return base.ToString();    
        }



    }
    public class IteractionException : ArgumentException
    {
        public IteractionException(string message) : base(message)
        {

        }
    }
    public class Items:Interaction<string> 
        {
            public Items()
            {
                random_names.Add("шикарный");
                random_names.Add("прекрасный");
                random_names.Add("богоподобный");
                random_names.Add("гад");
                random_names.Add("русского репа");
                random_names.Add("клипа Rammstein - Mann Gegen Mann");
                random_names.Add("Ламер");
                random_names.Add("Умывальник");
                random_names.Add("вероятно");
                random_names.Add("может быть");
                random_names.Add("точно");
                random_names.Add("Whats up cousin");
                random_names.Add("Yo Man");
                //brush
                random_names.Add("god damn, чисто, чисто");
                random_names.Add("Ой возможно мы уже ничем не поможем");
                //Soap
                random_names.Add("Не юлило, и не мылило,");
                random_names.Add("И юлило, и мылило,");

                //Boy
                random_names.Add("У мальчика вызвало возмущения почему его не мыли");
                random_names.Add("и кусало, как оса.");
                //Crocodyle
                random_names.Add("проглотил");
                random_names.Add("не проглотил");
                random_names.Add("в универ скоро сессия");
                random_names.Add("домой делай практички скоро сессия");
                //Pie
                random_names.Add("дружок-пирожок");
                random_names.Add("дружок");
                //boy
                random_names.Add("нет спасибо");

            //Add Data to Dictionary
                for (int i=0;i<=25;i++) 
                {
                    DictionList.Add(i,random_names[i]);
                }
                
            }

        }

    class Washbasin : Items, IiteractionWithWashbasin
    {
        
        
        public Washbasin():base()
        {
        
        }
        public override string ToString()
        {
            randn_0_W = DictionList[rnd.Next(0,3)];
            
            return randn_0_W;

        }
        

        public string IteractionToStringW_0()
        {
            randn_1_W = DictionList[rnd.Next(4,5)];
            return randn_1_W;
        }

         
        public string IteractionToStringW_1() 
        {
            randn_2_W = DictionList[rnd.Next(6,7)];
            return randn_2_W;
        }
        public string IteractionToStringW_2()
        {
            randn_3_W = DictionList[rnd.Next(8,10)];
            return randn_3_W;
        }
        public string IteractionToStringW_3()
        {
            randn_4_W = DictionList[rnd.Next(11,12)];
            return randn_4_W;
        }
    }
    class Brushes : Items,IiteractionWithBrushes
    {

        public Brushes() : base()
        {
        }
        

        public string IteractionToStringB_0()
        {
            randn_5_Br = DictionList[rnd.Next(13,14)];
            return randn_5_Br;
        }
    }

    class Soap : Items
    {
        private string randstr_s;
        public Soap() : base()
        { }
        public override string InteractionWithText()
        {
            randstr_s = DictionList[rnd.Next(15,16)];
            return randstr_s;
        }
        
        public string Answer_for_Boy()
        {
            string b_t;
            if (randstr_s == "Не юлило, и не мылило,")
            {
                b_t = random_names[17];
                return b_t;
            }
            else
            {
                b_t = random_names[18];
                return b_t;
            }
        }


    }
    class Crocodyle : Items
    {
        public Crocodyle() : base()
        { }
        
        public override string InteractionWithText()
        {
            string randstrC = DictionList[rnd.Next(19,20)];
            return randstrC;
        }
        public string ToStirngC_1()
        {
            string randstrC = DictionList[rnd.Next(21,22)];
            return randstrC;
        }
    }
    class Pie : Washbasin
    {
        private string randstr_p;
        public Pie() : base()
        { }
        public string ToStringP()
        {
            randstr_p = DictionList[rnd.Next(23,24)];

            return randstr_p;
        }
        public string Answer_for_Boy()
        {
            string b_t;
            if (randstr_p == "дружок - пирожок")
            {
                b_t = random_names[25];
                return b_t;
            }
            else
            {
                b_t = "Ok";
                return b_t;
            }
        }
    }


}
