using CelilCavus.DependencyInjection.Dependency.Interface;

namespace CelilCavus.DependencyInjection
{
    //Bir ekleme veya çıkarma güncelleme gibi işlemleri araba veya motor classlarında değil onların bağlı olduğu ITasit interfaesinde yapıcam...

    public class Araba : ITasit
    {
        public void FrenYap()
        {
            System.Console.WriteLine("Araba Fren Yapıldı");
        }

        public void GazVer()
        {
            System.Console.WriteLine("Araba Gaz Verildi");
        }

        public void SagaGit()
        {
            System.Console.WriteLine("Araba Sağa Kırıldı");
        }

        public void SolaGit()
        {
            System.Console.WriteLine("Araba Sola Kırıldı");
        }
    }

    public class Motor : ITasit
    {

        public void FrenYap()
        {
            System.Console.WriteLine("Motor Fren Yapıldı");
        }

        public void GazVer()
        {
            System.Console.WriteLine("Motor Gaz Verildi");
        }

        public void SagaGit()
        {
            System.Console.WriteLine("Motor Sağa Kırıldı");
        }

        public void SolaGit()
        {
            System.Console.WriteLine("Motor Sola Kırıldı");
        }
    }

    public class Tasit
    {
        #region Counstructor injection
        // private readonly ITasit _tasit;

        // public Tasit(ITasit tasit)
        // {
        //     _tasit = tasit;
        // }
        #endregion
        
        #region Setter Injection
        public ITasit? _tasit { get; set; }
        #endregion
        public void TasitKullan()
        {
            _tasit!.GazVer();
        }
    }
}