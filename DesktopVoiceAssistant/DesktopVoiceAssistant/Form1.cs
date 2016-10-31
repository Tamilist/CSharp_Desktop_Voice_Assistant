using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace DesktopVoiceAssistant
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine srecengine = new SpeechRecognitionEngine();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void startvoicebtn_Click(object sender, EventArgs e)
        {
            srecengine.RecognizeAsync(RecognizeMode.Multiple);
            endvoicebtn.Enabled = true;
            startvoicebtn.Enabled = false;
        }

        //Sets up the different choices for the Engine

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "Hello" });
            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(commands);
            Grammar grammar = new Grammar(gbuilder);

            srecengine.LoadGrammarAsync(grammar);
            srecengine.SetInputToDefaultAudioDevice();
            srecengine.SpeechRecognized += Srecengine_SpeechRecognized;
        }

        private void Srecengine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "Hello":
                    MessageBox.Show("Hello there");
                    break;
            }
        }

        private void endvoicebtn_Click(object sender, EventArgs e)
        {
            srecengine.RecognizeAsyncStop();
            endvoicebtn.Enabled = false;
            startvoicebtn.Enabled = true;
        }
    }
}
