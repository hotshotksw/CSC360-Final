using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class ButtonHub
    {
        Dictionary<char, ICommand> commands = new Dictionary<char, ICommand>();

        public void addCommand(ICommand command, char key)
        {
            commands[key] = command;
        }

        public void executeCommand(char key)
        {
            ICommand command = commands[key];
            if (command != null)
            {
                command.Execute();
            }

        }
    }
    
    class UpButton : ICommand
    {
        Controller controller;
        public UpButton(Controller c)
        {
            controller = c;
        }
        
        public void Execute()
        {
            controller.PrintInput("UP");
        }
    }

    class DownButton : ICommand
    {
        Controller controller;
        public DownButton(Controller c)
        {
            controller = c;
        }

        public void Execute()
        {
            controller.PrintInput("DOWN");
        }
    }

    class LeftButton : ICommand
    {
        Controller controller;
        public LeftButton(Controller c)
        {
            controller = c;
        }

        public void Execute()
        {
            controller.PrintInput("LEFT");
        }
    }

    class RightButton : ICommand
    {
        Controller controller;
        public RightButton(Controller c)
        {
            controller = c;
        }

        public void Execute()
        {
            controller.PrintInput("RIGHT");
        }
    }

    class UpInteractButton : ICommand
    {
        Controller controller;
        public UpInteractButton(Controller c)
        {
            controller = c;
        }

        public void Execute()
        {
            controller.PrintInput("UPINTERACT");
        }
    }

    class DownInteractButton : ICommand
    {
        Controller controller;
        public DownInteractButton(Controller c)
        {
            controller = c;
        }

        public void Execute()
        {
            controller.PrintInput("DOWNINTERACT");
        }
    }

    class LeftInteractButton : ICommand
    {
        Controller controller;
        public LeftInteractButton(Controller c)
        {
            controller = c;
        }

        public void Execute()
        {
            controller.PrintInput("LEFTINTERACT");
        }
    }

    class RightInteractButton : ICommand
    {
        Controller controller;
        public RightInteractButton(Controller c)
        {
            controller = c;
        }

        public void Execute()
        {
            controller.PrintInput("UPINTERACT");
        }
    }
}
