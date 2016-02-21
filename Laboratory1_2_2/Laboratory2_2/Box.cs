using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2_2
{
    class Box
    {
        private int setX{get;set;}
        private int setY { get; set; }
        private int setWidth { get; set; }
        private int setHeight { get; set; }
        private char setSymbol { get; set; }
        private string message { get; set; }
        public Box()
        { 
        
        }
        public Box(int _setX, int _setY, int _setWidth, int _setHeight, char _setSymbol,ref string _message)
        {
            setX = _setX;
            setY = _setY;
            setWidth = _setWidth;
            setHeight = _setHeight;
            setSymbol = _setSymbol;
            message = _message;

        }

        //RV: The message is not centered in the box.
        public void Draw()
        {
            if (setHeight > 0 || setWidth > 0 || setX > 0 || setY > 0)
            {
                for (int i = 0; i < setHeight; i++)
                {
                       for (int j = 0; j < setWidth; j++)
                            {
                               Console.SetCursorPosition((j + setX), (i + setY));
                                if (i == 0 || i == (setHeight-1))
                                {
                                    Console.Write(setSymbol);
                                }
                                else if (i >= 1 && i < (setHeight-1))
                                {
                                    if (j == 0 || j == (setWidth-1))
                                    {
                                        Console.Write(setSymbol);
                                    }
                                    else
                                    {
                                        if ((setWidth >= 3) || (setHeight >= 3))
                                        {
                                            Console.SetCursorPosition(setX + setWidth / 2, setY + setHeight / 2);
                                            if (message == null)
                                            {
                                                message = "";
                                            }
                                            else if (message.Length < setWidth)
                                            {
                                                Console.Write(message);
                                            }
                                            else if (message.Length >= setWidth)
                                            {
                                                string mess;
                                                mess = message.Substring(0, setWidth - 3);
                                                Console.Write(mess);
                                            }

                                        }
                                    }
                                    }
                                    else
                                    {
                                        Console.Write(" ");
                                    }
                                }
                            }
                        Console.WriteLine();
            }
            else if (setHeight == 0 || setWidth == 0)
            {
                Console.WriteLine("Height or width = 0, Please reload programmand enter cuurect values!!!");
            }
            else
            {
                Console.WriteLine("Height or width < 0, Please reload programmand enter cuurect values!!!!");
            }
        }
    }
}
