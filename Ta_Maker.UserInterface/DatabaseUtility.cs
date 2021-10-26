using MaterialSkin.Controls;
using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TaMaker.DataClassLibrary;

namespace Ta_Maker
{
    public partial class DatabaseUtility : MaterialForm
    {
        private static readonly string ConnString = ConfigurationManager.ConnectionStrings["SQLiteConnectionString"].ConnectionString;

        public DatabaseUtility()
        {
            InitializeComponent();
            MaterialDesign.Materialize(this);
        }

        private void DatabaseUtility_Load(object sender, EventArgs e)
        {
            CardBackup.BackColor = System.Drawing.Color.Blue;
        }

        private void BtnCreateDb_Click(object sender, EventArgs e)
        {
            CreateDb dbCreation = new CreateDb();

            dbCreation.CreateDatabase();
            LblMsg.Text = "";
            LblMsg.Text = "Database Creation Succuss";
        }

        private void BtnTestConn_Click(object sender, EventArgs e)
        {
            DbConnection.OpenConnection();
            LblMsg.Text = "";
            LblMsg.Text = "Database Testing : Result-OK";

            DbConnection.CloseConnection();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            var now = DateTime.UtcNow;
            var Destination = "";
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Destination = fbd.SelectedPath;
                }
            }


            var backupDirectory = Path.Combine(Destination);
            if (!Directory.Exists(backupDirectory))
                Directory.CreateDirectory(backupDirectory);

            var backupFile = now.ToString("yyyy-MM-dd_hh-mm-ss") + "TaDb.sqlite";

            backupFile = Path.Combine(backupDirectory, backupFile);

            string backupConnectionString = "data source=" + backupFile;
            using (var backupConnection = new SQLiteConnection(backupConnectionString))

            using (var sourceConnection = new SQLiteConnection(ConnString))
            {
                backupConnection.Open();
                sourceConnection.Open();
                LblMsg.Text = "";
                LblMsg.Text = "Backuping your Data";
                sourceConnection.BackupDatabase(backupConnection, "main", "main", -1, null, 0);
                LblMsg.Text = "";
                LblMsg.Text = "Backup Succuss";
            }
            //DeleteOldBackups
            var files = Directory.EnumerateFiles(backupDirectory).OrderBy(File.GetCreationTimeUtc).ToList();
            foreach (var file in files.Take(Math.Max(files.Count - 3, 0)))
            {
                File.Delete(file);
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            var bkfile = "";
            using (var openFileDialog = new OpenFileDialog())
            {
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    bkfile = openFileDialog.FileName;
                }
            }
            var srcfile = Path.Combine(bkfile);

            if (!Directory.Exists("C:\\Database"))
            {
                Directory.CreateDirectory("C:\\Database");
            }
            var destfile = Path.Combine("C:\\Database\\TaDatabase.db");

            if (File.Exists(destfile)) File.Delete(destfile);

            else
                File.Move(srcfile, destfile);

            LblMsg.Text = "";
            LblMsg.Text = "Restore Succuss";
        }
    }
}
