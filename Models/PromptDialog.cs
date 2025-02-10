using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Dmo;

namespace ChatApp_SkoleProsjekt.Models
{
    public static class PromptDialog
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
           
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmButton = new Button() { Text = "Ok", Left = 280, Width = 80, Top = 80 };
            confirmButton.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmButton);
            prompt.AcceptButton = confirmButton;
            
            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;    
        }
    }
}
