using Singleton_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        // Constructor private olarak tanımlanır, böylece dışarıdan erişim engellenir.
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                // Birden fazla thread'in bu bloğa girmesini engellemek için lock kullanılır.
                lock (padlock)
                {
                    // Eğer henüz bir örnek oluşturulmamışsa, yeni bir örnek oluşturulur.
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton sınıfından bir işlem gerçekleştirildi.");
        }
    }
}
