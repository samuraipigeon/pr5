using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disciplines
{
    internal class Program
    {
        public static string GetDescriptionFromEnum(Enum value)
        {
            DescriptionAttribute attribute = value.GetType()
            .GetField(value.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false)
            .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? value.ToString() : attribute.Description;
        }
        [Flags]
        public enum items
        {
           [Description("Основи програмування "+"\nВикладач: Палагута П.О"+"\nОбов'язкова професійна дисципліна")] Основи_програмування = 1,
            [Description("Вища математика"+"\nВикладач: Ковальчук Т.В."+"\nОбов'язкова професійна дисціпліна")]Вища_математика,
            [Description("Операційні системи" + "\nВикладач:Харченко О.А" + "\nОбов'язкова професійна дисціпліна")]Операційні_системи,
            [Description("Правознавство"+"\nВикладач: Бондаренко Н.О"+"\nЗагальноосвітня дисціпліна")]Правознавство,
           [Description("Філософія"+"\nВикладач: Кизименко І.О"+"\nЗагальноосвітня дисципліна")] Філософія,
            [Description("Фізичне виховання.Легка атлетика"+ "\nВикладач:Приходько В.М"+"\nЗагадьноосвітня дисципліна")]Фізичне_виховання,
            [Description("Основи кібербезпеки"+"\nВикладач: Сашньова М.В"+"\nДисципліна за вибором")]Основи_кібербезпеки,
            [Description("Електронний документообіг"+"\nВикладач: Рассамакін В.Я"+"\nДисципліна за вибором")]Електронний_документообіг,
            [Description("Людино-машинна взаємодія" + "\nВикладач:Жирова Т.О" + "\nДисципліна за вибором")]Людино_машинна_взаємодія
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Обов'язкові дисципліни:" + " \n1.Основи програмування" + " \n2.Вища математика" + " \n3.Операційні системи");
            Console.WriteLine("\nЗагальноосвітні дисципліни:"+"\n4.Правознавство"+"\n5.Філософія"+"\n6.Фізичне виховання");
            Console.WriteLine("\nВибіркові дисципліни:"+"\n7.Основи Кібербезпеки"+"\n8.Електронний документообіг"+"\n9.Людино-машинна взаємодія");
            Console.WriteLine("Введіть номер дисципліни, яку б хотіли вивчати:");
            string num =  Console.ReadLine();
            items disc = (items)Enum.Parse(typeof(items),num); 
           Console.Write(GetDescriptionFromEnum(disc));
            
            Console.ReadLine();
        }

    }
}
