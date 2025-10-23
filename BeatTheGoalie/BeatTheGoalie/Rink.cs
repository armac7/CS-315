using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatTheGoalie
{
    internal class Rink
    {
        int rinkWidth, rinkHeight;
        int circleX, circleY1, circleY2;

        const int OuterCircleSize = 60;
        const int InnerCircleSize = 10;

        public int netFront, netBack, netTop, netBottom;
        public const int BlueLineStart = 40,
            BlueLineWidth = 20,
            NetWidth = 50;

        public Rink(Graphics g, int width, int height, out GoalStick gs)
        {
            // Save the size of the rink
            rinkWidth = width;
            rinkHeight = height;

            netTop = (rinkHeight - NetWidth) / 2;
            netBottom = netTop + NetWidth;
            netBack = rinkWidth - 20;
            netFront = netBack - 20;


            // Figure out the size and location of the circles
            circleX = 2 * rinkWidth / 7;
            circleY1 = rinkHeight / 6;
            circleY2 = rinkHeight - circleY1;

            // Draw the rink
            Draw(g);

            // Now create the goal stick
            gs = new GoalStick(g, netFront, netTop, netBottom);
        }

        public void Draw(Graphics g)
        {
            Pen p;
            Brush b;

            // Draw the net and the learge outer faceoff circles
            using (p = new Pen(Color.Red, 3))
            {
                g.DrawLine(p, netFront, netTop, netBack, netTop);
                g.DrawLine(p, netBack, netTop, netBack, netBottom);
                g.DrawLine(p, netBack, netBottom, netFront, netBottom);
                g.DrawEllipse(p, circleX - OuterCircleSize,
                    circleY1 - OuterCircleSize,
                    2 * OuterCircleSize, 2 * OuterCircleSize);
                g.DrawEllipse(p, circleX - OuterCircleSize,
                    circleY2 - OuterCircleSize,
                    2 * OuterCircleSize, 2 * OuterCircleSize);
            }

            // Finally, draw the blue line and the inner circles
            using (b = new SolidBrush(Color.Blue))
            {
                g.FillRectangle(b, BlueLineStart, 0, BlueLineWidth, rinkHeight);
            }

            using (b = new SolidBrush(Color.Red))
		    {
                g.FillEllipse(b, circleX - InnerCircleSize,
                    circleY1 - InnerCircleSize,
                    2 * InnerCircleSize, 2 * InnerCircleSize);
                g.FillEllipse(b, circleX - InnerCircleSize,
                    circleY2 - InnerCircleSize,
                    2 * InnerCircleSize, 2 * InnerCircleSize);
            }
        }
    }
}
