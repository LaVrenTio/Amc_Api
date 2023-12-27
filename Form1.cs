using System.Diagnostics;
namespace Amc_Api
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Get_ink_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            string path = "C:\\lorenzo\\TestApp1\\PrinterAPI.exe";
            string fileReplaced = path.Replace("\\", "/");
            processStartInfo.FileName = fileReplaced;
            processStartInfo.Arguments = "ink";
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;

            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            //creo un file che tenga memoria dei vari valori che ho generato con il pigiare del pulsante
            string filepath = "ink_level.txt";
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                DateTime dateTime = DateTime.Now;
                writer.WriteLine($"Ink Level value: {output}  recorded at ====>{dateTime}");

            }

            process.WaitForExit();
            InkValue_text.Text = output;
        }

        private void Get_ink_btn_MouseMove(object sender, MouseEventArgs e)
        {
            string message = "\"C:\\lorenzo\\repository\\Amc_Api\\bin\\Debug\\net8.0-windows\\ink_level.txt\"";
            string messReplace = message.Replace("\\", "/");

            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(Get_ink_btn, $"ogni volta che pigi il bottone il valore\nverrà memorizzato nel file\n{messReplace}");
        }
    }
}
