using System.Collections;

namespace SimpleRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(textBox_DragOver);
            this.DragDrop += new DragEventHandler(textBox_DragDrop);
        }

        private void textBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void textBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false); // get all files droppeds  
            if (files != null && files.Any())
                textBox1.Text = files.First(); //select the first one  
                showFileName(files.First());
        }

        private void Bt_Browser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textBox1.Text = dialog.FileName;
                    showFileName(dialog.FileName);
                }
            }
        }

        private void showFileName(string filepath)
        {
            string separator = "-";
            var filename = Path.GetFileName(filepath);
            int idx = filename.LastIndexOf(separator);
            string name = filename.Substring(0, idx);
            textBox2.Text= name;
            richTextBox1.Clear();
            richTextBox1.Text = "";
            List<string> lines = getFiles(filepath);
            richTextBox1.Text = (lines.Count + 1) + " Dateien mit dem Namen \"" + name + "\" wurden gefunden:";
            richTextBox1.AppendText(Environment.NewLine);
            foreach (string item in lines)
            {
                richTextBox1.AppendText(Path.GetFileName(item));
                richTextBox1.AppendText(Environment.NewLine);
            }
            
        }

        private List<string> getFiles(string filepath)
        {
            string separator = "-";
            var filename = Path.GetFileName(filepath);
            int idx = filename.LastIndexOf(separator);
            string name = filename.Substring(0, idx);
            var files = Directory.GetFiles(Path.GetDirectoryName(filepath),("*"+Path.GetExtension(filepath)),SearchOption.TopDirectoryOnly);

            List<string> result = new List<string>();
            foreach ( var file in files)
            {
                if (Path.GetFileName(file).Contains(name))
                {
                    result.Add(file);
                }
            }
           
            return result;
        }

        private void Bt_Umbennen_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("Umbennenung gestartet: ");
            richTextBox1.AppendText(Environment.NewLine);
            List<string> list = getFiles(textBox1.Text);
            foreach(var file in list)
            {
                string separator = "-";
                var filename = Path.GetFileName(file);
                int idx = filename.LastIndexOf(separator);
                string endung = filename[(idx+1)..];
                string nameneu = textBox2.Text + separator + endung;

                richTextBox1.AppendText(Path.GetFileName(file) + " -> " + nameneu);
                richTextBox1.AppendText(Environment.NewLine);

                if (File.Exists(file))
                {
                    if(nameneu != String.Empty)
                    {
                        File.Move(file, Path.Combine(Path.GetDirectoryName(file),nameneu));
                        if(!File.Exists(Path.Combine(Path.GetDirectoryName(file), nameneu)))
                        {
                            richTextBox1.AppendText("Es ist ein Fehler bei der Umbenennung der nachfolgenden Datei aufgetaucht: " + file);
                            return;
                        }
                    }
                }
            }
            richTextBox1.AppendText("Umbenennung abgeschlossen");
        }
    }
}