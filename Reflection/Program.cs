using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem=new DortIslem(2,4);
            //dortIslem.Topla2();
            //dortIslem.Topla(1,2);

            var tip = typeof(DortIslem);



            //var dortIslem = Activator.CreateInstance(tip);// obje döndürür bidaha bak
            var instance = Activator.CreateInstance(tip, 6, 7);
            //instance.GetType().GetMethod("Topla2").Invoke(instance,null); //sadece method bilgisine ulaşıyor , neresi için çalışacak diyorsa ise instance için yazarız
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); //instance ile olan bağını kaybediyorsunuz
            Console.WriteLine(methodInfo.Invoke(instance, null));// hangi öreniğin topla 2sini çalıştırayım? instancenin

            var metodlar = tip.GetMethods();

            foreach (var info in metodlar) { 
                Console.WriteLine("Metod adı: {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters()) {
                    Console.WriteLine("Parametre: {0}", parameterInfo.Name);
                }
            }

        }
    }
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2) { 
            _sayi1 = sayi1; 
            _sayi2 = sayi2;
        }  

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }
}
