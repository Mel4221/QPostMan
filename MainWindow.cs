﻿using QuickTools.QCore;
using QuickTools.QNet;
using System;
using static System.Console; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QPostMan
{
    public partial class MainWindo : Form
    {
        public MainWindo()
        {
            InitializeComponent();
        }
 
        public void MainWindo_Load(object sender, EventArgs e)
        {
       
        }


        private void ClearIfIsEmpty()
        {
            if (this.TextBoxUrl.Text == "http://example.com/")
            {
                this.TextBoxUrl.Text  = "";
            }
        }
        private void FillBack()
        {
            if(this.TextBoxUrl.Text == "")
            {
                this.TextBoxUrl.Text =  "http://example.com/";
            }
        }
        private void TextBoxUrl_MouseHover(object sender, EventArgs e)
        {
            ClearIfIsEmpty(); 
        }

        private void TextBoxUrl_MouseLeave(object sender, EventArgs e)
        {
            FillBack(); 
        }

        private void ProssesRequestBtn_Click(object sender, EventArgs e)
        {
            Uri url;
            string text = this.TextBoxUrl.Text;
            bool isValid =  Uri.TryCreate(text,UriKind.Absolute,out url);
            if (!isValid)
            {
                MessageBox.Show($"This is not a valid URL: {text}");
                return;
            }
            if(text !=  "http://example.com/")
            {
                QHttp http = new QHttp();
                DataGridView requestView = this.RequestHeaders;

                for (int col = 0; col < requestView.RowCount-1; col++)
                {
                    try
                    {
                        http.Headers.Add(new QHttp.Header()
                        {
                            Key = requestView.Rows[col].Cells[0].Value.ToString(),
                            Value = requestView.Rows[col].Cells[1].Value.ToString()
                        });
                    }
                    catch
                    {
                        break;
                    }
                }


                //http.Headers.ForEach(x => { Console.WriteLine($" {x.Key} = {x.Value}"); });
                
                http.Url = text;
        MessageWindow messageWindow = new MessageWindow();

        messageWindow.MessageText = http.Get();
                messageWindow.Show();


                if (http.Headers.Count == 0)
                {
                    return;
                }

                if (http.Headers == null)
                {
                    return;
                }

                for (int col = 0; col < http.Response.Headers.Count-1; col++)
                {
                    try
                    {
                        this.ResponseHeaders.Rows[col].Cells[0].Value = http.Response.Headers.GetKey(col);
                        this.ResponseHeaders.Rows[col].Cells[1].Value = http.Response.Headers[col];
                    }
                    catch
                    {
                             
                        break;
                    }
                }
                
                
                   
                  
                }


            }

        

        private void ClearUrlInput_Click(object sender, EventArgs e)
        {
            this.TextBoxUrl.Text = ""; 
        }

        private void ResponseHeaders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
