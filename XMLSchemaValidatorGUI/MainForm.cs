using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XMLValidator;

namespace XMLSchemaValidatorGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSelecionarXML_Click(object sender, EventArgs e)
        {
            if (openFileDialogXML.ShowDialog() == DialogResult.OK)
                textArquivoXML.Text = openFileDialogXML.FileName;
        }

        private void buttonAdicionarXSD_Click(object sender, EventArgs e)
        {
            if (openFileDialogXSD.ShowDialog() == DialogResult.OK)       
                textListaXSD.Lines = openFileDialogXSD.FileNames;
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (XMLValidator.XMLValidator.Validate(textArquivoXML.Text, textListaXSD.Lines))
                textResultado.Text = "Valid.";
            else
                textResultado.Text = XMLValidator.XMLValidator.GetError();
        }

    }
}
