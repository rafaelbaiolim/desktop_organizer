using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class desktop_org : Form
    {

        private DesktopManager dm;
        public desktop_org()
        {
            InitializeComponent();
            this.dm = new DesktopManager();
            this.initOnStartup();
                  
        }


        /*
         * Inicia a aplicação junto com o windows 
         */
        private void initOnStartup()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if(reg.GetValue("DesktopOrganizer") == null){
                reg.SetValue("DesktopOrganizer", Application.ExecutablePath.ToString());
            }
            else
            {
                string pathKey = (string)reg.GetValue("DesktopOrganizer");
                if (!pathKey.Equals(Application.ExecutablePath.ToString()))
                {
                    reg.SetValue("DesktopOrganizer", Application.ExecutablePath.ToString());
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            var itemsFiles = chk_lst_movedFiles.Items;
            var itemsFolders = chk_lst_movedFolders.Items;
            labelFolder.Text = " " + dm.DEFAULT_ORG_LOCATION ;
            bool hasFiles = false, hasFolders = false;
            foreach (string item in dm.filesMoved)
            {
                itemsFiles.Add(item, true);
                hasFiles = true;
            }

            chk_lst_movedFiles.SelectionMode = SelectionMode.None;

            foreach (string item in dm.foldersMoved)
            {
                itemsFolders.Add(item, true);
                hasFolders = true;
            }

            chk_lst_movedFolders.SelectionMode = SelectionMode.None;

            if (!hasFiles)
            {
                itemsFiles.Add("Nenhum arquivo foi movido.", false);
            }
            if (!hasFolders)
            {
                itemsFolders.Add("Nenhuma pasta foi movida.", false);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start(@dm.DEFAULT_ORG_LOCATION);
        }

 
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Pastas movidas para diretório são encontradas em \n'..\\directories\\folder\\ + data-hora(da criação)'.\n\n" +
                "Para alterar o caminho a ser salvo de um arquivo\n"+
                "renomei-o com o seguinte formato :\n\n" +
                "# - Identificador de arquivo especial\n\n" +
                " _ (underline) - Separador das novas pastas a serem criadas\n\n" +
                " exemplo #pasta1_pasta2_pasta3_NomeDoArquivo.ext"
                , "Ajuda",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

      
    }
}
