namespace PolskiKraj.Models
{
    public class WordVerb
    {
        public string Root1 { get; set; }
        public string Root2 { get; set; }
        public string EndInfinitiv { get; set; }
        public string End1 { get; set; }
        public string End2 { get; set; }
        public string End3 { get; set; }
        public string End4 { get; set; }
        public string End5 { get; set; }
        public string End6 { get; set; }
        public string Letter1 { get; set; }
        public string Letter2 { get; set; }
        public string Description { get; set; }
        public WordVerb(int spr)
        {
            switch (spr)
            {
                case 1:
                    End1 = "ę";
                    End2 = "sz";
                    End3 = string.Empty;
                    End4 = "my";
                    End5 = "cie";
                    End6 = "ą";
                    break;
            }
            
        }


    }
}
