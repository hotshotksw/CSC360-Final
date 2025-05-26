using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Command
{
    public class Controller
    {
        string previousKey;
        public void PrintInput(string key)
        {
            Console.WriteLine(GetInputKey(key));
        }

        public string GetInputKey(string input)
        {
            string key = "";
            switch (input)
            {
                case "UP":
                    key = "^";
                    break;
                case "DOWN":
                    key = "v";
                    break;
                case "LEFT":
                    key = (previousKey == "DOWN") ? "QUARTER-CIRCLE LEFT" : "<";
                    break;
                case "RIGHT":
                    key = (previousKey == "DOWN") ? "QUARTER-CIRCLE RIGHT" : ">";
                    break;
                case "LEFTINTERACT":
                    key = "PUNCH";
                    break;
                case "UPINTERACT":
                    key = "SLASH";
                    break;
                case "RIGHTINTERACT":
                    key = "HEAVY SLASH";
                    break;
                case "DOWNINTERACT":
                    key = "KICK";
                    break;
            }
            previousKey = input;
            return key;
        }
    }
}
