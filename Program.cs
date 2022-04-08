using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace text_to_speech_converter
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lets see how to create a text to speech converter");
            //step1.Importing Required namespace(predefine framework class libraries/functionalities-FCL)
            //step2.Creating an object-(Instantiation)and setting output to default audio devices()
            //step3.Calling functionality speak()
            SpeechSynthesizer spk = new SpeechSynthesizer();//creating object
            spk.SetOutputToDefaultAudioDevice();
            string message = Console.ReadLine();//taking input from the user
            spk.Speak(message);
            Console.WriteLine("Here is the output..!!");
        }
    }
}
