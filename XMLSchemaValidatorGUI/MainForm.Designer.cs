namespace XMLSchemaValidatorGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textArquivoXML = new System.Windows.Forms.TextBox();
            this.textListaXSD = new System.Windows.Forms.TextBox();
            this.buttonSelecionarXML = new System.Windows.Forms.Button();
            this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogXSD = new System.Windows.Forms.OpenFileDialog();
            this.buttonAdicionarXSD = new System.Windows.Forms.Button();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textArquivoXML
            // 
            this.textArquivoXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textArquivoXML.Location = new System.Drawing.Point(15, 35);
            this.textArquivoXML.Name = "textArquivoXML";
            this.textArquivoXML.Size = new System.Drawing.Size(591, 20);
            this.textArquivoXML.TabIndex = 0;
            // 
            // textListaXSD
            // 
            this.textListaXSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textListaXSD.Location = new System.Drawing.Point(12, 90);
            this.textListaXSD.Multiline = true;
            this.textListaXSD.Name = "textListaXSD";
            this.textListaXSD.Size = new System.Drawing.Size(709, 113);
            this.textListaXSD.TabIndex = 3;
            // 
            // buttonSelecionarXML
            // 
            this.buttonSelecionarXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionarXML.Location = new System.Drawing.Point(612, 33);
            this.buttonSelecionarXML.Name = "buttonSelecionarXML";
            this.buttonSelecionarXML.Size = new System.Drawing.Size(109, 23);
            this.buttonSelecionarXML.TabIndex = 4;
            this.buttonSelecionarXML.Text = "Selecionar XML...";
            this.buttonSelecionarXML.UseVisualStyleBackColor = true;
            this.buttonSelecionarXML.Click += new System.EventHandler(this.buttonSelecionarXML_Click);
            // 
            // openFileDialogXML
            // 
            this.openFileDialogXML.Filter = "Arquivos XML|*.xml";
            // 
            // openFileDialogXSD
            // 
            this.openFileDialogXSD.Filter = "Arquivos XSD|*.xsd";
            this.openFileDialogXSD.Multiselect = true;
            // 
            // buttonAdicionarXSD
            // 
            this.buttonAdicionarXSD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdicionarXSD.Location = new System.Drawing.Point(15, 61);
            this.buttonAdicionarXSD.Name = "buttonAdicionarXSD";
            this.buttonAdicionarXSD.Size = new System.Drawing.Size(706, 23);
            this.buttonAdicionarXSD.TabIndex = 5;
            this.buttonAdicionarXSD.Text = "Adicionar XSD...";
            this.buttonAdicionarXSD.UseVisualStyleBackColor = true;
            this.buttonAdicionarXSD.Click += new System.EventHandler(this.buttonAdicionarXSD_Click);
            // 
            // textResultado
            // 
            this.textResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResultado.Location = new System.Drawing.Point(12, 238);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(709, 177);
            this.textResultado.TabIndex = 6;
            // 
            // buttonValidar
            // 
            this.buttonValidar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonValidar.Location = new System.Drawing.Point(15, 209);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(706, 23);
            this.buttonValidar.TabIndex = 7;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 427);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.buttonAdicionarXSD);
            this.Controls.Add(this.buttonSelecionarXML);
            this.Controls.Add(this.textListaXSD);
            this.Controls.Add(this.textArquivoXML);
            this.Name = "MainForm";
            this.Text = "XML Schema Validator Tabajara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textArquivoXML;
        private System.Windows.Forms.TextBox textListaXSD;
        private System.Windows.Forms.Button buttonSelecionarXML;
        private System.Windows.Forms.OpenFileDialog openFileDialogXML;
        private System.Windows.Forms.OpenFileDialog openFileDialogXSD;
        private System.Windows.Forms.Button buttonAdicionarXSD;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button buttonValidar;
    }
}

