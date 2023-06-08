namespace Hesap_Makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please write a first number.");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please write a second number.");

            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz(+,-,*,/)");
            char işlem = Convert.ToChar(Console.ReadLine());
            
            if (işlem=='*')
            {
                Console.WriteLine("Sonuç: " + num1 * num2);
            } else if(işlem=='/')
            {
                Console.WriteLine("Sonuç: " + num1 / num2);
            }else if (işlem == '+')
            {
                Console.WriteLine("Sonuç: " + Convert.ToInt16(num1 + num2));
            }else if (işlem == '-')
            {
                Console.WriteLine("Sonuç: "+ Convert.ToInt16(num1 - num2));
            }

            Console.ReadLine();

        }
        
    }
}