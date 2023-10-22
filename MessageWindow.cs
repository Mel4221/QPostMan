using QuickTools.QIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPostMan
{
   
    public partial class MessageWindow : Form
    {
         
        
        public MessageWindow()
        {
            InitializeComponent();
        }

        private void MessageWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void MessageDisplayResultsSaveBtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|"; 
            saveFileDialog.ShowDialog();
            //MessageBox.Show(saveFileDialog.FileName);

            //https://www.youtube.com/watch?v=ShadINC4abI
            try
            {
                string file = saveFileDialog.FileName.ToString(); 
                if (!file.Contains('.'))
                {
                    file += ".txt"; 
                }
                Writer.Write(file, Reader.Read("Request.txt"));
                
            }
            catch
            {
                MessageBox.Show($"It Looks like i could not save the file either on this location or just could not save it");
            }
        }

        private void MessageDisplayBox_Enter(object sender, EventArgs e)
        {
            this.MessageDisplayBox.Text = Reader.Read("Request.txt");
        }
    }
}
