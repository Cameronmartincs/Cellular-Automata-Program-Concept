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
  Input Window Code*/
namespace CellAutoProject
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
         
        }


        /*These variables hold the CA instance, temp, and neighborhood array*/
        CA currentCA;
        bool start = false,
             next = false, finish = false;


        //Defines neighborhood, Allows for other defined neighborhoods. 
        //Cordinates indicate the cell oriented to the center cell.
        static int tx = 0;
        static int ty = 0;
        public int[,] mNeighborhood = new int[,] {  { - 1,  1 },     { 0 ,  1 },    {  1,  1 },
                                                    { - 1, 0 },              { 1, 0  },
                                                    { - 1, - 1 },     { 0 , - 1 },    {  1, - 1 } };

       
        private void Input_Load(object sender, EventArgs e)
        {
           
           

        }


        /*When open is clicked*/
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //create new CA and define grid dimensions
            currentCA = new CA();
            currentCA.height = (int)numHeight.Value;
            currentCA.width = (int)numWidth.Value;
            currentCA.Show();
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            //Refresh the instance 
            currentCA.height = (int)numHeight.Value;
            currentCA.width = (int)numWidth.Value;
            currentCA.pictureBox2.Refresh();
          
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //worker event to process CA
            var worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            start = true;
            worker.RunWorkerAsync();

        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {

        //used to determine finish
        int finMax = (finish) ? (int)numHeight.Value : 1;
        for (int f = 0; f < finMax; f++)
        { 
            //Change green cells to blue cells
            for (int x = 1; x < numHeight.Value; x++)
            {
                for (int y = 1; y < numWidth.Value; y++)
                {
                    if (currentCA.stateCA[x, y] == 2)
                    {
                     
                        //find cell position get cell size and fill green cells at state 2 to state 1 blue
                        currentCA.rectArray[x, y].X = (currentCA.cellSize * x) + 1;
                        currentCA.rectArray[x, y].Y = (currentCA.cellSize * y) + 1;
                        currentCA.rectArray[x, y].Size = new Size((int)currentCA.cellSize - 1, (int)currentCA.cellSize - 1);
                        currentCA.g.FillRectangle(currentCA.alive, currentCA.rectArray[x, y]);
                        currentCA.stateCA[x, y] = 1;

                    }
                }
            }

           

         
                //process CA if start is true
                for (int x = 1; x < numHeight.Value - 1; x++)
                {
                    for (int y = 1; y < numWidth.Value - 1; y++)
                    {
                        int sum = 0;
                        //used for stop button
                        if (start == false)
                        {
                            MessageBox.Show("we stopped!");
                            goto End;

                        }

                        //run through neighborhood array and calculate temp variables for state get sum of current location neighborhood
                        for (int r = 0; r < mNeighborhood.GetLength(0); r++)
                        {
                            //define temp variables according to neighborhood array, change array for different neighborhoods
                            tx = mNeighborhood[r, 0] + x;
                            ty = mNeighborhood[r, 1] + y;
                            if (currentCA.stateCA[tx, ty] != 2)
                            {
                                sum += currentCA.stateCA[tx, ty];
                            }
                        }

                        //get cell size for fillrectangle
                        currentCA.rectArray[x, y].X = (currentCA.cellSize * x) + 1;
                        currentCA.rectArray[x, y].Y = (currentCA.cellSize * y) + 1;
                        currentCA.rectArray[x, y].Size = new Size((int)currentCA.cellSize - 1, (int)currentCA.cellSize - 1);

                        //if the neighborhood sum is at birth number, fill cell to green and change state array
                        if (sum == 1 && currentCA.stateCA[x, y] != 1)
                        {
                            currentCA.g.FillRectangle(currentCA.growth, currentCA.rectArray[x, y]);
                            currentCA.stateCA[x, y] = 2;
                            sum = 0;

                        }
                    }
                }
            }

        End:; //used for stop
        finish = false;
        }


        //Select next for next step in the CA
        private void btnNext_Click(object sender, EventArgs e)
        {
         
            next = true;
          
        }

        //Finishes the cell generation according to the grid
        //2.0 will replace the worker to a task
        private void btnExplode_Click(object sender, EventArgs e)
        {

            var worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            start = true;
            finish = true;
            worker.RunWorkerAsync();
         
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            start = false;
        }

       
        
   
    }
}
