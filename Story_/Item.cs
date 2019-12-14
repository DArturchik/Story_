using System;
using System.Collections;
using System.Collections.Generic;


namespace Story
{
     
    abstract class Interaction
    {
        protected List<string> random_names = new List<string>();
        protected Random rnd = new Random();
        private  string str_;
        public string randn_0_W 
        {
            get { return str_; }
            set 
            {
                if (value == "гад")
                {
                    throw new IteractionException("Некорректное слово");
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
    class IteractionException : ArgumentException
    {
        public IteractionException(string message) : base(message)
        {

        }
    }
    class Items:Interaction 
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
            }

        }

    class Washbasin : Items
    {

        public Washbasin():base()
        {
        
        }
        public override string ToString()
        {
            List<string> to_string = new List<string>();
            to_string.Add(random_names[0]);
            to_string.Add(random_names[1]);
            to_string.Add(random_names[2]);
            to_string.Add(random_names[3]);
            randn_0_W = random_names[rnd.Next(0, to_string.Count)];
            return randn_0_W;
        }
        public string ToString_1()
        {

            List<string> to_string_1 = new List<string>();
            to_string_1.Add(random_names[4]);
            to_string_1.Add(random_names[5]);
            randn_1_W = to_string_1[rnd.Next(0, to_string_1.Count)];
            return randn_1_W;
        }
        public string ToString_2()
        {
            List<string> to_string_2 = new List<string>();
            to_string_2.Add(random_names[6]);
            to_string_2.Add(random_names[7]);
            randn_2_W = to_string_2[rnd.Next(0, to_string_2.Count)];
            return randn_2_W;
        }
        public string ToString3()
        {
            List<string> tostring3 = new List<string>();
            tostring3.Add(random_names[8]);
            tostring3.Add(random_names[9]);
            tostring3.Add(random_names[10]);
            randn_3_W = tostring3[rnd.Next(0, tostring3.Count)];
            return randn_3_W;
        }
        public string ToString4()
        {
            List<string> tostring4 = new List<string>();
            tostring4.Add(random_names[11]);
            tostring4.Add(random_names[12]);
            randn_4_W = tostring4[rnd.Next(0, tostring4.Count)];
            return randn_4_W;
        }


    }
    class Brushes : Items
    {

        public Brushes() : base()
        {
        }
        public override string InteractionWithText()
        {
            List<string> tostringBrsh = new List<string>();
            tostringBrsh.Add(random_names[13]);
            tostringBrsh.Add(random_names[14]);
            randn_5_Br = tostringBrsh[rnd.Next(0, tostringBrsh.Count)];
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
            List<string> tostringS = new List<string>();
            tostringS.Add(random_names[15]);
            tostringS.Add(random_names[16]);
            randstr_s = tostringS[rnd.Next(0, tostringS.Count)];
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
            List<string> tostringC = new List<string>();
            tostringC.Add(random_names[19]);
            tostringC.Add(random_names[20]);
            string randstrC = tostringC[rnd.Next(0, tostringC.Count)];

            return randstrC;
        }
        public string ToStirngC_1()
        {
            List<string> tostringC = new List<string>();
            tostringC.Add(random_names[21]);
            tostringC.Add(random_names[22]);
            string randstrC = tostringC[rnd.Next(0, tostringC.Count)];

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
            List<string> tostringP_0 = new List<string>();
            tostringP_0.Add(random_names[23]);
            tostringP_0.Add(random_names[24]);
            randstr_p = tostringP_0[rnd.Next(0, tostringP_0.Count)];
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
