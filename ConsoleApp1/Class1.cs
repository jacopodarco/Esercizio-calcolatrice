namespace MyNameSpace
{
    class Class1
    {

        public int Op { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }
        public float DivN1 { get; set; }
        public float DivN2 { get; set; }

        public Class1(int n1, int n2)
        {
            this.N1 = n1;
            this.N2 = n2;
            this.DivN1 = n1;
            this.DivN2 = n2;
        }

        /*
        public Class1(float n1, float n2)
        {
            

        }*/


        //FUNZIONI CALCOLATRICE 
        public static int Sum(int a, int b)
        {

            int c = a + b;
            return c;
        }

        public static int Diff(int a, int b)
        {
            int c = a - b;
            return c;
        }


        public static int Prod(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public static float Div(float a, float b)
        {
            float c = a / b;
            return c;
        }
    }
}