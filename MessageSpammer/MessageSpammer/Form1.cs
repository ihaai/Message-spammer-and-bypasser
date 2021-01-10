using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MessageSpammer
{
    public partial class Form1 : Form
    {

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageSelectOutput.Text = MessageSelectInput.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SpammerButton.Text.Contains("on"))
            {
                spammertimer.Start();
                SpammerButton.Text = "Turn off";
            }
            else
            {
                spammertimer.Stop();
                SpammerButton.Text = "Turn on";
            }
        }

        private void spammertimer_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.F6) !=0 )
            {
                SendKeys.Send(MessageSelectOutput.Text);
                SendKeys.Send("{ENTER}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string content = MessageBypassInput.Text;
            string afterContent = content.Replace("a", "ａ").Replace("A", "Ａ").Replace("b", "ｂ").Replace("B", "Ｂ").Replace("c", "ｃ").Replace("C", "Ｃ").Replace("d", "ｄ").Replace("D", "Ｄ").Replace("e", "ｅ").Replace("E", "Ｅ").Replace("f", "ｆ").Replace("F", "Ｆ").Replace("g", "ｇ").Replace("G", "Ｇ").Replace("h", "ｈ").Replace("H", "Ｈ").Replace("i", "ｉ").Replace("I", "Ｉ").Replace("j", "ｊ").Replace("J", "Ｊ").Replace("k", "ｋ").Replace("K", "Ｋ").Replace("l", "ｌ").Replace("L", "Ｌ").Replace("m", "ｍ").Replace("M", "Ｍ").Replace("n", "ｎ").Replace("N", "Ｎ").Replace("o", "ｏ").Replace("O", "Ｏ").Replace("p", "ｐ").Replace("P", "Ｐ").Replace("q", "ｑ").Replace("Q", "Ｑ").Replace("r", "ｒ").Replace("R", "Ｒ").Replace("s", "ｓ").Replace("S", "Ｓ").Replace("t", "ｔ").Replace("T", "Ｔ").Replace("u", "ｕ").Replace("U", "Ｕ").Replace("v", "ｖ").Replace("V", "Ｖ").Replace("w", "ｗ").Replace("W", "Ｗ").Replace("x", "ｘ").Replace("X", "Ｘ").Replace("y", "ｙ").Replace("Y", "Ｙ").Replace("z", "ｚ").Replace("Z", "Ｚ");

            MessageBypassOutput.Text = afterContent;
        }

        private void MessageBypassOutput_Click(object sender, EventArgs e)
        {
            if (MessageBypassOutput.Text.Length < 0)
            {
                Clipboard.SetText(".");
            }
            else if (MessageBypassOutput.Text.Length > 0)
            {
                Clipboard.SetText(MessageBypassOutput.Text);
            }
        }
    }
}
