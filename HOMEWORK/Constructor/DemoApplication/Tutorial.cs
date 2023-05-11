using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    public class Tutorial
    {
        int TutorialID;
        string TutorialName;

        public GetTutorial()
        {
            TutorialID = 0;
            TutorialName = "default";
        }
        public void SetTutorial(int pID , String pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
    }

}

