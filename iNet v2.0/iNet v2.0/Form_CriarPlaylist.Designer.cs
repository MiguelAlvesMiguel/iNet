namespace iNet_v2._0
{
   partial class Form_CriarPlaylist
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
         this.components = new System.ComponentModel.Container();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtNomeNovaPlaylist = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.btnCriarPlaylist = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.FileDialog = new System.Windows.Forms.OpenFileDialog();
         this.lstNovaPlaylist = new System.Windows.Forms.ListView();
         this.colNomeMusica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colNomeArtista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colDuraçãoMusica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.chkCódigo = new System.Windows.Forms.CheckBox();
         this.txtCódigo = new System.Windows.Forms.TextBox();
         this.dtpDataCriação = new System.Windows.Forms.DateTimePicker();
         this.EP_Código = new System.Windows.Forms.ErrorProvider(this.components);
         this.chkDateTime = new System.Windows.Forms.CheckBox();
         ((System.ComponentModel.ISupportInitialize)(this.EP_Código)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31F);
         this.label1.Location = new System.Drawing.Point(134, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(257, 48);
         this.label1.TabIndex = 0;
         this.label1.Text = "Criar Playlist";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
         this.label2.Location = new System.Drawing.Point(6, 61);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(101, 36);
         this.label2.TabIndex = 0;
         this.label2.Text = "Nome:";
         // 
         // txtNomeNovaPlaylist
         // 
         this.txtNomeNovaPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
         this.txtNomeNovaPlaylist.Location = new System.Drawing.Point(113, 69);
         this.txtNomeNovaPlaylist.Name = "txtNomeNovaPlaylist";
         this.txtNomeNovaPlaylist.Size = new System.Drawing.Size(241, 27);
         this.txtNomeNovaPlaylist.TabIndex = 1;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
         this.label3.Location = new System.Drawing.Point(12, 187);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(133, 36);
         this.label3.TabIndex = 0;
         this.label3.Text = "Musicas:";
         // 
         // btnCriarPlaylist
         // 
         this.btnCriarPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
         this.btnCriarPlaylist.Location = new System.Drawing.Point(142, 483);
         this.btnCriarPlaylist.Name = "btnCriarPlaylist";
         this.btnCriarPlaylist.Size = new System.Drawing.Size(203, 32);
         this.btnCriarPlaylist.TabIndex = 3;
         this.btnCriarPlaylist.Text = "Criar Playlist";
         this.btnCriarPlaylist.UseVisualStyleBackColor = true;
         this.btnCriarPlaylist.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.button2.Location = new System.Drawing.Point(324, 192);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(162, 33);
         this.button2.TabIndex = 4;
         this.button2.Text = "Adicionar Músicas";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // FileDialog
         // 
         this.FileDialog.FileName = "openFileDialog1";
         this.FileDialog.Filter = "Musicas (*.mp3)| * .mp3";
         this.FileDialog.InitialDirectory = "Downloads";
         this.FileDialog.Multiselect = true;
         // 
         // lstNovaPlaylist
         // 
         this.lstNovaPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNomeMusica,
            this.colNomeArtista,
            this.colGenero,
            this.colDuraçãoMusica});
         this.lstNovaPlaylist.Location = new System.Drawing.Point(32, 231);
         this.lstNovaPlaylist.Name = "lstNovaPlaylist";
         this.lstNovaPlaylist.Size = new System.Drawing.Size(438, 246);
         this.lstNovaPlaylist.TabIndex = 5;
         this.lstNovaPlaylist.UseCompatibleStateImageBehavior = false;
         this.lstNovaPlaylist.View = System.Windows.Forms.View.Details;
         // 
         // colNomeMusica
         // 
         this.colNomeMusica.Text = "Nome Da Musica";
         this.colNomeMusica.Width = 127;
         // 
         // colNomeArtista
         // 
         this.colNomeArtista.Text = "Artista";
         this.colNomeArtista.Width = 105;
         // 
         // colGenero
         // 
         this.colGenero.Text = "Gênero";
         this.colGenero.Width = 109;
         // 
         // colDuraçãoMusica
         // 
         this.colDuraçãoMusica.Text = "Duração";
         this.colDuraçãoMusica.Width = 93;
         // 
         // chkCódigo
         // 
         this.chkCódigo.AutoSize = true;
         this.chkCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
         this.chkCódigo.Location = new System.Drawing.Point(18, 106);
         this.chkCódigo.Name = "chkCódigo";
         this.chkCódigo.Size = new System.Drawing.Size(161, 26);
         this.chkCódigo.TabIndex = 6;
         this.chkCódigo.Text = "Escolher Código";
         this.chkCódigo.UseVisualStyleBackColor = true;
         this.chkCódigo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
         // 
         // txtCódigo
         // 
         this.txtCódigo.Enabled = false;
         this.txtCódigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.txtCódigo.Location = new System.Drawing.Point(185, 105);
         this.txtCódigo.Name = "txtCódigo";
         this.txtCódigo.Size = new System.Drawing.Size(169, 26);
         this.txtCódigo.TabIndex = 8;
         this.txtCódigo.Text = "Automático.";
         this.txtCódigo.TextChanged += new System.EventHandler(this.txtCódigo_TextChanged);
         // 
         // dtpDataCriação
         // 
         this.dtpDataCriação.Enabled = false;
         this.dtpDataCriação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.dtpDataCriação.Location = new System.Drawing.Point(206, 146);
         this.dtpDataCriação.Name = "dtpDataCriação";
         this.dtpDataCriação.Size = new System.Drawing.Size(301, 26);
         this.dtpDataCriação.TabIndex = 9;
         this.dtpDataCriação.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
         // 
         // EP_Código
         // 
         this.EP_Código.ContainerControl = this;
         // 
         // chkDateTime
         // 
         this.chkDateTime.AutoSize = true;
         this.chkDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
         this.chkDateTime.Location = new System.Drawing.Point(18, 146);
         this.chkDateTime.Name = "chkDateTime";
         this.chkDateTime.Size = new System.Drawing.Size(189, 26);
         this.chkDateTime.TabIndex = 10;
         this.chkDateTime.Text = "Mudar Data Criação";
         this.chkDateTime.UseVisualStyleBackColor = true;
         this.chkDateTime.CheckedChanged += new System.EventHandler(this.chkDateTime_CheckedChanged);
         // 
         // Form_CriarPlaylist
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(519, 527);
         this.Controls.Add(this.chkDateTime);
         this.Controls.Add(this.dtpDataCriação);
         this.Controls.Add(this.txtCódigo);
         this.Controls.Add(this.chkCódigo);
         this.Controls.Add(this.lstNovaPlaylist);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.btnCriarPlaylist);
         this.Controls.Add(this.txtNomeNovaPlaylist);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form_CriarPlaylist";
         this.Text = "Form_CriarPlaylist";
         this.TopMost = true;
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_CriarPlaylist_FormClosed);
         this.Load += new System.EventHandler(this.Form_CriarPlaylist_Load);
         ((System.ComponentModel.ISupportInitialize)(this.EP_Código)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtNomeNovaPlaylist;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnCriarPlaylist;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.OpenFileDialog FileDialog;
      private System.Windows.Forms.ListView lstNovaPlaylist;
      private System.Windows.Forms.ColumnHeader colNomeMusica;
      private System.Windows.Forms.ColumnHeader colNomeArtista;
      private System.Windows.Forms.ColumnHeader colGenero;
      private System.Windows.Forms.ColumnHeader colDuraçãoMusica;
      private System.Windows.Forms.CheckBox chkCódigo;
      private System.Windows.Forms.TextBox txtCódigo;
      private System.Windows.Forms.DateTimePicker dtpDataCriação;
      private System.Windows.Forms.ErrorProvider EP_Código;
      private System.Windows.Forms.CheckBox chkDateTime;
   }
}