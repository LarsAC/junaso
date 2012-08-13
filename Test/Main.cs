using System.IO;
using System.Drawing;

namespace Test
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			CreateGridImage (10, 1, 5, 1, 10, 3);
		}

		public static void CreateGridImage(int maxXCells,
									       int maxYCells,
									       int cellXPosition,
									       int cellYPosition,
									       int boxSize,
		                                   int index)
        {
            using (var bmp = new System.Drawing.Bitmap(maxXCells * boxSize+1, maxYCells * boxSize+1))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Yellow);
                    Pen pen = new Pen(Color.Black);
                    pen.Width = 1;

                    //Draw red rectangle to go behind cross
                    Rectangle rect = new Rectangle(boxSize * (cellXPosition - 1), boxSize * (cellYPosition - 1), boxSize, boxSize);
                    g.FillRectangle(new SolidBrush(Color.Red), rect);

                    //Draw cross
                    g.DrawLine(pen, boxSize * (cellXPosition - 1), boxSize * (cellYPosition - 1), boxSize * cellXPosition, boxSize * cellYPosition);
                    g.DrawLine(pen, boxSize * (cellXPosition - 1), boxSize * cellYPosition, boxSize * cellXPosition, boxSize * (cellYPosition - 1));

                    //Draw horizontal lines
                    for (int i = 0; i <= maxXCells;i++ )
                    {
                        g.DrawLine(pen, (i * boxSize), 0, i * boxSize, boxSize * maxYCells);
                    }

                    //Draw vertical lines            
                    for (int i = 0; i <= maxYCells; i++)
                    {
                        g.DrawLine(pen, 0, (i * boxSize), boxSize * maxXCells, i * boxSize);
                    }                
                }

				var stream = new FileStream("Sort-" + index, FileMode.Create);
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg); 
				stream.Close();
            }
        }

	}
}
