using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BindableTextBlockSample
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();

            // Create the ViewModel to which
            // the main window binds.
            var viewModel = new PersonViewModel();

            // Allow all controls in the window to
            // bind to the ViewModel by setting the
            // DataContext, which propagates down
            // the element tree.
            window.DataContext = viewModel;

            window.Show();
        }
    }
}
