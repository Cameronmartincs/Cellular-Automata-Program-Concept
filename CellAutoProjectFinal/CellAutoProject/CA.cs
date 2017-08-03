using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Cameron Martin
  CA Projct
  Output Window Code*/
namespace CellAutoProject
{
    public partial class CA : Form
    {
        public CA()
        {
          
            InitializeComponent();
            //Events for paint and click
            pictureBox2.BackColor = Color.White;
            pictureBox2.Paint += new PaintEventHandler(this.pictureBox1_Paint);
            pictureBox2.MouseClick += new MouseEventHandler(this.Paint_MouseClick);


            //POTENTIAL FOR RESIZE AND ZOOM
            //pictureBox2.Resize += new EventHandler(this.Form1_Resize);
            //pictureBox2.MouseWheel += new MouseEventHandler(this.PicBox_MouseWheel);
            // pictureBox2.MinimumSize = new Size(150, 150);
            // pictureBox2.Dock = DockStyle.Fill;
        }

        private void CA_Load(object sender, EventArgs e)
        {
            

        }

        

        //pens and graphics for drawing
        public Graphics g;
        static Pen r = new Pen(Color.Black, 1);
        public Brush growth = new SolidBrush(Color.Lime);
        public Brush alive = new SolidBrush(Color.Blue);
        public Brush dead = new SolidBrush(Color.Red);
        public Brush clear = new SolidBrush(Color.White);



        //variables to hold values upon draw
        public int[,] stateCA;
        public int height, width;
        public int cellSize;
        public Rectangle[,] rectArray;






        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            //rectangle array for grid
            rectArray = new Rectangle[width, height];
            //int array for state of each cell, 1 blue, 2 green, 0 white
            stateCA = new int[width, height];
            //determine cell size
            cellSize =(int) (900 /height);
            //create graphics for picturebox
            g = pictureBox2.CreateGraphics();


            //Paint vertical gridlines
            for (int y = 0; y <= width; y ++)
            {
             
                e.Graphics.DrawLine(r, (y * cellSize), 1, (y * cellSize), pictureBox2.Height-1) ;
            }

            //Paint horizontal gruidlines
            for (int x = 0; x <= height; x ++)
            {
                
                e.Graphics.DrawLine(r, 0, (x * cellSize), pictureBox2.Width - 1, (x * cellSize) );

            }
            //draw far right and bottom line
            e.Graphics.DrawLine(r, new Point(pictureBox2.Width-1, 0), new Point(pictureBox2.Width-1, pictureBox2.Height-1));
            e.Graphics.DrawLine(r, new Point(0, pictureBox2.Height-1), new Point(pictureBox2.Width-1, pictureBox2.Height-1));

          
        

           
            
        }

        private void Paint_MouseClick (object sender, MouseEventArgs e )
        {
            //calculate the starting location of the cell that is clicked
            float x = (((int)(e.X / (cellSize))) * cellSize) + r.Width;
            float y = (((int)(e.Y / (cellSize))) * cellSize) + r.Width;
     
            //if right button blue, if left button clear, change state array
            if (e.Button == MouseButtons.Left)
            {
                stateCA[e.X / (int)cellSize, e.Y / (int)cellSize] = 1;
                g.FillRectangle(alive, x, y, cellSize - 1, cellSize -1);
            }
            else if(e.Button == MouseButtons.Right)
            {
                stateCA[e.X / (int)cellSize, e.Y / (int)cellSize] = 0;
                g.FillRectangle(clear, x, y, cellSize -1 , cellSize-1 );
            }

        }




      
        //if form is resized redraw and set size
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            this.MaximumSize = new Size(this.MinimumSize.Width, 1000);
            pictureBox2.Invalidate();

        }










        /* Potential zoom methods

         private void ZoomIn()
           {
               if ((pictureBox2.Width < (minmax * this.Width)) &&
                   (pictureBox2.Height < (minmax * this.Height)))
               {
                pictureBox2.Width = Convert.ToInt32(pictureBox2.Width * zoomfactor);
                pictureBox2.Height = Convert.ToInt32(pictureBox2.Height * zoomfactor);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
               }
           }

     
           private void ZoomOut()
           {
               if ((pictureBox2.Width > (this.Width / minmax)) &&
                   (pictureBox2.Height > (this.Height / minmax)))
               {
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Width = Convert.ToInt32(pictureBox2.Width / zoomfactor);
                pictureBox2.Height = Convert.ToInt32(pictureBox2.Height / zoomfactor);
               }
           }

       
           private void PicBox_MouseWheel(object sender, MouseEventArgs e)
           {
               if (e.Delta < 0)
               {
                   ZoomIn();
               }
               else
               {
                   ZoomOut();
               }
           }
           
           */


        /*POTENTIAL FOR RESIZEABLE GRID
        if ((cellSize.Width * width) <= 150 )
        {
            cellSize.Width = 150;
            cellSize.Height = cellSize.Width;
           // MessageBox.Show("cell height " + cellSize.Height.ToString());
            this.ClientSize = new Size((cellSize.Width * width)  , (cellSize.Height * height ) + ((height) * (int)r.Width)); //
            this.MaximumSize = new Size((cellSize.Width * width) + (((int)r.Width) * (width) + 1), 1000);



            // MessageBox.Show(" hit thisa" + cellSize.Width);
           // MessageBox.Show(SystemInformation.BorderSize.Width.ToString() + " " + SystemInformation.BorderSize.Height.ToString() + " " + SystemInformation.CaptionHeight.ToString());
           // MessageBox.Show("min size form " +this.MinimumSize.ToString());
        }*/




        // this.MinimumSize = new Size((cellSize.Width * width) + (width * (int)r.Width) + 1, pictureBox2.MinimumSize.Height);
        //this.ClientSize = new Size((cellSize.Width * width) + (width * (int)r.Width) + 1, (cellSize.Height * height) + ((height) * (int)r.Width)); //
        // this.MaximumSize = new Size((cellSize.Width * width) + (width * (int)r.Width) + 1, 1000);//+ ((int)r.Width * width)
        // this.MaximumSize = new Size(this.ClientSize.Width, 1000);
        //  MessageBox.Show("hit thisb" + cellSize.Width);


    }//end class
}//end namespace
