using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace BeatTheGoalie
{
    internal class Puck
    {
        double deltaX, deltaY;      // Displacements to the net from
                                    // the puck's starting location
        int xStep;                  // The horizontal and verticle 
        double yStep;               // steps from each puck movement
        int target;                 // Where the puck will hit the net
        double puckX, puckY;        // The puck's location
        const int PuckSize = 4;
        Rink rink;                  // A link to the rink, and the 
        MainForm parent;            // form on which the rink is drawn.

        public Puck(Graphics g, MainForm form, int width, int height, Rink rink, Random rand)
        {
            // Save the links to the rink and the form
            this.rink = rink;
            parent = form;

            // Pick a starting location for the puck
            puckX = Rink.BlueLineStart + Rink.BlueLineWidth + PuckSize + rand.Next(height - 40);
            puckY = 20 + rand.Next(height - 40);

            // Pick the spot in the net where the puck is aimed
            target = rand.Next(Rink.NetWidth - 2 * PuckSize) + rink.netTop + PuckSize;

            // Comput ethe offsets and steps to the destination
            deltaX = rink.netFront - puckY;
            deltaY = target - puckY;
            xStep = 20 + rand.Next(20);
            yStep = deltaY / (deltaX / xStep);
        }

        public void Move()
        {
            // Move the puck, and check to see if it's hit the net
            puckX += xStep;
            puckY += yStep;
            if (puckX >= rink.netFront)
            {
                parent.UpdateScoreboard((int)puckX, (int)puckY, PuckSize);
            }
        }

        public void Draw(Graphics g)
        {
            Brush b;
            using (b = new SolidBrush(Color.Black))
                g.FillEllipse(b, (int)puckX - PuckSize, (int)puckY - PuckSize,
                    2 * PuckSize, 2 * PuckSize);
        }
    }
}
