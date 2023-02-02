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
        public string MessageText;// = null; 
        
        public MessageWindow()
        {
            InitializeComponent();
        }

        private void MessageWindow_Load(object sender, EventArgs e)
        {
            this.MessageDisplayBox.Text = MessageText; 
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
                if (file.IndexOf('.') == -1)
                {
                    file += ".txt"; 
                }
                Writer.Write(file, this.MessageText);
            }
            catch
            {
                MessageBox.Show($"It Looks like i could not save the file either on this location or just could not save it");
            }
        }

      

    
    }
}
