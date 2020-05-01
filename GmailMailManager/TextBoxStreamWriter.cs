using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GmailMailManager
{
    public class TextBoxStreamWriter : TextWriter
    {
        TextBox txtConsole = null;

        public TextBoxStreamWriter(TextBox output)
        {
            txtConsole = output; 
        }

        public override void Write(char value)
        {
            base.Write(value);
            //Consoleoutput.AppendText(value.ToString());
            //update a UI element from a non-UI thread
            if (txtConsole.InvokeRequired)
            {
                txtConsole.Invoke(new Action(() =>
                {
                    txtConsole.AppendText(value.ToString());
                }));
            }
            else
            {
                txtConsole.AppendText(value.ToString());
            }
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}