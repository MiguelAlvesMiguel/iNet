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
using TagLib;


namespace iNet_v2._0
{
   public partial class Form_CriarPlaylist : Form
   {
      //Para aceder ao controlo das playlists
      ListView lstPlaylistsCopia =Application.OpenForms["FormMain"].Controls["lstPlaylists"] as ListView;

      public Form_CriarPlaylist()
      {
         InitializeComponent();
      }
      //Métodos
      public bool SearchPlaylistByCod(int cod)
      {   
         //Procurar o item com o cod parametro
         foreach (ListViewItem item in lstPlaylistsCopia.Items)      
            if (Convert.ToInt32(item.Tag) == cod)
               return true;
         
         return false;
      }
      public int ReturnValidCod()
      {
         int cod;
         Random random = new Random();
         //Gerar um numero random 
         cod = random.Next();

         for (int idx = 0; idx < lstNovaPlaylist.Items.Count; idx++)
         {
            if (Convert.ToInt32(lstNovaPlaylist.Items[idx].Tag) == cod)
            {
               cod = random.Next();
               idx = -1;      //Para voltar a comparar com todas as playlists
            }
         }
         return cod;    
      }
      //
      private void Form_CriarPlaylist_FormClosed(object sender, FormClosedEventArgs e)
      {
         
      }

      private void listView1_SelectedIndexChanged(object sender, EventArgs e)
      {

      }

      private void button2_Click(object sender, EventArgs e)
      {
         if (FileDialog.ShowDialog() == DialogResult.OK)
            foreach (string path in FileDialog.FileNames) //File name é o caminho completo
            {
               //using(FileStream fs = new FileStream(path, FileMode.Open,FileAccess.ReadWrite))
               //{
               //   Musica musica = new Musica(

               //}
                        
                  ListViewItem lvi = new ListViewItem();
                  Musica musica = new Musica();

                  lvi.Tag = ReturnValidCod();

                  TagLib.File musicInfo = TagLib.File.Create(path); //Apanhar o ficheiro
                  //Validar os campos 
                  if(musicInfo.Tag.Title == null || musicInfo.Tag.FirstComposer == null)
                  {
                  DialogResult resultado=  MessageBox.Show("A metadata não está toda preenchida! Inserir na mesma?", "Inserir na mesma?", MessageBoxButtons.YesNo);

                  if(resultado == DialogResult.No)       
                     continue;                                
                   }

                  //Guardar o nome da música
                  lvi.Text = (musica.Título = musicInfo.Tag.Title);

                  //Guardar o artista
                  ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
                  lvsi.Text = (musica.Artista = musicInfo.Tag.FirstComposer);
                  lvi.SubItems.Add(lvsi);

                  //Guardar o Genero
                  lvsi = new ListViewItem.ListViewSubItem();

                  Enum_Gen enumerator;
                  bool Found = Enum.TryParse<Enum_Gen>(musicInfo.Tag.FirstGenre, out enumerator);

                  if (Found == true)
                     lvsi.Text = (musica.Genero = enumerator).ToString();
                  else
                     lvsi.Text = (musica.Genero = (Enum_Gen)0).ToString();

                  lvi.SubItems.Add(lvsi);

                  //Guardar a duração
                  lvsi = new ListViewItem.ListViewSubItem();

                  string duraçãoMins = musicInfo.Properties.Duration.ToString().Substring(4, 4) + " m";

                  lvsi.Text = (musica.Duração = duraçãoMins);
                  lvi.SubItems.Add(lvsi);

                  //Adicionar o item á listview

                  lstNovaPlaylist.Items.Add(lvi);
               
               //catch (Exception ex)
               //{
               //   MessageBox.Show("Ficheiro Não Completamente preenchido!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);

               //}
      }
               }

      private void checkBox1_CheckedChanged(object sender, EventArgs e)
      {
         if (chkCódigo.Checked == true)
         {
            txtCódigo.Enabled = true;
            txtCódigo.Text = "";
         }
         else
         {
            txtCódigo.Text = "Automático.";
            txtCódigo.Enabled = false;            
         }
      }

      private void txtCódigo_TextChanged(object sender, EventArgs e)
      {
         
      }

      private void Form_CriarPlaylist_Load(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
         int cod;
        
         if (DateTime.Compare(dtpDataCriação.Value, DateTime.Now) > 0) // >0 significa que o primeiro acontece DEPOIS do segundo
         {
            MessageBox.Show("A data de criação não pode ser no futuro!", "ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return;
         }
         if (txtCódigo.Enabled == true)
            cod = Convert.ToInt32(txtCódigo.Text);
         else        
            cod = ReturnValidCod();

         if ( SearchPlaylistByCod(cod) == true)
            { // Se for encontrado
            MessageBox.Show("Já existe uma playlist com esse Código!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtCódigo.Focus();
            return;
            }
         else
         { // Se não for encontrado
            ColeçãoDeMusicas musicas = new ColeçãoDeMusicas(lstNovaPlaylist.Items.Count);
            
            //Criar a coleção de músicas
            for(int idx=0;idx<lstNovaPlaylist.Items.Count;idx++)
            {
               
               musicas[idx].Título = lstNovaPlaylist.Items[idx].SubItems[0].ToString();
               musicas[idx].Artista = lstNovaPlaylist.Items[idx].SubItems[1].ToString();

               Enum_Gen enumerator; //Porque o que está na lstView é só texto
               Enum.TryParse<Enum_Gen>(lstNovaPlaylist.Items[idx].SubItems[2].Text, out enumerator);

               musicas[idx].Genero = enumerator ;
               musicas[idx].Duração = lstNovaPlaylist.Items[idx].SubItems[3].ToString();
            }
            //Criar o objeto da playlist
            Playlist playlist = new Playlist(cod, txtNomeNovaPlaylist.Text, dtpDataCriação.Value, musicas);

            lstPlaylistsCopia.Clear();
         }
      }

      private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
      {
         
      }

      private void chkDateTime_CheckedChanged(object sender, EventArgs e)
      {
         if (chkCódigo.Checked == true)         
            txtCódigo.Enabled = true;       
         else   
            txtCódigo.Enabled = false;   
      }
   }
}
