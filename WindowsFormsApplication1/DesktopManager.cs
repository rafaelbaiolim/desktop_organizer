using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class DesktopManager
    {
        private string PATH_DESKTOP;
        public string DEFAULT_ORG_LOCATION;
        private string DEFAULT_FOLDERS_LOCATION;
        private string PROGRAM_FOLDER = "\\directories\\";
        public const char tagID = '#';
        public const char tagSctructure = '_';
        public const string foldersLocation = "folders";
        public List<string> filesMoved = new List<string>();
        public List<string> foldersMoved = new List<string>();
        public DirectoryInfo desktopInfo { get; }
        public DesktopManager()
        {
            PATH_DESKTOP = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DEFAULT_ORG_LOCATION = PATH_DESKTOP + PROGRAM_FOLDER;
            DEFAULT_FOLDERS_LOCATION = PATH_DESKTOP + PROGRAM_FOLDER + foldersLocation;
            this.genFolder(DEFAULT_ORG_LOCATION);
            this.desktopInfo = new DirectoryInfo(PATH_DESKTOP);
            this.getAllItens();
        }

        /*
         * Processa todos os arquivos do Desktop
        */
        protected void getAllItens()
        {
            string currentDateTime = DateTime.Now.ToString("yyyy_MM_dd_HH-mm-ss"); ;
            
            //Separa os diretórios
            foreach (string dirPath in Directory.GetDirectories(PATH_DESKTOP))
            {
                string[] treePath = dirPath.Split('\\');
                string folderName = "\\" + treePath[treePath.Length - 1];
                string folderNameToComp = folderName + "\\";
                if (folderNameToComp.Equals(PROGRAM_FOLDER))
                {
                    continue;
                }
                try
                {
                    Directory.CreateDirectory(DEFAULT_FOLDERS_LOCATION + "\\" + currentDateTime);
                    Directory.Move(dirPath, DEFAULT_FOLDERS_LOCATION + "\\" + currentDateTime + "\\" + folderNameToComp);
                    this.foldersMoved.Add(folderName);
                }catch(Exception ex)
                {
                    Debug.Write(ex.Message);
                }
            }
            

            //Separa os arquivos
            foreach (var file in this.desktopInfo.GetFiles("*.*"))
            {
                string newFileLocation = DEFAULT_ORG_LOCATION +
                    file.Extension.Substring(1, file.Extension.Length - 1) + "\\";
                this.genFolder(newFileLocation);
                if (file.Name[0] == tagID)
                {
                    this.organizeByTag(file,newFileLocation);
                }else
                {
                    this.organizeByExtension(file,newFileLocation);
                }
                
            }
            
        }

        /*
         * Cria a pasta se não existir
        */
        private void genFolder(string fullPath)
        {
            try
            {
                Directory.CreateDirectory(fullPath);
            }
            catch (Exception ex)
            {
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        /*
         * Processa os arquivos que serão movidos, 
         * se já existir,
         * um novo nome é atribuido
        */
        private void processFileMove(FileInfo file, string location, string fileTagName = "")
        {
            int count = 1;
            string newFileFullPath = "";
            newFileFullPath = location + file.Name;

            if (fileTagName != String.Empty)
            {
                newFileFullPath = location + fileTagName;
            }
            while (File.Exists(newFileFullPath))
            {
                string tempFileName = "";
                if (fileTagName != String.Empty)
                {
                    tempFileName = string.Format("{0}({1})", fileTagName, count++);
                }else { 
                    tempFileName = string.Format("{0}({1})", file.Name, count++);
                }
                tempFileName = tempFileName.Replace((string)file.Extension, "");
                newFileFullPath = location + Path.Combine(tempFileName + file.Extension);
            }
            try
            {
                Directory.Move(file.FullName, newFileFullPath);
                string[] treePath = newFileFullPath.Split('\\');
                string fileName = "\\" + treePath[treePath.Length - 1];
                this.filesMoved.Add(fileName);
            }catch(Exception err)
            {
                Debug.Write("Error" + err.Message);
            }

        }

        /*
        * Utiliza a extensão do arquivo para separar
        */
        private void organizeByExtension(FileInfo file, string location)
        {
            processFileMove(file, location);
        }

        /*
        * Utiliza o tagID para identificar 
        * nova estrutura para mover o arquivo
        */
        private void organizeByTag(FileInfo file, string location)
        { 
            string structureFilename = file.Name.Substring(1, file.Name.Length - 1);
            string[] treeNameFile = structureFilename.Split(tagSctructure);
            string newFolerStc = "";
            if ((treeNameFile.Length - 1) >= 1) {
                for (int i = 0; i < (treeNameFile.Length - 1) ; i++){
                    if(i > 0)
                    {
                        newFolerStc += "\\";
                    }
                    newFolerStc += treeNameFile[i];
                }
                newFolerStc += "\\";
            }
            
            if(newFolerStc == String.Empty)
            {
                return;
            }
            string newFullPath = DEFAULT_ORG_LOCATION + newFolerStc;
            this.genFolder(newFullPath);

            processFileMove(file, newFullPath, treeNameFile[treeNameFile.Length - 1]);
        }
        
    }
}
