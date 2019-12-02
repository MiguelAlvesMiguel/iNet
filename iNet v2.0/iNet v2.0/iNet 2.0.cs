using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iNet_v2._0
{
   public partial class FormMain : Form
   {
      public ListView listView;

      public FormMain()
      {
         listView = lstPlaylists;
         InitializeComponent();
      }
 

      private void btnCriarPlaylist_Click(object sender, EventArgs e)
      {

         (new Form_CriarPlaylist() ).ShowDialog();

      }

      private void lslPlaylists_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
   }
}
