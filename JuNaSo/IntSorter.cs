using System;
using System.IO;
using System.Collections.Specialized;
using System.Drawing;

namespace junaso
{
	public class IntSorter
	{
		public void Sort(int[] unsorted)
		{
			for(int i=0; i < unsorted.Length - 1; i ++ )
			{
				for(int j=i+1; j < unsorted.Length; j ++ )
				{
					if( unsorted[i] > unsorted[j] )
					{
						Swap( unsorted, i, j );
					}
				}
				/*
				for(int t=0; t < unsorted.Length; t++ )
				{
					if( t + 1 == unsorted[t] )
					{
						Console.WriteLine(t.ToString() + " at correct position");
					}
				}
				Console.WriteLine( "________Iteration " + i + " finished._________");
				*/
				// CreateGridImage (unsorted, 10, i);
			}
		}

		private void Swap( int[] unsorted, int i, int j )
		{
			int tmp = unsorted[j];
			unsorted[j] = unsorted[i];
			unsorted[i] = tmp;
		}

		public static void CreateGridImage(int[] array,
									       int boxSize,
		                                   int index)
        {
            using (var bmp = new System.Drawing.Bitmap(array.Length * boxSize+1, boxSize+1))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.Red);
                    Pen pen = new Pen(Color.Black);
                    pen.Width = 1;

                    //Draw red rectangles for wrong element
					for(int i=0; i < array.Length; i ++ )
					{
						if( i + 1 == array[i] )
						{
		                    Rectangle rect = new Rectangle(boxSize * i, 0, boxSize, boxSize);
		                    g.FillRectangle(new SolidBrush(Color.Green), rect);
						}
					}

                    //Draw horizontal lines
                    for (int i = 0; i <= array.Length;i++ )
                    {
                        g.DrawLine(pen, (i * boxSize), 0, i * boxSize, boxSize);
                    }

                    //Draw vertical lines            
                    for (int i = 0; i <= 1; i++)
                    {
                        g.DrawLine(pen, 0, (i * boxSize), boxSize * array.Length, i * boxSize);
                    }               

                }

				var stream = new FileStream("Sort-" + index +".jpg", FileMode.Create);
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg); 
				stream.Close();
            }
        }
	}
}