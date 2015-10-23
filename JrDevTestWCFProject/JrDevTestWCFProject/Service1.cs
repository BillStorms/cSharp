using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace JrDevTestWCFProject 
{
    public class Service1 : IService1
    {
        public string DisplayProjectName()
        {
            var name = Path.GetFileName(Assembly.GetExecutingAssembly().FullName);
            var version = Path.GetFileName(Assembly.GetExecutingAssembly().ImageRuntimeVersion);
            var result =  string.Format("Assembly Name : {0}  Version Number : {1}",name, version);
            return result;
        }
        
        public string[] DisplayCurrentDateTime()
        {
            DateTime serverTime = DateTime.Now;
            DateTime gmtTime = DateTime.UtcNow;

            var serverTimeString = serverTime.ToString();
            var gmtTimeString = gmtTime.ToString();
            var span = gmtTime - serverTime;
            var diff = (int) span.TotalHours;
            var diffString = String.Format("The time difference between GMT and server time is {0} hours.", diff);

          //  List<string> resultList = new List<string>{serverTime.ToString(), gmtTime.ToString(), diffString};
            
            string[] resultList = new string[3];
            resultList[0] = serverTimeString;
            resultList[1] = gmtTimeString;
            resultList[2] = diffString;
            
            return resultList;
        }

        public string EchoInput(int input)
        {
            return input.ToString();
        }
    }
}