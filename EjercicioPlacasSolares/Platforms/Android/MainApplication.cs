using Android.App;
using Android.Runtime;
using EjercicioPlacasSolares.Views;

namespace EjercicioPlacasSolares
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}