using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Tutorial
    {
        int TutorialID;
        string TutorialName;

        public void SetTutorial(int pID , String pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public String GetTutorial()
        {

        }
        static void Main(string[] args)
        {
            Tutorial pTutor = new Tutorial();
            pTutor.SetTutorial(1, ".Net");
            Console.WriteLine(pTutor.GetTutorial());
            Console.ReadKey();
        }
    }
}
