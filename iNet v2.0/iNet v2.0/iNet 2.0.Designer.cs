namespace iNet_v2._0
{
   partial class FormMain
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
         System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "AHHHHHH",
            "hmm"}, -1);
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabFicheiro = new System.Windows.Forms.TabPage();
         this.tabPlaylist = new System.Windows.Forms.TabPage();
         this.btnCriarPlaylist = new System.Windows.Forms.Button();
         this.tabMúsicas = new System.Windows.Forms.TabPage();
         this.tabFerramentas = new System.Windows.Forms.TabPage();
         this.lstPlaylists = new System.Windows.Forms.ListView();
         this.colNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colNMusicas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colDuração = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.lstMúsicas = new System.Windows.Forms.ListView();
         this.colNomeMusica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colNomeArtista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.tolNomePlaylist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.colDuraçãoMusica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.tabControl1.SuspendLayout();
         this.tabPlaylist.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabFicheiro);
         this.tabControl1.Controls.Add(this.tabPlaylist);
         this.tabControl1.Controls.Add(this.tabMúsicas);
         this.tabControl1.Controls.Add(this.tabFerramentas);
         this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
         this.tabControl1.HotTrack = true;
         this.tabControl1.Location = new System.Drawing.Point(12, 12);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(824, 296);
         this.tabControl1.TabIndex = 0;
         // 
         // tabFicheiro
         // 
         this.tabFicheiro.ImeMode = System.Windows.Forms.ImeMode.Off;
         this.tabFicheiro.Location = new System.Drawing.Point(4, 40);
         this.tabFicheiro.Name = "tabFicheiro";
         this.tabFicheiro.Padding = new System.Windows.Forms.Padding(3);
         this.tabFicheiro.Size = new System.Drawing.Size(816, 252);
         this.tabFicheiro.TabIndex = 0;
         this.tabFicheiro.Text = "Ficheiro";
         this.tabFicheiro.UseVisualStyleBackColor = true;
         // 
         // tabPlaylist
         // 
         this.tabPlaylist.Controls.Add(this.btnCriarPlaylist);
         this.tabPlaylist.Location = new System.Drawing.Point(4, 40);
         this.tabPlaylist.Name = "tabPlaylist";
         this.tabPlaylist.Padding = new System.Windows.Forms.Padding(3);
         this.tabPlaylist.Size = new System.Drawing.Size(816, 252);
         this.tabPlaylist.TabIndex = 1;
         this.tabPlaylist.Text = "Playlist";
         // 
         // btnCriarPlaylist
         // 
         this.btnCriarPlaylist.Location = new System.Drawing.Point(161, 46);
         this.btnCriarPlaylist.Name = "btnCriarPlaylist";
         this.btnCriarPlaylist.Size = new System.Drawing.Size(466, 53);
         this.btnCriarPlaylist.TabIndex = 0;
         this.btnCriarPlaylist.Text = "Criar Nova Playlist";
         this.btnCriarPlaylist.UseVisualStyleBackColor = true;
         this.btnCriarPlaylist.Click += new System.EventHandler(this.btnCriarPlaylist_Click);
         // 
         // tabMúsicas
         // 
         this.tabMúsicas.Location = new System.Drawing.Point(4, 40);
         this.tabMúsicas.Name = "tabMúsicas";
         this.tabMúsicas.Size = new System.Drawing.Size(816, 252);
         this.tabMúsicas.TabIndex = 2;
         this.tabMúsicas.Text = "Músicas";
         this.tabMúsicas.UseVisualStyleBackColor = true;
         // 
         // tabFerramentas
         // 
         this.tabFerramentas.Location = new System.Drawing.Point(4, 40);
         this.tabFerramentas.Name = "tabFerramentas";
         this.tabFerramentas.Size = new System.Drawing.Size(816, 252);
         this.tabFerramentas.TabIndex = 3;
         this.tabFerramentas.Text = "Ferramentas";
         this.tabFerramentas.UseVisualStyleBackColor = true;
         // 
         // lstPlaylists
         // 
         this.lstPlaylists.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNome,
            this.colNMusicas,
            this.colDuração});
         this.lstPlaylists.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
         this.lstPlaylists.Location = new System.Drawing.Point(16, 345);
         this.lstPlaylists.Name = "lstPlaylists";
         this.lstPlaylists.Size = new System.Drawing.Size(386, 289);
         this.lstPlaylists.TabIndex = 1;
         this.lstPlaylists.UseCompatibleStateImageBehavior = false;
         this.lstPlaylists.View = System.Windows.Forms.View.Details;
         this.lstPlaylists.SelectedIndexChanged += new System.EventHandler(this.lslPlaylists_SelectedIndexChanged);
         // 
         // colNome
         // 
         this.colNome.Text = "Nome";
         this.colNome.Width = 190;
         // 
         // colNMusicas
         // 
         this.colNMusicas.Text = "Nº De Músicas";
         this.colNMusicas.Width = 106;
         // 
         // colDuração
         // 
         this.colDuração.Text = "Duração";
         this.colDuração.Width = 85;
         // 
         // lstMúsicas
         // 
         this.lstMúsicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNomeMusica,
            this.colNomeArtista,
            this.tolNomePlaylist,
            this.colGenero,
            this.colDuraçãoMusica});
         this.lstMúsicas.Location = new System.Drawing.Point(408, 345);
         this.lstMúsicas.Name = "lstMúsicas";
         this.lstMúsicas.Size = new System.Drawing.Size(428, 289);
         this.lstMúsicas.TabIndex = 1;
         this.lstMúsicas.UseCompatibleStateImageBehavior = false;
         this.lstMúsicas.View = System.Windows.Forms.View.Details;
         // 
         // colNomeMusica
         // 
         this.colNomeMusica.Text = "Nome Da Musica";
         this.colNomeMusica.Width = 102;
         // 
         // colNomeArtista
         // 
         this.colNomeArtista.Text = "Artista";
         this.colNomeArtista.Width = 75;
         // 
         // tolNomePlaylist
         // 
         this.tolNomePlaylist.Text = "Nome Da Playlist";
         this.tolNomePlaylist.Width = 94;
         // 
         // colGenero
         // 
         this.colGenero.Text = "Gênero";
         this.colGenero.Width = 66;
         // 
         // colDuraçãoMusica
         // 
         this.colDuraçãoMusica.Text = "Duração";
         this.colDuraçãoMusica.Width = 54;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
         this.label1.Location = new System.Drawing.Point(143, 311);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(115, 31);
         this.label1.TabIndex = 2;
         this.label1.Text = "Playlists";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
         this.label2.Location = new System.Drawing.Point(575, 311);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(114, 31);
         this.label2.TabIndex = 2;
         this.label2.Text = "Músicas";
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(848, 646);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lstMúsicas);
         this.Controls.Add(this.lstPlaylists);
         this.Controls.Add(this.tabControl1);
         this.Name = "FormMain";
         this.Text = "iNet";
         this.tabControl1.ResumeLayout(false);
         this.tabPlaylist.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabFicheiro;
      private System.Windows.Forms.TabPage tabPlaylist;
      private System.Windows.Forms.TabPage tabMúsicas;
      private System.Windows.Forms.TabPage tabFerramentas;
      private System.Windows.Forms.Button btnCriarPlaylist;
      private System.Windows.Forms.ListView lstPlaylists;
      private System.Windows.Forms.ColumnHeader colNome;
      private System.Windows.Forms.ColumnHeader colNMusicas;
      private System.Windows.Forms.ColumnHeader colDuração;
      private System.Windows.Forms.ListView lstMúsicas;
      private System.Windows.Forms.ColumnHeader colNomeMusica;
      private System.Windows.Forms.ColumnHeader colNomeArtista;
      private System.Windows.Forms.ColumnHeader tolNomePlaylist;
      private System.Windows.Forms.ColumnHeader colGenero;
      private System.Windows.Forms.ColumnHeader colDuraçãoMusica;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
   }
}

