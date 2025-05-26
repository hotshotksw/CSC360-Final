using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Program
    {

        static void Main(string[] args)
        {
            Controller controller = new Controller();

            UpButton upButton = new UpButton(controller);
            DownButton downButton = new DownButton(controller);
            LeftButton leftButton = new LeftButton(controller);
            RightButton rightButton = new RightButton(controller);
            LeftInteractButton leftInteractButton = new LeftInteractButton(controller);
            RightInteractButton rightInteractButton = new RightInteractButton(controller);
            UpInteractButton upInteractButton = new UpInteractButton(controller);
            DownInteractButton downInteractButton = new DownInteractButton(controller);

            ButtonHub buttonHub = new ButtonHub();
            buttonHub.addCommand(upButton, 'w');
            buttonHub.addCommand(downButton, 's');
            buttonHub.addCommand(leftButton, 'a');
            buttonHub.addCommand(rightButton, 'd');
            buttonHub.addCommand(leftInteractButton, 'u');
            buttonHub.addCommand(downInteractButton, 'j');
            buttonHub.addCommand(upInteractButton, 'i');
            buttonHub.addCommand(rightInteractButton, 'k');

            while (true)
            {
                buttonHub.executeCommand(Console.ReadKey(true).KeyChar);
            }
        }
    }
}
