namespace Lista_Objetos_17_12.Classes
{
    public class Product
    {
        public int Code {get;set;}

        public string Name {get;set;}

        public float Price {get;set;}


        public Product() {

        }

        public Product(int code, string name, float price) {

                this.Code = code;
                this.Name = name;
                this.Price = price;

        }


    }
}