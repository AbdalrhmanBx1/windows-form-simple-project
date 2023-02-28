using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
namespace windos_form_app_learn
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer Reader = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
          
        }

       

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
           

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text =Convert.ToString("x= "+ e.X);
            label2.Text =Convert.ToString( "y= "+e.Y);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Reader.State == SynthesizerState.Paused)
            {
                Reader.Resume();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text != "")
            {
                
                start.Enabled = true;
                pause.Enabled = true;
                resume.Enabled = true;
                stop.Enabled = true;
     
            }
            else
            {
                start.Enabled = false;
                pause.Enabled = false;
                resume.Enabled = false; 
                stop.Enabled = false;   


            }

        }

        private void start_Click(object sender, EventArgs e)
        {
            Reader.Dispose();
            Reader = new SpeechSynthesizer();
           // Reader.SpeakAsync(richTextBox1.Text);
            Reader.Speak(richTextBox1.Text);
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (Reader != null)
            {
                if(Reader.State == SynthesizerState.Speaking)
                {
                    Reader.Pause();
                }

            }

        }

        private void stop_Click(object sender, EventArgs e)
        {
            if(Reader.State == SynthesizerState.Speaking)
            {
                Reader.Dispose();
              
            }

        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
            label1.Text =Convert.ToString( e.X);
            label2.Text =Convert.ToString (e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text!="")
            {
                richTextBox1.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("are you ok ?", "are you exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Close();
            }
           

        }

        private void start_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pause_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void time_labil_Click(object sender, EventArgs e)
        {

        }
    }
}
