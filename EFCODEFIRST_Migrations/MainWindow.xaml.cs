using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EFCODEFIRST_Migrations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                using (Contexto db = new Contexto())
                {
                    db.Cliente.Add(new Cliente() { Nome = "Carlos dos Santos", Limite = 200 });
                    db.SaveChanges();
                    this.lblLog.Content = "Banco de dados e tabelas criado com sucesso.";
                }
            }
            catch (Exception ex)
            {
                this.lblLog.Content = "ERRO: " + ex.Message;
            }            
        }
    }
}
