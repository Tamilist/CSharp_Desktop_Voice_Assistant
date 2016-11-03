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
using System.Diagnostics;


namespace DesktopVoiceAssistant
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine srecengine = new SpeechRecognitionEngine();
        
        public Form1()
        {
            InitializeComponent();
        }

        //disables the enable voice control button so it cant be clicked again until the
        //disable voice control button is clicked

        private void startvoicebtn_Click(object sender, EventArgs e)
        {
            srecengine.RecognizeAsync(RecognizeMode.Multiple);
            endvoicebtn.Enabled = true;
            startvoicebtn.Enabled = false;
            logtextbox.Text += "Hello There\n";
        }

        //Sets up the different commands for the engine to recognize

        private void Form1_Load(object sender, EventArgs e)
        {
            //Array of available commands the engine can recognize
            Choices commands = new Choices();
            commands.Add(new string[] { "open notepad", "open google", "open browser", "open default pages",
            "open control panel", "change wallpaper"});

            //sets up the engine
            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(commands);
            Grammar grammar = new Grammar(gbuilder);

            srecengine.LoadGrammarAsync(grammar);
            srecengine.SetInputToDefaultAudioDevice();
            srecengine.SpeechRecognized += Srecengine_SpeechRecognized;
        }

        //When the speech engine recognizes a command it will perform the appropiate action and
        //display a message for the user

        private void Srecengine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "open notepad":
                    Process.Start("notepad");
                    logtextbox.Text += "Opening NotePad\n";
                    break;

                case "open google":
                    Process.Start("http://google.com/");
                    logtextbox.Text += "Opening Google\n";
                    break;

                case "open default pages":
                    System.Diagnostics.Process.Start("http://www.google.com");
                    System.Diagnostics.Process.Start("https://github.com/");
                    System.Diagnostics.Process.Start("http://stackoverflow.com/");
                    logtextbox.Text += "Opening Pages\n";
                    break;

                case "open browser":
                    Process.Start("http://www.google.com");
                    logtextbox.Text += "Opening default browser\n";
                    break;

                case "open control panel":
                    Process.Start("control.exe");
                    logtextbox.Text += "Opening Control Panel\n";
                    break;

                
            }
        }

        //When the end voice control button is clicked it is disabled while
        //the start voice control button will be re-enabled

        private void endvoicebtn_Click(object sender, EventArgs e)
        {
            srecengine.RecognizeAsyncStop();
            endvoicebtn.Enabled = false;
            startvoicebtn.Enabled = true;
            logtextbox.Text += "Goodbye\n";
        }

        private void cmdlabel_Click(object sender, EventArgs e)
        {
            CommandsForm openhelp = new CommandsForm();
            openhelp.Show();

        }
    }
}
