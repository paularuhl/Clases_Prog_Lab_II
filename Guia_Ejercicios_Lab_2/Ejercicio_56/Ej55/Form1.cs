using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej55
{
    public partial class Ej56 : Form
    {
        public string lastFileOpened;

        public Ej56()
        {
            InitializeComponent();
            this.lastFileOpened = string.Empty;
        }



        private void guardarArchivoMenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.lastFileOpened))
            {
                this.guardarComoArchivoMenu_Click(sender, e);
            }
            else
            {
                this.Escribir(this.lastFileOpened);
            }
        }

        private void guardarComoArchivoMenu_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.InitialDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\";
                saveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    path = saveFile.FileName;
                    this.Escribir(path);
                }
            }
        }

        private void abrirArchivoMenu_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\";
                openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                StreamReader reader = null;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (reader = new StreamReader(lastFileOpened))
                        {
                            lastFileOpened = openFile.FileName;
                            this.editorTxt.Text = reader.ReadToEnd();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cortaste toda la looz");
                    } 
                    finally
                    {
                        if (!(reader is null))
                        {

                        }
                    }
                }
            }
        }

        private void editorTxt_TextChanged(object sender, EventArgs e)
        {
            this.caracteresStatus.Text = $"{this.editorTxt.Text.Length} caracteres";
        }


        private void Escribir(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(this.editorTxt.Text);
            }
        }
    }
}
