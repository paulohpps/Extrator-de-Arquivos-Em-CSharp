using SevenZipExtractor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii;
using Ookii.Dialogs.Wpf;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string localArquivo;
        string diretorio;
        string titulo;
        private void SelecionarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Arquivos Compactados(*.zip;*.rar;*.iso)|*.ZIP;*.RAR;*.ISO|All files (*.*)|*.*";
            dlg.ShowDialog();
            
            var arquivo = dlg.FileName;
            titulo = dlg.Title;
            localArquivo = arquivo.ToString();
            arquivoText.Text = localArquivo;
        }

        private void ExtraiBt_Click(object sender, EventArgs e)
        {
            ExtraiBt.Enabled = false;
            SelecinarDestino.Enabled = false;
            SelecionarArquivo.Enabled = false;
            using (ArchiveFile archiveFile = new ArchiveFile(localArquivo))
            {
                archiveFile.Extract(diretorio);
               
            }
            ExtraiBt.Enabled = true;
            SelecinarDestino.Enabled = true;
            SelecionarArquivo.Enabled = true;
        }

        private void SelecinarDestino_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog dlg = new VistaFolderBrowserDialog();
            dlg.ShowDialog();
            var localSalvar = dlg.SelectedPath;
            diretorio = localSalvar.ToString();
            diretorioText.Text = diretorio;
        }
    }
}
