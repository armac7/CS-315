using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatTheGoalie
{
    internal class GoalStick
    {
        int stickX, stickY, netTop, netBottom, stickLength;
        const int stickWidth = 4;

        public GoalStick(Graphics g, int netX, int top, int bottom)
        {
            // Save the top and bottom cordinates of the net

            netTop = top;
            netBottom = bottom;

            // Position the stick in front of the net
            stickX = netX - 5 - stickWidth;
            stickLength = (netBottom - netTop) / 4;
            stickY = (netTop + (netBottom - netTop) / 2 - (stickLength / 2));

            // Draw the goal stick
            Draw(g);
        }

        public void Draw(Graphics g)
        {
            Brush b;

            using (b = new SolidBrush(Color.Black))
                g.FillRectangle(b, stickX, stickY, stickWidth, stickLength);
        }

        public void Move(Graphics g, int mouseY)
        {
            // Make sure the stick stays in front of the net.

            if (mouseY < netTop)
                stickY = netTop;
            else if (mouseY + stickLength > netBottom)
                stickY = netBottom - stickLength;
            else
                stickY = mouseY;
        }

        public bool Scored(int xPosn, int yPosn, int puckRadius)
        {
            bool stickMissed = (yPosn + puckRadius < stickY) || (yPosn - puckRadius > stickY + stickLength);
            bool pastStick = (xPosn - puckRadius) > (stickX + stickWidth);
            bool insideNet = (yPosn - puckRadius) > netTop && (yPosn + puckRadius) < netBottom;


            // Check to see if the current puck position will
            // miss the goalie stick (and score), or hit the stick.
            if (pastStick && stickMissed && insideNet)
                return true;
            return false;
        }
    }
}
