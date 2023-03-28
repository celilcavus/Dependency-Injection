using CelilCavus.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Counstructor injection
        //    Tasit tasit = new Tasit(new Araba());
        //    tasit.TasitKullan();
        //    Tasit tasit1 = new Tasit(new Motor());
        //    tasit1.TasitKullan();
        #endregion

        #region Setter injection
        Tasit tasit = new Tasit();
        tasit._tasit = new Araba();
        tasit.TasitKullan();
        Tasit tasit1 = new Tasit();
        tasit1._tasit = new Motor();
        tasit1.TasitKullan();
        #endregion
    }
}