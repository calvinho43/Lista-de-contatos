using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lista_de_Contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ClassContato[] ListaDeContatos = new ClassContato[1];

        private void Escrever(ClassContato contato)
        {
            StreamWriter escrever = new StreamWriter("listaDeContatos.txt");

            escrever.WriteLine(ListaDeContatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < ListaDeContatos.Length; x++)
            {
                escrever.WriteLine(ListaDeContatos[x].Nome);
                escrever.WriteLine(ListaDeContatos[x].Sobrenome);
                escrever.WriteLine(ListaDeContatos[x].Telefone);
            }
            escrever.Close();
        }

        private void Ler()
        {
            StreamReader ler = new StreamReader("Contatos.txt");

            ListaDeContatos = new ClassContato[Convert.ToInt32(ler.ReadLine())];

            for (int x = 0; x < ListaDeContatos.Length; x++)
            {
                ListaDeContatos[x] = new ClassContato();
                ListaDeContatos[x].Nome = ler.ReadLine();
                ListaDeContatos[x].Sobrenome = ler.ReadLine();
                ListaDeContatos[x].Telefone = ler.ReadLine();
            }
            ler.Close();
        }

        private void Exibir()
        {
            listBoxContatos.Items.Clear();

            for(int x = 0; x < ListaDeContatos.Length; x++)
            {
                listBoxContatos.Items.Add(ListaDeContatos[x].ToString());
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            textBoxSobre.Text = string.Empty;
            textBoxTele.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ClassContato contato = new ClassContato();

            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobre.Text;
            contato.Telefone = textBoxTele.Text;

            listBoxContatos.Items.Add(contato.ToString());

            Escrever(contato);
            Ler();
            Exibir();
            LimparCampos();
        }

        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTele_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSobre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
