using AgendaWpf.contextos;
using AgendaWpf.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void salvar(Object sender, RoutedEventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nomeTbx.Text;
            pessoa.Telefone = telefoneTbx.Text;
            pessoa.Email = emailTbx.Text;

            using(var contexto = new PessoaContexto()){
                contexto.Pessoas.Add(pessoa);
                contexto.SaveChanges();
            }

            MessageBox.Show("Contato adicionado!");
        }

    
    }
}
